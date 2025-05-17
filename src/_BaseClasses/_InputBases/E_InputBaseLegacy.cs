
using System;
using UnityEngine;
using UnityEngine.Events;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _InputBases
        {
            public abstract class BaseInputActionLegacy : MonoBehaviour
            {
                public UnityEvent OnPerformedUnity;
                public Action OnPerformed;

                public abstract void HandleInput();

                protected void Perform()
                {
                    Debug.Log($"{name}: Performed!");
                    OnPerformedUnity?.Invoke();
                    OnPerformed?.Invoke();
                }

                protected virtual void Update()
                {
                    HandleInput();
                }
            }

            // tap inputs
            public abstract class TapInputActionBase : BaseInputActionLegacy
            {
                protected bool wasPressedLastFrame = false;

                public override void HandleInput()
                {
                    bool currentlyPressed = IsPressed();
                    if (currentlyPressed && !wasPressedLastFrame)
                    {
                        Perform();
                    }
                    wasPressedLastFrame = currentlyPressed;
                }

                public abstract bool IsPressed();
            }
            public class KeyTapInputAction : TapInputActionBase
            {
                [Tooltip("Key to check for tap input")]
                public KeyCode key = KeyCode.Space;

                public override bool IsPressed()
                {
                    return Input.GetKey(key);
                }
                public void SetKey(KeyCode newKey)
                {
                    key = newKey;
                }
            }


            // hold inputs
            public abstract class HoldInputActionBase : BaseInputActionLegacy
            {
                public float holdTime = 0.5f;
                private float holdTimer = 0f;
                private bool hasPerformed = false;

                public override void HandleInput()
                {
                    if (IsPressed())
                    {
                        holdTimer += Time.deltaTime;

                        if (holdTimer >= holdTime && !hasPerformed)
                        {
                            Perform();
                            hasPerformed = true;
                        }
                    }
                    else
                    {
                        holdTimer = 0f;
                        hasPerformed = false;
                    }
                }

                public abstract bool IsPressed();
            }
            public class KeyHoldInputAction : HoldInputActionBase
            {
                public KeyCode key = KeyCode.LeftShift;

                public override bool IsPressed()
                {
                    return Input.GetKey(key);
                }
                public void SetKey(KeyCode newKey)
                {
                    key = newKey;
                }
            }


            // composite inputs
            public abstract class CompositeInputActionBase : BaseInputActionLegacy
            {
                public override void HandleInput()
                {
                    if (AreAllInputsPressed())
                    {
                        Perform();
                    }
                }

                protected abstract bool AreAllInputsPressed();
            }
            public class MultiKeyCompositeInputAction : CompositeInputActionBase
            {
                public KeyCode[] keys = new KeyCode[] { KeyCode.W, KeyCode.LeftShift };

                protected override bool AreAllInputsPressed()
                {
                    foreach (var key in keys)
                    {
                        if (!Input.GetKey(key))
                            return false;
                    }
                    return true;
                }
                public void SetKey(KeyCode[] newKeys)
                {
                    keys = newKeys;
                }
            }

        }


    }
}