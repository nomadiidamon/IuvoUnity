using IuvoUnity._BaseClasses._RPG;

namespace IuvoUnity
{
    namespace _RPG
    {
        public class JumpAbility : BaseAbility
        {
            public override string AbilityName => "Jump";

            public override void Activate()
            {
                if (CanActivate())
                {
                    UnityEngine.Debug.Log("Jump activated!");
                }
            }
        }

    }
}