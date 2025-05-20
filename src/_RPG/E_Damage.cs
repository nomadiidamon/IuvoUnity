using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            public class DamageTypeComponent : RPGComponentBase
            {
                public enum DamageType
                {
                    PSYCHE_CONFUSION, PYSCHE_PAIN, PSYCHE_SLEEP, PSYCHE_PARALYSIS, PYSCHE_UNCONSCIOUS,

                    PHYSICAL_PIERCING, PHYSICAL_SLASHING, PHYSICAL_BLUNT,

                    MAGIC_FIRE, MAGIC_LAVA, MAGIC_METAL, MAGIC_EARTH, MAGIC_WATER,
                    MAGIC_ICE, MAGIC_AIR, MAGIC_ELECTRICITY, MAGIC_GRAVITY, NULL
                }
                public DamageType _damageType;
            }
            public class DamageValueComponent : RPGComponentBase
            {
                public DamageTypeComponent damageType;
                public int damageValue;

                public DamageValueComponent(int damageAmount, DamageTypeComponent damageType)
                {
                    damageValue = damageAmount;
                    this.damageType = damageType;
                }
            }
            public class DamageMultiplierComponent : ValueMultiplier
            {

            }
        }
    }
}