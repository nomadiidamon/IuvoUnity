using IuvoUnity._BaseClasses._InputBases;
using UnityEngine;

namespace IuvoUnity
{
    namespace _Input
    {

        namespace _Controllers
        {
            public class FirstPersonController : PlayerControllerBase
            {
                public float mouseSensitivity = 100f;
                private float xRotation = 0f;
                public Transform playerCamera;

                protected override void HandleMoveInput()
                {
                    // WASD or arrow keys for movement
                    moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

                    // Mouse look
                    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

                    xRotation -= mouseY;
                    xRotation = Mathf.Clamp(xRotation, -90f, 90f);

                    playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
                    transform.Rotate(Vector3.up * mouseX);
                }

                protected override void OnJump()
                {
                    base.OnJump();
                    // Add jump force to Rigidbody or CharacterController
                }
            }
        }
    }
}