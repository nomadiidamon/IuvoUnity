using System;
using IuvoUnity.IuvoStateMachine;

public interface IStateMachineCondition 
{
	bool IsConditionMet(StateMachine stateMachine);
	
}
