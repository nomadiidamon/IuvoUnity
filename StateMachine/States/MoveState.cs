﻿using System;
using UnityEngine;

namespace IuvoUnity
{
    namespace IuvoStateMachine
    {
        [CreateAssetMenu(fileName = "MoveState", menuName = "StateMachine/States/MoveState")]
        public abstract class MoveState : State
        {
            public float speed = 5f;

            public override void OnEnter(StateMachine stateMachine)
            {
                Debug.Log("Entering Move State");

            }

            public override void OnUpdate(StateMachine stateMachine)
            {

            }

            public override void OnFixedUpdate(StateMachine stateMachine)
            {

            }

            public override void OnExit(StateMachine stateMachine)
            {
                Debug.Log("Exiting Move State");

            }

            public abstract override bool IsConditionMet(StateMachine stateMachine);
        }


    }

}
