using UnityEngine;

namespace IuvoUnity
{
    namespace _Physics
    {
        public class GroundCheck : MonoBehaviour
        {
            [SerializeField] float radiusToCheck = 0.25f;
            [SerializeField] float distanceToCheck = 1.5f;
            public bool isGrounded { get; private set; }

            void Update()
            {
                Vector3 origin = transform.position;
                isGrounded = Physics.SphereCast(origin, radiusToCheck, Vector3.down, out _, distanceToCheck);
            }
        }
    }
}