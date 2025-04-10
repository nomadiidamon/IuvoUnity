using System;
using UnityEngine;

namespace IuvoUnity
{
    namespace IuvoStateMachine
    {
        [CreateAssetMenu(fileName = "IdleState", menuName = "StateMachine/States/IdleState")]
        public abstract class IdleState : State
        {
            public override void OnEnter(StateMachine stateMachine)
            {
                Debug.Log("Entering Idle State");

            }

            public override void OnUpdate(StateMachine stateMachine)
            {

            }

            public override void OnFixedUpdate(StateMachine stateMachine)
            {

            }

            public override void OnExit(StateMachine stateMachine)
            {
                Debug.Log("Exiting Idle State");

            }

            public abstract override bool IsConditionMet(StateMachine stateMachine);
        }


    }

}
