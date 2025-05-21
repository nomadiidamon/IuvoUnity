using IuvoUnity._Input._Controllers;
using IuvoUnity._StateMachine;


namespace IuvoUnity.src._Input._Controllers
{
    public class GravityBodyHumanoid : BaseGravityBodyController
    {
        protected HumanoidStateMachine humanoidStateMachine => stateMachine as HumanoidStateMachine;


        protected override void SetupStateMachine()
        {
            // Try to get the HumanoidStateMachine instead of Generic
            stateMachine = GetComponent<HumanoidStateMachine>();

            if (stateMachine != null && stateMachine.defaultState != null)
                stateMachine.Start();
        }

        protected override void SetupInputs()
        {
            base.SetupInputs();

        }

        protected override void Awake()
        {
            base.Awake();
        }

        protected override void Update()
        {
            if (!IsEnabled || !IsActive)
                return;

            base.Update();

            if (stateMachine != null)
                stateMachine.Update();
        }

        protected override void FixedUpdate()
        {
            if (!IsEnabled || !IsActive)
                return;

            base.FixedUpdate();

            if (stateMachine != null)
                stateMachine.FixedUpdate();
        }


        // Derived classes implement this
        // No default movement
        protected override void HandleMoveInput()
        {
        }
    }
}
