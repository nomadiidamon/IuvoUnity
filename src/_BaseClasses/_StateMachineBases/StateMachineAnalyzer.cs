using UnityEngine;

namespace IuvoUnity
{
    namespace IuvoStateMachine
    {
        public class StateMachineAnalyzer : MonoBehaviour
        {
            public static StateMachineAnalyzer Instance;
            [SerializeField] HumanoidStateMachine toWatch;
            [SerializeField] Transform target;

            void Awake()
            {
                if (Instance == null)
                {
                    Instance = this;
                }
            }

            void Update()
            {
                if (target != null && toWatch != null)
                {
                    toWatch.AssignTargetDestination(target.position);
                }
            }
        }
    }
}