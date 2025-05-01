using IuvoUnity._ECS;
using IuvoUnity.IuvoECS.IuvoComponents;
using System.Runtime.InteropServices;

namespace IuvoUnity
{

    namespace _BaseClasses
    {
        namespace _ECS
        {
            namespace _RPG
            {
                public abstract class RPGComponent : IuvoComponentBase
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
                    public NameComponent _name;
                    public DescriptionComponent _description;
                    public IuvoMinMax_INT_Component softCap;
                    public IuvoMinMax_INT_Component hardCap;
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
                    public IuvoMinMax_INT_Component minMaxStamina;
                    public RechargeRateComponent _rechargeRate;
                    public StunComponent _stunComponent;
                }
                public class StaminaCost
                {
                    public float _cost;
                }
                public class Health : StatComponent
                {
                    public int _currentHealth;
                    public IuvoMinMax_INT_Component minMaxHealth;
                    public RechargeRateComponent _rechargeRate;
                    public RechargeMaxPercentage _maxRecharge;
                    public RechargeMaxValue _maxRechargeValue;
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
                    public ItemType _type;
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

                public class StatBonusComponent : RPGComponent
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

                public class RangeComponent : RPGComponent
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
}