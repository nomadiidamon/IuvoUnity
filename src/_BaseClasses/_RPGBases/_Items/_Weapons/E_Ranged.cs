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
                    namespace _RangedWeapons
                    {

                        public enum RangedGrip
                        {
                            NATURAL_GRIP,
                            WRAPPED_GRIP,
                            PLAIN_GRIP,
                            STUDDED_GRIP,
                            INDENTED_GRIP,
                        }
                        public class RangedGripPart : HandlePart<RangedGrip>
                        {
                            public RangedGripPart(RangedGrip gripType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(gripType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum RangedPommel
                        {
                            WIREFRAME_GUN_STOCK,
                            CAST_IRON_STOCK,
                            STEEL_STOCK
                        }
                        public class RangedPommelPart : PommelPart<RangedPommel>
                        {
                            public RangedPommelPart(RangedPommel pommelType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(pommelType, partName, partShape, relativeTransformToWeapon) { }
                        }


                        public enum ConnectorType
                        {
                            SIMPLE_CONNECTOR,
                            LOCKING_CONNECTOR,
                            FLEXIBLE_CONNECTOR
                        }
                        public class ConnectorPart : ConnectorPart<ConnectorType>
                        {
                            public ConnectorPart(ConnectorType connectorType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(connectorType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum SpacerType
                        {
                            THIN_SPACER,
                            THICK_SPACER,
                            ELASTIC_SPACER
                        }
                        public class SpacerPart : SpacerPart<SpacerType>
                        {
                            public SpacerPart(SpacerType spacerType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(spacerType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum SheatheType
                        {
                            LEATHER_SHEATHE,
                            METAL_SHEATHE,
                            WOODEN_SHEATHE
                        }
                        public class SheathePart : SheathePart<SheatheType>
                        {
                            public SheathePart(SheatheType sheatheType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(sheatheType, partName, partShape, relativeTransformToWeapon) { }
                        }
                    }

                }
            }
        }
    }
}
