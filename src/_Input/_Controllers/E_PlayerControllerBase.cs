using IuvoUnity._BaseClasses._InputBases._Legacy;
using IuvoUnity._Interfaces;
using UnityEngine;

namespace IuvoUnity
{
    namespace _Input
    {
        namespace _Controllers
        {
            public abstract class PlayerControllerBase : GravityBody, ITogglable
            {
                // Inputs
                protected KeyTapInputAction jumpInput;
                protected KeyHoldInputAction sprintInput;
                protected KeyTapInputAction shootInput;
                protected Vector2 moveInput; // from WASD or analog stick, you can implement a MoveInputAction later if you want

                [Header("Movement Settings")]
                [SerializeField] protected float walkSpeed = 5f;
                [SerializeField] protected float sprintSpeed = 10f;
                protected float currentSpeed;

                public bool IsEnabled { get; set; }
                public bool IsActive { get; set; }


                protected override void Awake()
                {
                    base.Awake();
                    SetupInputs();

                    // always start with the inputs enabled and active.
                    // Derived classes can adjust where needed
                    IsEnabled = true;
                    IsActive = true;

                }
                protected virtual void SetupInputs()
                {
                    jumpInput = gameObject.AddComponent<KeyTapInputAction>();
                    jumpInput.SetKey(KeyCode.Space);

                    sprintInput = gameObject.AddComponent<KeyHoldInputAction>();
                    sprintInput.SetKey(KeyCode.LeftShift);

                    shootInput = gameObject.AddComponent<KeyTapInputAction>();
                    shootInput.SetKey(KeyCode.Mouse0);


                    jumpInput.OnPerformed += OnJump;
                    sprintInput.OnPerformed += OnSprintStart;
                    shootInput.OnPerformed += OnShoot;
                }
                protected virtual void Update()
                {
                    if (!IsActive || !IsEnabled) return;

                    HandleMoveInput();
                    HandleMovement();
                }
                protected abstract void HandleMoveInput();  // e.g., get input axis or keys for movement

                protected virtual void HandleMovement()
                {
                    // Example movement logic based on input move vector and speed
                    currentSpeed = sprintInput.IsPressed() ? sprintSpeed : walkSpeed;

                    Vector3 moveDir = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
                    Vector3 move = moveDir * currentSpeed * Time.fixedDeltaTime;

                    Vector3 newPosition = rb.position + transform.TransformDirection(move);
                    
                    rb.MovePosition(newPosition);
                }
                protected virtual void OnJump()
                {
                    Debug.Log("Jump performed");
                    // Implement jump logic in subclass if needed
                }
                protected virtual void OnSprintStart()
                {
                    Debug.Log("Sprint started");
                    // Optionally override in subclass
                }
                protected virtual void OnShoot()
                {
                    Debug.Log("Shoot performed");
                    // Override in subclass
                }

                public void Enable()
                {
                    if (!IsEnabled)
                    {
                        IsEnabled = true;
                        OnEnable();
                    }
                }
                public virtual void OnEnable()
                {

                }
                public void Disable()
                {
                    if (IsEnabled)
                    {
                        IsEnabled = false;
                        OnDisable();
                    }
                }
                public virtual void OnDisable()
                {

                }
                public void Activate()
                {
                    if (!IsActive)
                    {
                        IsActive = true;
                        OnActivate();
                    }
                }
                public virtual void OnActivate()
                {

                }
                public void Deactivate()
                {
                    if (IsActive)
                    {
                        IsActive = false;
                        OnDeactivate();
                    }
                }
                public virtual void OnDeactivate()
                {

                }
            }
        }
    }
}