using IuvoUnity._DataStructs;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _InputBases
        {
            namespace _Legacy
            {
                public abstract class BaseInputActionLegacy : MonoBehaviour
                {
                    [Header("Events")]
                    [Tooltip("Invoked when the input action is performed.")]
                    public UnityEvent OnPerformedUnity;

                    [Tooltip("Optional C# Action invoked when the input action is performed.")]
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

                // Tap inputs
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
                    [Header("Tap Input Settings")]
                    [Tooltip("Key to check for tap input.")]
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

                // Hold inputs
                public abstract class HoldInputActionBase : BaseInputActionLegacy
                {
                    [Header("Hold Input Settings")]
                    [Tooltip("Time in seconds required to hold before the action triggers.")]
                    public float holdTime = 0.5f;

                    protected float holdTimer = 0f;
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
                    [Header("Hold Input Settings")]
                    [Tooltip("Key to check for hold input.")]
                    public KeyCode key = KeyCode.LeftShift;

                    [Tooltip("Range of hold time (min, max) in seconds.")]
                    public RangeF holdTimeRange = new RangeF(0f, 2f);

                    [Tooltip("Clamped hold time value.")]
                    public ClampedFloat holdDuration;

                    private bool isHolding = false;
                    private bool hasTriggeredHoldThreshold = false;

                    [Header("Events")]
                    [Tooltip("Event triggered when key is released, providing clamped hold time.")]
                    public UnityEvent<float> OnHoldReleasedWithDuration;

                    [Tooltip("Event triggered once when hold time crosses threshold.")]
                    public UnityEvent OnHoldThresholdReached;

                    private void Awake()
                    {
                        holdDuration = new ClampedFloat(holdTimeRange, 0f);
                    }

                    public override bool IsPressed()
                    {
                        return Input.GetKey(key);
                    }

                    public void SetKey(KeyCode newKey)
                    {
                        key = newKey;
                    }

                    public override void HandleInput()
                    {
                        if (IsPressed())
                        {
                            isHolding = true;
                            holdTimer += Time.deltaTime;
                            holdDuration.Value = holdTimer;

                            if (!hasTriggeredHoldThreshold && holdTimer >= holdTime)
                            {
                                OnHoldThresholdReached?.Invoke();
                                hasTriggeredHoldThreshold = true;
                            }
                        }
                        else if (isHolding)
                        {
                            OnHoldReleasedWithDuration?.Invoke(holdDuration.Value);

                            holdTimer = 0f;
                            holdDuration.Value = 0f;
                            isHolding = false;
                            hasTriggeredHoldThreshold = false;
                        }
                    }
                }

                // Composite inputs
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
                    [Header("Composite Input Settings")]
                    [Tooltip("Keys that must be pressed simultaneously to perform the action.")]
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
}
