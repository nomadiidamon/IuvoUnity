using IuvoUnity._BaseClasses._InputBases;
using UnityEngine;

namespace IuvoUnity
{
    namespace _Input
    {

        namespace _Controllers
        {
            public class ThirdPersonController : PlayerControllerBase
            {
                public Transform cameraTransform;
                public float rotationSmoothTime = 0.12f;
                private float rotationVelocity;
                public float cameraDistance = 5f;
                public float verticalRotationLimit = 80f;
                public float mouseSensitivity = 100f;
                private float yaw;
                private float pitch;


                protected override void HandleMoveInput()
                {
                    moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

                    Vector3 inputDirection = new Vector3(moveInput.x, 0, moveInput.y).normalized;

                    if (inputDirection.magnitude >= 0.1f)
                    {
                        // Rotate player relative to camera
                        float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
                        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationVelocity, rotationSmoothTime);

                        transform.rotation = Quaternion.Euler(0, angle, 0);
                    }
                }

                private void HandleCameraLook()
                {
                    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

                    yaw += mouseX;
                    pitch -= mouseY;
                    pitch = Mathf.Clamp(pitch, -verticalRotationLimit, verticalRotationLimit);

                    // Apply rotation to the camera
                    cameraTransform.rotation = Quaternion.Euler(pitch, yaw, 0);

                    // Position the camera behind the player
                    Vector3 direction = new Vector3(0, 0, -cameraDistance);
                    cameraTransform.position = transform.position + cameraTransform.rotation * direction;
                }


                protected override void OnJump()
                {
                    base.OnJump();
                    // Add jump logic here

                    
                }

                protected override void Update()
                {
                    base.Update();
                    HandleCameraLook();
                }
            }
        }
    }
}