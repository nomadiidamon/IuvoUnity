using System;
using System.Collections.Generic;
using UnityEngine;

namespace IuvoUnity
{
    namespace IuvoStateMachine
    {
        [System.Serializable]
        public abstract class State : ScriptableObject, IStateMachineCondition
        {
            public string stateName;
            public Dictionary<string, AnimationClip> animations;

            public virtual bool CanEnter(StateMachine stateMachine)
            {
                return true;
            }
            public abstract void OnEnter(StateMachine stateMachine);
            public abstract void OnUpdate(StateMachine stateMachine);
            public abstract void OnFixedUpdate(StateMachine stateMachine);
            public abstract void OnExit(StateMachine stateMachine);
            public abstract bool IsConditionMet(StateMachine stateMachine);
        }
    }
}
