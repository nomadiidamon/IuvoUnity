using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace IuvoUnity
{
    namespace IuvoStateMachine
    {
        [System.Serializable]
        public class GenericStateMachine : MonoBehaviour
        {
            public GenericState currentState;
            public GenericState defaultState;
            public Animator animator;
            public NavMeshAgent navMeshAgent;
            public string currentAnim;

            [Header("States")]
            public List<GenericState> states = new List<GenericState>();


            public void Start()
            {
                currentState = defaultState;
                ChangeState(defaultState);
            }

            public void Update()
            {
                if (currentState != null)
                {
                    currentState.OnUpdate(this);
                }
            }

            public void TryChangeState(GenericState newState)
            {
                if (newState != null && newState.CanEnter(this))
                {
                    ChangeState(newState);
                }
                else
                {
                    Debug.Log("State Transition Denied Due To Unmet Conditions.");
                }

            }

            public void ChangeState(GenericState newState)
            {
                if (currentState != null && newState != currentState)
                {
                    currentState.OnExit(this);
                    currentState = newState;
                    currentAnim = currentState.animationName;
                    currentState.OnEnter(this);
                }

            }

        }
    }
}
