using IuvoUnity.IuvoStateMachine;

namespace IuvoUnity
{
	namespace IuvoStateMachine
	{
		public interface IStateMachineCondition
		{
			bool IsConditionMet(GenericStateMachine stateMachine);

		}
	}
}