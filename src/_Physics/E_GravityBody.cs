using IuvoUnity._Physics;
using IuvoUnity._Singletons._Managers;
using UnityEngine;

namespace IuvoUnity
{
    namespace _Input
    {
        namespace _Controllers
        {
            [RequireComponent(typeof(Rigidbody))]
            public class GravityBody : MonoBehaviour
            {
                protected Rigidbody rb;
                protected GravityZone gravZone;

                [Header("Gravity Settings")]
                public bool useGravity = true;                // Toggle gravity
                public bool useGlobalGravity = true;          // Toggle global vs. local
                public Vector3 customDirection = Vector3.down;
                public float customStrength = 9.81f;

                [Header("Ground Detection")]
                public GroundCheck groundCheck;
                public bool onlyApplyGravityWhenAirborne = true;


                protected virtual void Awake()
                {
                    rb = GetComponent<Rigidbody>();
                    rb.useGravity = false;

                    if (groundCheck == null)
                    {
                        groundCheck = GetComponentInChildren<GroundCheck>();
                    }
                }


                protected virtual void FixedUpdate()
                {
                    if (!useGravity) return;
                    if (onlyApplyGravityWhenAirborne && groundCheck != null && groundCheck.isGrounded) return;

                    Vector3 gravity = CalculateGravity();
                    ApplyGravity(gravity);
                    AlignToGravity(gravity);
                }

                protected virtual Vector3 CalculateGravity()
                {
                    if (gravZone != null)
                    {
                        return gravZone.GetGravityDirection(transform.position) * gravZone.zoneGravityStrength;
                    }

                    if (useGlobalGravity && GravityManager.Instance != null)
                    {
                        return GravityManager.Instance.GetGlobalGravity();
                    }

                    return customDirection.normalized * customStrength;
                }

                protected virtual void ApplyGravity(Vector3 gravity)
                {
                    rb.AddForce(gravity, ForceMode.Acceleration);
                }

                protected virtual void AlignToGravity(Vector3 gravity)
                {
                    Vector3 gravityDirection = -gravity.normalized;
                    Quaternion targetRotation = Quaternion.FromToRotation(transform.up, gravityDirection) * transform.rotation;
                    rb.MoveRotation(Quaternion.Slerp(transform.rotation, targetRotation, Time.fixedDeltaTime * 5f));
                }

                public void SetLocalGravity(Vector3 direction, float strength)
                {
                    useGlobalGravity = false;
                    customDirection = direction.normalized;
                    customStrength = strength;
                }

                public void EnableGlobalGravity() => useGlobalGravity = true;
                public void DisableGravity() => useGravity = false;
                public void EnableGravity() => useGravity = true;

                public void EnterGravityZone(GravityZone zone) => gravZone = zone;
                public void ExitGravityZone() => gravZone = null;

                protected virtual void OnDrawGizmosSelected()
                {
                    if (!Application.isPlaying || !useGravity) return;

                    Vector3 gravity = CalculateGravity();

                    Gizmos.color = Color.cyan;
                    Gizmos.DrawRay(transform.position, gravity);

                    Gizmos.color = Color.magenta;
                    Gizmos.DrawRay(transform.position, -gravity.normalized * 2f);
                }
            }
        }
    }
}