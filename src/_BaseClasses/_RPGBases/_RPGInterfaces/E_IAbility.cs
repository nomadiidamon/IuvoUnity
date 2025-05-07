using System.Collections.Generic;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        public interface IAbility
        {
            string AbilityName { get; }
            List<IStateACondition> Conditions { get; }

            void Activate();
            void Deactivate();
            bool CanActivate();
        }

    }
}