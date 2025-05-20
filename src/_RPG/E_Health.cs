using IuvoUnity._BaseClasses._RPG;
using IuvoUnity._DataStructs;

namespace IuvoUnity
{
    namespace _RPG
    {
        public class Health : StatBase
        {
            public ClampedValue<int> _Health;
            public RechargeRateComponent _rechargeRate;
            public RechargeMaxPercentage _maxRecharge;
            public RechargeMaxValue _maxRechargeValue;
        }


    }
}