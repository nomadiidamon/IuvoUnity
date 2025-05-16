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
                    namespace _Swords
                    {

                        public enum SwordHandle
                        {
                            HILT,
                            WRAPPED_HILT,
                            CLOSED_GRIP,
                            SCALED_HANDLE,
                            INTEGRATED_HANDLE
                        }
                        public class SwordHandlePart : HandlePart<SwordHandle>
                        {
                            public SwordHandlePart(SwordHandle handleType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(handleType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum SwordPommel
                        {
                            ROUNDED, DIAMOND, SKULL_KRUSHER
                        }
                        public class SwordPommelPart : PommelPart<SwordPommel>
                        {
                            public SwordPommelPart(SwordPommel pommelType, DataName partName, Mesh partShape, TransformData relativeTransformToWeapon)
                                : base(pommelType, partName, partShape, relativeTransformToWeapon) { }
                        }

                        public enum SwordGuard
                        {
                            CROSS,          // Classic crossguard
                            BASKET,         // Basket style guard (woven metal cage)
                            WINGED,         // Extended wings, often curved
                            RING,           // Circular ring guards on sides
                            SHELL,          // Shell-shaped guards
                            HALF_BASKET,    // Partial cage guard
                            SIMPLE_BAR      // Minimalist bar guard
                        }

                        public enum SwordBlade
                        {
                            STRAIGHT,           // Traditional straight blade
                            CURVED,             // Curved blade like a scimitar or sabre
                            TAPERED,            // Widens near the guard and tapers to point
                            DOUBLE_EDGED,       // Sharp edges on both sides
                            SINGLE_EDGED,       // One sharp edge only
                            FOLDED,             // Pattern-welded or folded steel
                            SERRATED,           // Sharp bittin into edge for shredding
                            BROAD,              // Wide blade for slashing
                            RAPIER,             // Thin, thrusting blade
                            TRI_SIDE_RAPIER,    // Rapier great at deep wounds 
                            KATANA              // Japanese style curved blade
                        }

                        public enum SwordCounterWeight
                        {
                            NONE,           // No counterweight
                            ROUNDED,        // Rounded weight
                            FLANGED,        // Weight with flanges or fins
                            SPIKED,         // Spiky counterweight
                            BLOCK,          // Block shaped weight
                            CUSTOM          // Custom or ornamental shapes
                        }

                        public enum SwordConnector
                        {
                            SIMPLE,         // Simple ring or collar
                            REINFORCED,     // Reinforced collar or ferrule
                            DECORATED,      // Decorated with engravings or patterns
                            SPIKED,         // Connector with spikes or projections
                            NONE            // No separate connector piece
                        }

                        public enum SwordSpacer
                        {
                            METAL_WASHER,
                            LEATHER_RING,
                            WOODEN_RING,
                            DECORATIVE_RING,
                            NONE
                        }

                        public enum SwordSheathe
                        {
                            LEATHER,            // Leather sheath
                            WOODEN,             // Wooden sheath
                            METAL,              // Metal sheath
                            DECORATED_LEATHER,  // Decorated leather sheath
                            ORNAMENTED_METAL    // Ornamental metal sheath
                        }
                    }

                }
            }
        }
    }
}