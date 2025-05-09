using IuvoUnity._BaseClasses._ECS;
using IuvoUnity._DataStructs;

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
            public class StunComponent : RPGComponentBase
            {
                public float _stunRate;
                public bool _isStunned;
            }
            public class Stamina : StatBase
            {
                public int _currentStamina;
                public Range<int> minMaxStamina;
                public RechargeRateComponent _rechargeRate;
                public StunComponent _stunComponent;
            }
            public class StaminaCost
            {
                public float _cost;
            }
            public class Health : StatBase
            {
                public int _currentHealth;
                public Range<int> minMaxHealth;
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
            public class ItemComponent : RPGComponentBase
            {
                public Name _name;
                public Description _description;
                public CurrencyComponent _currency;
                public ItemTypeComponent _itemType;
            }

            public class ItemTypeComponent : RPGComponentBase
            {
                public enum ItemType { BASIC_ITEM, KEY_ITEM, MATERIAL_ITEM, EQUIPMENT_ITEM, CONSUMABLE_ITEM }
                public ItemType _type;
            }

            public class CurrencyComponent : RPGComponentBase
            {
                public Description _bonusFromSpeech;
                public CurrencyValueComponent _currencyValue;
                public CurrencyMultiplierComponent _currencyMultiplier;
            }

            public class CurrencyValueComponent : RPGComponentBase
            {
                public int _value;
            }

            public class CurrencyMultiplierComponent : ValueMultiplier
            {

            }

            public class WeightValueComponent : RPGComponentBase
            {
                public int _weight;
            }

            public class DensityValueComponent : RPGComponentBase
            {
                public float _density;
            }

            public class DurabilityComponent : RPGComponentBase
            {
                public float _currentDurability;
                public Range<int> _minMax;
            }

            public class StatBonusComponent : RPGComponentBase
            {
                public int _bonus;
            }

            public class StatBonusMultiplierComponent : ValueMultiplier
            {

            }

            public class AccuracyComponent : RPGComponentBase
            {
                public int _accuracy;
            }

            public class RangeComponent : RPGComponentBase
            {
                public int _range;
            }

            public class EquipmentTagComponent : ItemComponent
            {
            }

            public class CanBeTwoHandedComponent : EquipmentTagComponent
            {
                public bool _isTwoHandable;
            }

            public class WeaponSlotComponent : CanBeTwoHandedComponent
            {
                public bool _isTwoHandedWeapon;
            }
#nullable enable
            public class LeftHandComponent : WeaponSlotComponent
            {
                CanBeTwoHandedComponent? _leftHand;
            }

            public class RightHandComponent : WeaponSlotComponent
            {
                CanBeTwoHandedComponent? _rightHand;
            }

#nullable disable
            public class ShieldSlotComponent : CanBeTwoHandedComponent
            {
                public bool _canTwoHandSheild;
            }

            public class ArmorSlotComponent : EquipmentTagComponent
            {
                public enum ArmorSlot { HEAD, CHEST, ARMS, LEGS }
                public ArmorSlot _armorSlot;
            }

            public class AccessorySlotComponent : EquipmentTagComponent
            {
                public enum AccessorySlot
                {
                    VEIL, CROWN, CAPE, NECKLACE, LEFT_EARRING, RIGHT_EARRING,
                    COLLAR, LEFT_WRIST, RIGHT_WRIST, LEFT_RING, RIGHT_RING
                }

                public AccessorySlot _accessorySlot;
            }


        }

    }
}