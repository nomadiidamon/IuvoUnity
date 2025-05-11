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

        public class DamageTypeComponent : RPGComponentBase
        {
            public enum DamageType
            {
                PHYSICAL_PIERCING, PHYSICAL_SLASHING, PHYSICAL_BLUNT,
                MAGIC_FIRE, MAGIC_LAVA, MAGIC_METAL, MAGIC_EARTH, MAGIC_WATER,
                MAGIC_ICE, MAGIC_AIR, MAGIC_ELECTRICITY, MAGIC_GRAVITY, NULL
            }
            public DamageType _damageType;
        }
        public class DamageValueComponent : RPGComponentBase
        {
            public DamageTypeComponent _damageType;
            public int _damageValue;
        }
        public class DamageMultiplierComponent : ValueMultiplier
        {

        }
    }
}