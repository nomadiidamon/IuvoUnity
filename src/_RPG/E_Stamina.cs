
using IuvoUnity._BaseClasses._RPG;
using IuvoUnity._DataStructs;

namespace IuvoUnity
{
    namespace _RPG
    {
        public class Stamina : StatBase
        {
            public ClampedValue<int> _Stamina;
            public RechargeRateComponent _rechargeRate;
            public StunComponent _stunComponent;
        }
        public class StaminaCost
        {
            public float _cost;
        }
        public class StunComponent : RPGComponentBase
        {
            public float _stunRate;
            public bool _isStunned;
        }
    }
}
