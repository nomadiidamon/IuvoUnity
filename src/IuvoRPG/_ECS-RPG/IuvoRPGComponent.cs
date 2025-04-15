using IuvoUnity.IuvoECS.IuvoComponents;
using System.Runtime.InteropServices;

namespace IuvoUnity
{

    namespace IuvoRPG
    {
        namespace IuvoECS
        {
            public abstract class RPGComponent : IuvoComponent
            {

            }

            public class LevelValueComponent : RPGComponent
            {
                public int _levelValue;
            }
            public class ValueMultiplier : RPGComponent
            {
                public float _valueMultiplier;
            }
            public class ExperienceValueComponent : RPGComponent
            {
                public int _experience;
            }
            public class ExperienceGaugeComponent : RPGComponent
            {
                public ExperienceValueComponent exp;
                public IuvoMinMax_INT_Component minMax;
            }
            public class ExperienceLevelMultiplier : ValueMultiplier
            {

            }
            public class ExperienceGiftComponent : RPGComponent
            {
                public ExperienceValueComponent experience;
            }
            public abstract class StatComponent : LevelValueComponent
            {
                NameComponent _name;
                DescriptionComponent _description;
                IuvoMinMax_INT_Component softCap;
                IuvoMinMax_INT_Component hardCap;
            }
            public class RechargeRateComponent : RPGComponent
            {
                public float _rechargeRate;
                public bool _isRecharging;
            }
            public class RechargeMaxPercentage : ValueMultiplier
            {
            }
            public class RechargeMaxValue : RPGComponent
            {
                public int _rechargeMaxValue;
            }
            public class StunComponent : RPGComponent
            {
                public float _stunRate;
                public bool _isStunned;
            }
            public class Stamina : StatComponent
            {
                public int _currentStamina;
                IuvoMinMax_INT_Component minMaxStamina;
                RechargeRateComponent _rechargeRate;
                StunComponent _stunComponent;
            }
            public class StaminaCost
            {
                public float _cost;
            }
            public class Health : StatComponent
            {
                public int _currentHealth;
                public IuvoMinMax_INT_Component minMaxHealth;
                RechargeRateComponent _rechargeRate;
                RechargeMaxPercentage _maxRecharge;
                RechargeMaxValue _maxRechargeValue;
            }

            public class DamageTypeComponent : RPGComponent
            {
                public enum DamageType
                {
                    PHYSICAL_PIERCING, PHYSICAL_SLASHING, PHYSICAL_BLUNT,
                    MAGIC_FIRE, MAGIC_LAVA, MAGIC_METAL, MAGIC_EARTH, MAGIC_WATER,
                    MAGIC_ICE, MAGIC_AIR, MAGIC_ELECTRICITY, MAGIC_GRAVITY, NULL
                }
                public DamageType _damageType;
            }
            public class DamageValueComponent : RPGComponent
            {
                public DamageTypeComponent _damageType;
                public int _damageValue;
            }
            public class DamageMultiplierComponent : ValueMultiplier
            {

            }
            public class ItemComponent : RPGComponent
            {
                public Name_DescriptionComponent _nameAndDescription;
                public CurrencyComponent _currency;
                public ItemTypeComponent _itemType;
            }

            public class ItemTypeComponent : RPGComponent
            {
                public enum ItemType { BASIC_ITEM, KEY_ITEM, MATERIAL_ITEM, EQUIPMENT_ITEM, CONSUMABLE_ITEM }
               ItemType _Type;
            }

            public class CurrencyComponent : RPGComponent
            {
                public DescriptionComponent _bonusFromSpeech;
                public CurrencyValueComponent _currencyValue;
                public CurrencyMultiplierComponent _currencyMultiplier;
            }

            public class CurrencyValueComponent : RPGComponent
            {
                public int _value;
            }

            public class CurrencyMultiplierComponent : ValueMultiplier
            {

            }

            public class WeightValueComponent : RPGComponent
            {
                public int _weight;
            }

            public class DensityValueComponent : RPGComponent
            {
                public float _density;
            }

            public class DurabilityComponent : RPGComponent
            {
                public float _currentDurability;
                public IuvoMinMax_INT_Component _minMax;
            }

            public class StatBonusComoponent : RPGComponent
            {
                public int _bonus;
            }

            public class StatBonusMultiplierComponent : ValueMultiplier
            {

            }

            public class AccuracyComponent : RPGComponent
            {
                public int _accuracy;
            }

            public class EquipmentTagComponent : ItemComponent
            {
                public bool _isAWeapon;
            }

            public class WeaponTagComponenet : EquipmentTagComponent
            {
                public bool _isTwoHanded;
            }

            public class ArmorSlotComponent : EquipmentTagComponent
            {
                public enum ArmorSlot { HEAD, CHEST, ARMS, LEGS }
                ArmorSlot _armorSlot;
            }
        }
    }
}