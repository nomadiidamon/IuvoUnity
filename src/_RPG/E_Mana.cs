using IuvoUnity._BaseClasses._RPG;
using IuvoUnity._DataStructs;

namespace IuvoUnity
{
    namespace _RPG
    {
        public class Mana : StatBase
        {
            public ClampedValue<int> _Mana;
            public RechargeRateComponent _rechargeRate;
            public StunComponent _stunComponent;
        }
        public class ManaCost
        {
            public float _cost;
        }
    }
}