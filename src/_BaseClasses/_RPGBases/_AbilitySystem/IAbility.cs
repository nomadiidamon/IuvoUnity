using IuvoUnity._Interfaces._UtilityInterfaces;
using System.Collections.Generic;


namespace IuvoUnity
{
    namespace _Interfaces
    {
        namespace _UtilityInterfaces
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
}