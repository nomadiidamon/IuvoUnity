using System.Collections.Generic;


namespace IuvoUnity
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