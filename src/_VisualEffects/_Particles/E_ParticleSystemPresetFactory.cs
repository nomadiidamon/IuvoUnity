using UnityEngine;

namespace IuvoUnity
{
    namespace _VisualEffects
    {
        namespace _Particles
        {
            /// <summary>
            /// Factory class for generating common particle system presets using the <see cref="ParticleSystemBuilder"/>.
            /// </summary>
            public static class ParticleSystemPresetFactory
            {
                /// <summary>
                /// Creates a basic looping smoke particle effect.
                /// </summary>
                /// <returns>A <see cref="ParticleSystemBuilder"/> configured for a smoke effect.</returns>
                public static ParticleSystemBuilder BasicSmoke()
                {
                    return new ParticleSystemBuilder("Smoke")
                        .WithStartColor(Color.gray)
                        .WithStartSize(1f)
                        .WithStartLifetime(2f)
                        .WithStartSpeed(0.5f)
                        .WithLooping(true)
                        .WithEmissionRate(10f)
                        .WithColorOverLifetime(new Gradient
                        {
                            colorKeys = new[]
                            {
                                new GradientColorKey(Color.gray, 0),
                                new GradientColorKey(Color.clear, 1)
                            },
                            alphaKeys = new[]
                            {
                                new GradientAlphaKey(1f, 0),
                                new GradientAlphaKey(0f, 1)
                            }
                        });
                }

                /// <summary>
                /// Creates a looping fire particle effect with a warm gradient.
                /// </summary>
                /// <returns>A <see cref="ParticleSystemBuilder"/> configured for a fire effect.</returns>
                public static ParticleSystemBuilder Fire()
                {
                    return new ParticleSystemBuilder("Fire")
                        .WithStartColor(new Color(1f, 0.5f, 0f)) // orange
                        .WithStartSize(1f)
                        .WithStartLifetime(1.2f)
                        .WithStartSpeed(0.5f)
                        .WithEmissionRate(30f)
                        .WithLooping(true)
                        .WithShape(ParticleSystemShapeType.Cone)
                        .WithNoise(0.3f)
                        .WithColorOverLifetime(new Gradient
                        {
                            colorKeys = new[]
                            {
                                new GradientColorKey(new Color(1f, 0.4f, 0f), 0f),
                                new GradientColorKey(Color.red, 0.5f),
                                new GradientColorKey(Color.black, 1f)
                            },
                            alphaKeys = new[]
                            {
                                new GradientAlphaKey(1f, 0f),
                                new GradientAlphaKey(0.1f, 1f)
                            }
                        });
                }

                /// <summary>
                /// Creates a short-lived spark particle effect with a burst-like appearance.
                /// </summary>
                /// <returns>A <see cref="ParticleSystemBuilder"/> configured for a sparks effect.</returns>
                public static ParticleSystemBuilder Sparks()
                {
                    return new ParticleSystemBuilder("Sparks")
                        .WithStartColor(Color.yellow)
                        .WithStartSize(0.2f)
                        .WithStartLifetime(0.5f)
                        .WithStartSpeed(4f)
                        .WithEmissionRate(100f)
                        .WithLooping(false)
                        .WithShape(ParticleSystemShapeType.Sphere)
                        .WithTrails(1f)
                        .WithVelocityOverLifetime(new Vector3(0, -2, 0))
                        .WithColorOverLifetime(new Gradient
                        {
                            colorKeys = new[]
                            {
                                new GradientColorKey(Color.yellow, 0f),
                                new GradientColorKey(Color.red, 1f)
                            },
                            alphaKeys = new[]
                            {
                                new GradientAlphaKey(1f, 0f),
                                new GradientAlphaKey(0f, 1f)
                            }
                        });
                }

                /// <summary>
                /// Creates a one-shot explosion effect with a color fade and noise.
                /// </summary>
                /// <returns>A <see cref="ParticleSystemBuilder"/> configured for an explosion effect.</returns>
                public static ParticleSystemBuilder Explosion()
                {
                    return new ParticleSystemBuilder("Explosion")
                        .WithStartColor(Color.yellow)
                        .WithStartSize(1f)
                        .WithStartLifetime(0.8f)
                        .WithStartSpeed(8f)
                        .WithEmissionRate(500f)
                        .WithLooping(false)
                        .WithDuration(1f)
                        .WithShape(ParticleSystemShapeType.Sphere)
                        .WithNoise(0.2f)
                        .WithColorOverLifetime(new Gradient
                        {
                            colorKeys = new[]
                            {
                                new GradientColorKey(Color.yellow, 0f),
                                new GradientColorKey(Color.red, 0.5f),
                                new GradientColorKey(Color.black, 1f)
                            },
                            alphaKeys = new[]
                            {
                                new GradientAlphaKey(1f, 0f),
                                new GradientAlphaKey(0f, 1f)
                            }
                        });
                }

                /// <summary>
                /// Creates a looping magical aura effect using a donut shape and soft noise.
                /// </summary>
                /// <returns>A <see cref="ParticleSystemBuilder"/> configured for a magical aura effect.</returns>
                public static ParticleSystemBuilder MagicAura()
                {
                    return new ParticleSystemBuilder("MagicAura")
                        .WithStartColor(new Color(0.5f, 0f, 1f)) // purple
                        .WithStartSize(0.5f)
                        .WithStartLifetime(2f)
                        .WithStartSpeed(0.2f)
                        .WithEmissionRate(20f)
                        .WithLooping(true)
                        .WithShape(ParticleSystemShapeType.Donut)
                        .WithNoise(0.5f)
                        .WithColorOverLifetime(new Gradient
                        {
                            colorKeys = new[]
                            {
                                new GradientColorKey(Color.magenta, 0f),
                                new GradientColorKey(Color.cyan, 1f)
                            },
                            alphaKeys = new[]
                            {
                                new GradientAlphaKey(0.8f, 0f),
                                new GradientAlphaKey(0f, 1f)
                            }
                        });
                }

                /// <summary>
                /// Creates a looping electric arc particle effect with high speed and chaotic noise.
                /// </summary>
                /// <returns>A <see cref="ParticleSystemBuilder"/> configured for an electric arc effect.</returns>
                public static ParticleSystemBuilder ElectricArc()
                {
                    return new ParticleSystemBuilder("ElectricArc")
                        .WithStartColor(Color.cyan)
                        .WithStartSize(0.1f)
                        .WithStartLifetime(0.3f)
                        .WithStartSpeed(10f)
                        .WithEmissionRate(200f)
                        .WithLooping(true)
                        .WithShape(ParticleSystemShapeType.Cone)
                        .WithNoise(1f)
                        .WithTrails(1f)
                        .WithColorOverLifetime(new Gradient
                        {
                            colorKeys = new[]
                            {
                                new GradientColorKey(Color.white, 0f),
                                new GradientColorKey(Color.cyan, 1f)
                            },
                            alphaKeys = new[]
                            {
                                new GradientAlphaKey(1f, 0f),
                                new GradientAlphaKey(0f, 1f)
                            }
                        });
                }
            }
        }
    }
}
