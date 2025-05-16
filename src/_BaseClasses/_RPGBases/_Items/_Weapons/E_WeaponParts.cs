using IuvoUnity._DataStructs;
using System;
using UnityEngine;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPGBases
        {
            namespace _Items
            {
                namespace _Weapons
                {
                    namespace _WeaponParts
                    {
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
    }
}