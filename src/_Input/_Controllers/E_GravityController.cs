using IuvoUnity._Physics;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float gravityStrength;
    public bool applyGravity;
    public GroundCheck groundCheck;

    void Start()
    {
    }

    void FixedUpdate()
    {
        if (groundCheck.isGrounded) 
        {
            applyGravity = false;
        }
        else
        {
            applyGravity = true;
        }
    }

    public Vector3 UpdateGravity(Vector3 vec)
    {
        if (applyGravity)
        {
            Vector3 copy = vec;
            copy.y = gravityStrength;

            return copy;
        }
        else
        {
            return vec;
        }
    }
}
