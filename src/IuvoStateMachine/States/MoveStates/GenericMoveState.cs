using System;
using UnityEngine;
using UnityEngine.AI;


namespace IuvoUnity
{
    namespace IuvoStateMachine
    {
        [CreateAssetMenu(fileName = "GenericMoveState", menuName = "StateMachine/States/MoveStates")]
        public class GenericMoveState : GenericState
        {
            public float speed = 5f;
            public Vector3 currentPosition;
            public Vector3 targetPosition;
            NavMeshAgent agent;

            public override void OnEnter(GenericStateMachine stateMachine)
            {
                Debug.Log("Entering Move State");
                currentPosition = stateMachine.transform.position;
                agent = stateMachine.navMeshAgent;
                agent.speed = speed;
                animator = stateMachine.GetComponent<Animator>();
                animator.CrossFade(animationName, crossFadeTime);
                if (targetPosition != null && agent.destination != targetPosition)
                {
                    agent.SetDestination(targetPosition);
                }
                stateMachine.currentAnim = animationName;
                if (!agent.autoRepath)
                {
                    agent.autoRepath = true;
                }
            }

            public override void OnUpdate(GenericStateMachine stateMachine)
            {
                currentPosition = stateMachine.transform.position;
                if (IsConditionMet(stateMachine))
                {
                    stateMachine.TryChangeState(stateMachine.defaultState);
                }
            }

            public override void OnFixedUpdate(GenericStateMachine stateMachine)
            {

            }

            public override void OnExit(GenericStateMachine stateMachine)
            {
                Debug.Log("Exiting Move State");
            }

            public override bool IsConditionMet(GenericStateMachine stateMachine)
            {
                float distance = Vector3.Distance(currentPosition, targetPosition);
                if (distance < 0.5f)
                {
                    return true;
                }
                else
                {
                    agent.SetDestination(targetPosition);
                    agent.CalculatePath(targetPosition, agent.path);
                    return false;
                }
            }

        }
    }
}