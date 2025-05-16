using IuvoUnity._DataStructs;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {

            public class ItemComponent : RPGComponentBase
            {
                public DataName Name;
                public DataDescription Description;
                public CurrencyComponent Currency;
                public ItemTypeComponent ItemType;
            }

            public class ItemTypeComponent : RPGComponentBase
            {
                public enum ItemType { BASIC_ITEM, KEY_ITEM, MATERIAL_ITEM, EQUIPMENT_ITEM, CONSUMABLE_ITEM }
                public ItemType _type;
            }

            public class CurrencyComponent : RPGComponentBase
            {
                public DataDescription _bonusFromSpeech;
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

            public class StackableComponent : RPGComponentBase
            {
                public ClampedValue<int> _stack;
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

            public class EquipmentComponent : ItemComponent
            {
            }

            public class ArmorSlotComponent : EquipmentComponent
            {
                public enum ArmorSlot { HEAD, CHEST, ARMS, LEGS }
                public ArmorSlot _armorSlot;
            }

            public class AccessorySlotComponent : EquipmentComponent
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