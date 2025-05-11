using IuvoUnity._BaseClasses._ECS;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            public abstract class RPGComponentBase : IuvoComponentBase
            {

            }






            public class RechargeRateComponent : RPGComponentBase
            {
                public float _rechargeRate;
                public bool _isRecharging;
            }
            public class RechargeMaxPercentage : ValueMultiplier
            {
            }
            public class RechargeMaxValue : RPGComponentBase
            {
                public int _rechargeMaxValue;
            }
            





        }

    }
}