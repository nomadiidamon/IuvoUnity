using IuvoUnity._BaseClasses._InputBases._Legacy;
using IuvoUnity._Interfaces;
using IuvoUnity._StateMachine;
using System.Collections.Generic;
using UnityEngine;

namespace IuvoUnity
{
    namespace _Input
    {
        namespace _Controllers
        {
            public abstract class BaseGravityBodyController : GravityBody, ITogglable
            {
                [Header("Input System")]
                [Tooltip("Legacy input actions attached to this character.")]
                public List<BaseInputActionLegacy> inputActions = new List<BaseInputActionLegacy>();

                [Header("Movement")]
                protected Vector2 moveInput; // Movement input vector (from WASD, stick, etc.)

                [SerializeField] protected float walkSpeed = 5f;
                [SerializeField] protected float sprintSpeed = 10f;
                protected float currentSpeed;

                [Header("State Machine")]
                public GenericStateMachine stateMachine;

                public bool IsEnabled { get; set; }
                public bool IsActive { get; set; }

                protected override void Awake()
                {
                    base.Awake();
                    SetupInputs();
                    SetupStateMachine();

                    IsEnabled = true;
                    IsActive = true;
                }

                protected virtual void SetupInputs()
                {
                    // Hook up or find existing BaseInputActionLegacy components
                    inputActions.AddRange(GetComponents<BaseInputActionLegacy>());
                }

                protected virtual void SetupStateMachine()
                {
                    if (stateMachine == null)
                        stateMachine = GetComponent<GenericStateMachine>();

                    if (stateMachine != null && stateMachine.defaultState != null)
                        stateMachine.Start(); // Initializes to default state
                }

                protected virtual void Update()
                {
                    if (!IsEnabled || !IsActive)
                        return;

                    if (stateMachine != null)
                        stateMachine.Update(); // Logic-only update
                }

                protected override void FixedUpdate()
                {
                    if (!IsEnabled || !IsActive)
                        return;

                    base.FixedUpdate();
                    HandleMovement(); // Physics-based movement


                    if (stateMachine != null)
                        stateMachine.FixedUpdate(); // Logic-only update
                }


                protected virtual void HandleMovement()
                {
                    currentSpeed = GetCurrentSpeed();

                    Vector3 moveDir = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
                    Vector3 move = moveDir * currentSpeed * Time.deltaTime;

                    Vector3 newPosition = rb.position + transform.TransformDirection(move);
                    rb.MovePosition(newPosition);
                }

                protected virtual float GetCurrentSpeed()
                {
                    // Override to modify logic based on state or inputs
                    return walkSpeed;
                }

                protected abstract void HandleMoveInput(); // e.g., set moveInput via axis or bindings


                #region ITogglable Implementation

                public void Enable()
                {
                    if (!IsEnabled)
                    {
                        IsEnabled = true;
                        OnEnable();
                    }
                }

                public virtual void OnEnable() { }

                public void Disable()
                {
                    if (IsEnabled)
                    {
                        IsEnabled = false;
                        OnDisable();
                    }
                }

                public virtual void OnDisable() { }

                public void Activate()
                {
                    if (!IsActive)
                    {
                        IsActive = true;
                        OnActivate();
                    }
                }

                public virtual void OnActivate() { }

                public void Deactivate()
                {
                    if (IsActive)
                    {
                        IsActive = false;
                        OnDeactivate();
                    }
                }

                public virtual void OnDeactivate() { }

                #endregion


            }
        }
    }
}