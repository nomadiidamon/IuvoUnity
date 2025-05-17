using UnityEngine.VFX;

namespace IuvoUnity
{
    namespace _Extensions
    {
        /// <summary>
        /// Extension methods for <see cref="VisualEffect"/> to simplify common operations.
        /// </summary>
        public static class VisualEffectExtensions
        {
            /// <summary>
            /// Enables or disables the specified <see cref="VisualEffect"/>.
            /// </summary>
            /// <param name="visualEffect">The VisualEffect component to modify.</param>
            /// <param name="enabled">True to enable the VisualEffect; false to disable it.</param>
            public static void SetVisualEffectEnabled(this VisualEffect visualEffect, bool enabled)
            {
                visualEffect.enabled = enabled;
            }
        }
    }
}
