using IuvoUnity;
using IuvoUnity._BaseClasses;

namespace IuvoUnity
{
	namespace _StateMachine
	{
		public interface IStateMachineCondition : IuvoInterfaceBase
		{
			bool IsConditionMet(GenericStateMachine stateMachine);

		}
	}
}