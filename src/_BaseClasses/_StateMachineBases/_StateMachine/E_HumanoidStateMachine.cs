using UnityEngine;

namespace IuvoUnity
{
    namespace _StateMachine
    {
        [System.Serializable]
        public class HumanoidStateMachine : GenericStateMachine
        {
            [Header("States")]
            public GenericIdleState idle;
            public GenericMoveState move;

            public new void Start()
            {
                if (idle != null)
                {
                    states.Add(idle);
                }
                if (move != null)
                {
                    states.Add(move);
                }
                base.Start();

            }

            public new void Update()
            {
                if (currentState != null)
                {
                    currentState.OnUpdate(this);
                }
            }

            public void AssignTargetDestination(Vector3 newDestination)
            {
                if (move != null && move.targetPosition != newDestination)
                {
                    move.targetPosition = newDestination;
                    TryChangeState(move);
                }
            }
        }
    }
}