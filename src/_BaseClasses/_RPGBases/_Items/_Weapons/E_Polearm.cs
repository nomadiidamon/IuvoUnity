using IuvoUnity._DataStructs;
using IuvoUnity._RPG._Item.Weapons;
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
                    namespace _Polearms
                    {

                        public enum PolearmHandle
                        {
                            WOOD,
                            INDENTED,
                            STUDDED,
                            WRAPPED,
                            HYBRID
                        }
                        public class PolearmHandlePart : HandlePart<PolearmHandle>
                        {
                            public PolearmHandlePart(PolearmHandle handleType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(handleType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmPommel
                        {
                            ROUNDED,
                            MAGIC,
                            SPIKED,
                            FLAT
                        }
                        public class PolearmPommelPart : PommelPart<PolearmPommel>
                        {
                            public PolearmPommelPart(PolearmPommel pommelType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(pommelType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmGuard
                        {
                            SIMPLE,
                            ORNATE,
                            SPIKED,
                            ROUNDED
                        }

                        public class PolearmGuardPart : GuardPart<PolearmGuard>
                        {
                            public PolearmGuardPart(PolearmGuard guardType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(guardType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmBlade
                        {
                            SINGLE_EDGE,
                            DOUBLE_EDGE,
                            CURVED,
                            WIDE,
                            THIN
                        }

                        public class PolearmBladePart : BladePart<PolearmBlade>
                        {
                            public PolearmBladePart(PolearmBlade bladeType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(bladeType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmHead
                        {
                            HAMMER,
                            AXE,
                            SPIKE,
                            MACE,
                            FLANGED
                        }

                        public class PolearmHeadPart : HeadPart<PolearmHead>
                        {
                            public PolearmHeadPart(PolearmHead headType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(headType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmCounterWeight
                        {
                            NONE,
                            SMALL,
                            MEDIUM,
                            LARGE
                        }

                        public class PolearmCounterWeightPart : CounterWeightPart<PolearmCounterWeight>
                        {
                            public PolearmCounterWeightPart(PolearmCounterWeight counterWeightType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(counterWeightType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmConnector
                        {
                            SIMPLE,
                            RING,
                            CLAMP,
                            SCREW
                        }

                        public class PolearmConnectorPart : ConnectorPart<PolearmConnector>
                        {
                            public PolearmConnectorPart(PolearmConnector connectorType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(connectorType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmSpacer
                        {
                            NONE,
                            SMALL,
                            MEDIUM,
                            LARGE
                        }

                        public class PolearmSpacerPart : SpacerPart<PolearmSpacer>
                        {
                            public PolearmSpacerPart(PolearmSpacer spacerType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(spacerType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum PolearmSheathe
                        {
                            LEATHER,
                            METAL,
                            WOODEN,
                            FABRIC
                        }

                        public class PolearmSheathePart : SheathePart<PolearmSheathe>
                        {
                            public PolearmSheathePart(PolearmSheathe sheatheType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(sheatheType, partName, partShape, relativeTransformToWeapon) { }
                        }



                    }
                }
            }
        }
    }
}