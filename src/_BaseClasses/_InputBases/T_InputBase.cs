using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace IuvoUnity
{

    namespace _BaseClasses
    {

        namespace _InputBases
        {
            public abstract class InputActionBase : MonoBehaviour
            {
                public UnityEvent OnPerformedUnity;
                public System.Action OnPerformed;

                public InputAction inputAction;

                protected virtual void OnEnable()
                {
                    if (inputAction != null)
                    {
                        inputAction.Enable();
                        inputAction.performed += OnInputPerformed;
                    }
                }

                protected virtual void OnDisable()
                {
                    if (inputAction != null)
                    {
                        inputAction.performed -= OnInputPerformed;
                        inputAction.Disable();
                    }
                }

                protected virtual void OnInputPerformed(InputAction.CallbackContext context)
                {
                    Perform();
                }

                protected void Perform()
                {
                    Debug.Log($"{name}: Performed!");
                    OnPerformedUnity?.Invoke();
                    OnPerformed?.Invoke();
                }
            }
        }
    }
}