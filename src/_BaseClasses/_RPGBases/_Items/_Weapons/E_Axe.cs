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
                    namespace _Axes
                    {
                        public enum AxeHandle
                        {
                            SHAFT,
                            SCALED_HANDLE,
                            INTEGRATED_HANDLE
                        }
                        public class AxeHandlePart : HandlePart<AxeHandle>
                        {
                            public AxeHandlePart(AxeHandle handleType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(handleType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxePommel
                        {
                            SPIKED,
                            FLAT,
                            HOOKED
                        }
                        public class AxePommelPart : PommelPart<AxePommel>
                        {
                            public AxePommelPart(AxePommel pommelType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(pommelType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeGuard
                        {
                            CROSSGUARD,
                            BASKET,
                            NONE
                        }
                        public class AxeGuardPart : GuardPart<AxeGuard>
                        {
                            public AxeGuardPart(AxeGuard guardType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(guardType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeBlade
                        {
                            SINGLE_EDGE,
                            DOUBLE_EDGE,
                            BEVELED,
                            CURVED
                        }
                        public class AxeBladePart : BladePart<AxeBlade>
                        {
                            public AxeBladePart(AxeBlade bladeType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(bladeType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeHead
                        {
                            WEDGE,
                            HAMMER,
                            PICK
                        }
                        public class AxeHeadPart : HeadPart<AxeHead>
                        {
                            public AxeHeadPart(AxeHead headType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(headType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeCounterWeight
                        {
                            ROUND,
                            FLAT,
                            SPIKED
                        }
                        public class AxeCounterWeightPart : CounterWeightPart<AxeCounterWeight>
                        {
                            public AxeCounterWeightPart(AxeCounterWeight counterWeightType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(counterWeightType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeConnector
                        {
                            RIVET,
                            WELD,
                            PIN
                        }
                        public class AxeConnectorPart : ConnectorPart<AxeConnector>
                        {
                            public AxeConnectorPart(AxeConnector connectorType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(connectorType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeSpacer
                        {
                            THIN,
                            THICK,
                            DECORATIVE
                        }
                        public class AxeSpacerPart : SpacerPart<AxeSpacer>
                        {
                            public AxeSpacerPart(AxeSpacer spacerType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(spacerType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum AxeSheathe
                        {
                            LEATHER,
                            METAL,
                            WOOD
                        }
                        public class AxeSheathePart : SheathePart<AxeSheathe>
                        {
                            public AxeSheathePart(AxeSheathe sheatheType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(sheatheType, partName, partShape, relativeTransformToWeapon) { }
                        }
                    }

                }
            }
        }
    }
}