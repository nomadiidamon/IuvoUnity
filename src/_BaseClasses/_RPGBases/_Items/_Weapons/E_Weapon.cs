using IuvoUnity._BaseClasses;
using IuvoUnity._BaseClasses._ECS;
using IuvoUnity._BaseClasses._RPG;
using IuvoUnity._DataStructs;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace IuvoUnity
{
    namespace _RPG
    {
        namespace _Item
        {
            namespace Weapons
            {
                public class Weapon<TSubType> : EquipmentComponent where TSubType : Enum
                {
                    public WeaponBase<TSubType> _base;
                    public void SetWeaponBase(WeaponBase<TSubType> weapon)
                    {
                        _base = weapon;
                    }
                }

                #region WeaponConfiguration
                public class WeaponConfiguration : IuvoConfigurationBase { }
                public class WeaponBase<TSubType> : RPGComponentBase where TSubType : Enum
                {
                    public WeaponCategory<TSubType> _Category { get; }
                    public WeaponActivityType _Type { get; }

                    public HandType _HandType { get; set; }
                    public WeaponEffects _Effects { get; set; }

                    public WeaponBase(WeaponCategory<TSubType> category, WeaponActivityType type, HandType handType, WeaponEffects weaponEffects)
                    {
                        _Category = category;
                        _Type = type;
                        _HandType = handType;
                        _Effects = weaponEffects;
                    }

                }



                public class WeaponCategory<TSubType> where TSubType : Enum
                {
                    public WeaponMainType _mainType { get; }
                    public TSubType _subType { get; }

                    public WeaponCategory(TSubType subType)
                    {
                        _mainType = GetMainTypeForSubType(typeof(TSubType));
                        _subType = IsValidSubType(_mainType, subType)
                            ? subType
                            : (TSubType)GetDefaultSubType(_mainType);
                    }

                    private static readonly Dictionary<Type, WeaponMainType> subTypeToMainMap = new Dictionary<Type, WeaponMainType>()
                    {
                        { typeof(SwordType), WeaponMainType.SWORD },
                        { typeof(AxeType), WeaponMainType.AXE },
                        { typeof(HammerType), WeaponMainType.HAMMER },
                        { typeof(PoleArmType), WeaponMainType.POLEARM },
                        { typeof(RangedType), WeaponMainType.RANGED },
                        { typeof(ThrowableType), WeaponMainType.THROWABLE }
                    };

                    public static WeaponMainType GetMainTypeForSubType(Type enumType)
                    {
                        if (subTypeToMainMap.TryGetValue(enumType, out var mainType))
                        {
                            return mainType;
                        }
                        throw new ArgumentException($"Unknown weapon subtype enum: {enumType.Name}");
                    }

                    public static bool IsValidSubType<TSubType>(WeaponMainType mainType, TSubType subType) where TSubType : Enum
                    {
                        //return GetMainTypeForSubType(typeof(TSubType)) == mainType;
                        return subTypeToMainMap.TryGetValue(subType.GetType(), out var foundMainType) && foundMainType == mainType;

                    }

                    public static Enum GetDefaultSubType(WeaponMainType mainType)
                    {
                        return mainType switch
                        {
                            WeaponMainType.SWORD => SwordType.SHORT_SWORD,
                            WeaponMainType.AXE => AxeType.HATCHET,
                            WeaponMainType.HAMMER => HammerType.CLUB,
                            WeaponMainType.POLEARM => PoleArmType.SPEAR,
                            WeaponMainType.RANGED => RangedType.ARROW,
                            WeaponMainType.THROWABLE => ThrowableType.ROCK,
                            WeaponMainType.HYBRID => HybridType.OTHER, // Optional
                            _ => throw new ArgumentOutOfRangeException(nameof(mainType), $"No default for {mainType}")
                        };
                    }

                    public override string ToString()
                    {
                        return $"{_mainType} : {_subType}";
                    }

                }
                #endregion

                #region BasicWeaponEnums
                public enum WeaponMainType
                {
                    SWORD,
                    AXE,
                    HAMMER,
                    POLEARM,
                    RANGED,
                    THROWABLE,
                    HYBRID
                }
                public enum WeaponActivityType
                {

                    PIERCING,            // arrows, spears, throwing knives
                    SLASHING,            // swords, daggers
                    RENDING,             // Tearing weapons (e.g., serrated)
                    CLEAVING,            // Wide area heavy blows (e.g., axes)
                    CHOPPING,            // More force-focused than slashing
                    BLUNT,               // Maces, hammers, bullets, sling

                    RANGED,              // Bows, crossbows
                    THROWN,              // Knives, axes, spears

                    MAGIC,               // Spellcasting focus
                    HYBRID,              // Multi-type weapons
                    OTHER
                }
                public enum HandType
                {
                    ONE_HANDED,
                    DUAL_WIELDED,
                    TWO_HANDED,
                    NO_HANDS
                }
                public enum WeaponButt
                {
                    NONE,
                    POMMEL,            // Classic sword/knife pommel
                    SKULL_KRUSHER,     // Heavy, blunt end
                    SPIKE,             // Can be used for piercing back attacks

                    COUNTERWEIGHT,     // For balance (often decorative)
                    CAP,               // Flat or metal end cap
                    HOOKED,            // Hooked end for tripping or grappling
                    OTHER
                }

                public enum SwordType
                {
                    DAGGER,
                    THROWING_KNIFE,
                    SHORT_SWORD,
                    LONG_SWORD,
                    KATANA,
                    SCIMITAR,
                    RAPIER,
                    GREAT_SWORD
                }
                public enum AxeType
                {
                    HATCHET,
                    BATTLE_AXE,
                    GREAT_AXE,
                    THROWING_AXE
                }
                public enum HammerType
                {
                    CLUB,
                    MACE,
                    MORNINGSTAR,
                    MALLET,
                    HAMMER,
                    GREAT_HAMMER

                }
                public enum PoleArmType
                {
                    MAGIC_STAFF,
                    QUARTER_STAFF,
                    SPEAR,
                    HALBERD,
                    TRIDENT
                }
                public enum RangedType
                {
                    MAGIC,
                    BULLET,
                    ARROW
                }
                public enum ThrowableType
                {
                    ROCK,
                    KNIFE,
                    OTHER
                }
                public enum HybridType
                {
                    OTHER
                }
                [System.Flags]
                public enum WeaponEffects
                {
                    NONE = 0,

                    BLEED = 1 << 0,
                    SAVAGE_BLEED = 1 << 1,

                    FREEZE = 1 << 2,
                    VICIOUS_FROST = 1 << 3,

                    BURN = 1 << 4,
                    HELLS_TOUCH = 1 << 5,

                    SHOCKED = 1 << 6,
                    ELECTROCUTED = 1 << 7,

                    WET = 1 << 8,
                    DRENCHED = 1 << 9,

                    POISONED = 1 << 10,
                    CONTAGIOUS = 1 << 11,

                    TIRED = 1 << 12,
                    ASLEEP = 1 << 13,

                    INTIMIDATED = 1 << 14,
                    FRIGHTENED = 1 << 15,

                    LEECHING = 1 << 16
                }
                #endregion

                #region Weapon Parts
                public interface IWeaponPart : IDataStructBase
                {
                    public DataName partName { get; set; }
                    public Mesh partShape { get; set; }
                    public TransformData relativeTransformToWeapon { get; set; }
                }
                public abstract class WeaponPart<TPartType> : IWeaponPart where TPartType : Enum
                {

                    public TPartType PartType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public virtual DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public virtual Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public virtual TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    protected WeaponPart(TPartType partType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                    {
                        PartType = partType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public enum WeaponPartTypes
                {
                    POMMEL = 1,
                    HANDLE,
                    GUARD,
                    BLADE,
                    HEAD,
                    COUNTER_WEIGHT,
                    CONNECTOR,
                    SPACER,
                    SHEATHE
                }

                public abstract class PommelPart<TPommelType> : WeaponPart<TPommelType> where TPommelType : Enum
                {
                    public TPommelType PommelType { get; private set; }

                    // Backing fields for IWeaponPart
                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    // Implement IWeaponPart members
                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public PommelPart(TPommelType pommelType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                        : base(pommelType, partName, partShape, relativeTransformToWeapon)
                    {
                        PommelType = pommelType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class HandlePart<THandleType> : WeaponPart<THandleType> where THandleType : Enum
                {
                    public THandleType HandleType { get; private set; }

                    // Backing fields for interface properties
                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    // Implement IWeaponPart members
                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public HandlePart(THandleType handleType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                        : base(handleType, partName, partShape, relativeTransformToWeapon)

                    {
                        HandleType = handleType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class GuardPart<TGuardType> : WeaponPart<TGuardType> where TGuardType : Enum
                {
                    public TGuardType GuardType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public GuardPart(TGuardType guardType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                         : base(guardType, partName, partShape, relativeTransformToWeapon)
                    {
                        GuardType = guardType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class BladePart<TBladeType> : WeaponPart<TBladeType> where TBladeType : Enum
                {
                    public TBladeType BladeType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public BladePart(TBladeType bladeType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                         : base(bladeType, partName, partShape, relativeTransformToWeapon)
                    {
                        BladeType = bladeType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class HeadPart<THeadType> : WeaponPart<THeadType> where THeadType : Enum
                {
                    public THeadType HeadType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public HeadPart(THeadType headType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                          : base(headType, partName, partShape, relativeTransformToWeapon)
                    {
                        HeadType = headType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class CounterWeightPart<TCounterWeightType> : WeaponPart<TCounterWeightType> where TCounterWeightType : Enum
                {
                    public TCounterWeightType CounterWeightType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public CounterWeightPart(TCounterWeightType counterWeightType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                            : base(counterWeightType, partName, partShape, relativeTransformToWeapon)
                    {
                        CounterWeightType = counterWeightType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class ConnectorPart<TConnectorType> : WeaponPart<TConnectorType> where TConnectorType : Enum
                {
                    public TConnectorType ConnectorType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public ConnectorPart(TConnectorType connectorType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                            : base(connectorType, partName, partShape, relativeTransformToWeapon)
                    {
                        ConnectorType = connectorType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class SpacerPart<TSpacerType> : WeaponPart<TSpacerType> where TSpacerType : Enum
                {
                    public TSpacerType SpacerType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public SpacerPart(TSpacerType spacerType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                          : base(spacerType, partName, partShape, relativeTransformToWeapon)
                    {
                        SpacerType = spacerType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }
                public abstract class SheathePart<TSheatheType> : WeaponPart<TSheatheType> where TSheatheType : Enum
                {
                    public TSheatheType SheatheType { get; private set; }

                    private DataName _partName;
                    private Mesh _partShape;
                    private TransformData _relativeTransformToWeapon;

                    public override DataName partName
                    {
                        get => _partName;
                        set => _partName = value;
                    }

                    public override Mesh partShape
                    {
                        get => _partShape;
                        set => _partShape = value;
                    }

                    public override TransformData relativeTransformToWeapon
                    {
                        get => _relativeTransformToWeapon;
                        set => _relativeTransformToWeapon = value;
                    }

                    public SheathePart(TSheatheType sheatheType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                    : base(sheatheType, partName, partShape, relativeTransformToWeapon)
                    {
                        SheatheType = sheatheType;
                        _partName = partName;
                        _partShape = partShape;
                        _relativeTransformToWeapon = relativeTransformToWeapon;
                    }
                }

                #endregion


            }
        }
    }
}