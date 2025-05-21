using IuvoUnity._Interfaces;
using System.Collections.Generic;


namespace IuvoUnity.src._Constants
{

    public class IuvoGame
    {
        public List<IBooleanCondition> gameConditions = new List<IBooleanCondition>();

        public bool IsGameFinished => AreAllGameConditionsMet();
        public bool AreAllGameConditionsMet()
        {
            foreach (var cond in gameConditions)
            {
                if (!CheckCondition(cond))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckCondition(IBooleanCondition condition)
        {
            return condition.Evaluate();
        }
    }
}
