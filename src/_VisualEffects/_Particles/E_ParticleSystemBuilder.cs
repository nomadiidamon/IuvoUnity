using UnityEngine;
using IuvoUnity._Extensions;

namespace IuvoUnity
{
    namespace _VisualEffects
    {
        namespace _Particles
        {
            /// <summary>
            /// A builder class for creating and configuring a ParticleSystem with a fluent API.
            /// </summary>
            public class ParticleSystemBuilder
            {
                private GameObject go;
                private ParticleSystem ps;

                /// <summary>
                /// Initializes a new instance of the <see cref="ParticleSystemBuilder"/> class.
                /// </summary>
                /// <param name="name">The name of the GameObject that will hold the ParticleSystem. Defaults to "ParticleSystem".</param>
                public ParticleSystemBuilder(string name = "ParticleSystem")
                {
                    go = new GameObject(name ?? nameof(ParticleSystem));
                    ps = go.AddComponent<ParticleSystem>();
                    var main = ps.main;
                    main.playOnAwake = false;
                }

                /// <summary>
                /// Sets the parent of the ParticleSystem's GameObject.
                /// </summary>
                /// <param name="parent">The parent transform.</param>
                /// <param name="worldPositionStays">If true, retains the world position; otherwise, sets local position.</param>
                /// <returns>The current builder instance.</returns>
                public ParticleSystemBuilder SetParent(Transform parent, bool worldPositionStays = true)
                {
                    go.transform.SetParent(parent, worldPositionStays);
                    return this;
                }

                /// <summary>
                /// Sets the world position of the ParticleSystem's GameObject.
                /// </summary>
                /// <param name="position">The world position.</param>
                /// <returns>The current builder instance.</returns>
                public ParticleSystemBuilder SetPosition(Vector3 position)
                {
                    go.transform.position = position;
                    return this;
                }

                /// <summary>
                /// Sets the local position of the ParticleSystem's GameObject.
                /// </summary>
                /// <param name="localPosition">The local position relative to the parent.</param>
                /// <returns>The current builder instance.</returns>
                public ParticleSystemBuilder SetLocalPosition(Vector3 localPosition)
                {
                    go.transform.localPosition = localPosition;
                    return this;
                }

                /// <summary>Sets the start color of the particles.</summary>
                public ParticleSystemBuilder WithStartColor(Color color) { ps.WithStartColor(color); return this; }

                /// <summary>Sets the start size of the particles.</summary>
                public ParticleSystemBuilder WithStartSize(float size) { ps.WithStartSize(size); return this; }

                /// <summary>Sets the lifetime of the particles.</summary>
                public ParticleSystemBuilder WithStartLifetime(float lifetime) { ps.WithStartLifetime(lifetime); return this; }

                /// <summary>Sets the start speed of the particles.</summary>
                public ParticleSystemBuilder WithStartSpeed(float speed) { ps.WithStartSpeed(speed); return this; }

                /// <summary>Sets the emission rate of the ParticleSystem.</summary>
                public ParticleSystemBuilder WithEmissionRate(float rate) { ps.WithEmissionRate(rate); return this; }

                /// <summary>Sets a color gradient over the particle lifetime.</summary>
                public ParticleSystemBuilder WithColorOverLifetime(Gradient gradient) { ps.WithColorOverLifetime(gradient); return this; }

                /// <summary>Sets the size of particles over their lifetime using an animation curve.</summary>
                public ParticleSystemBuilder WithSizeOverLifetime(AnimationCurve curve) { ps.WithSizeOverLifetime(curve); return this; }

                /// <summary>Sets whether the ParticleSystem should loop.</summary>
                public ParticleSystemBuilder WithLooping(bool loop) { ps.WithLooping(loop); return this; }

                /// <summary>Sets the duration of the ParticleSystem.</summary>
                public ParticleSystemBuilder WithDuration(float duration) { ps.WithDuration(duration); return this; }

                /// <summary>Sets the shape type for the particle emitter.</summary>
                public ParticleSystemBuilder WithShape(ParticleSystemShapeType shapeType) { ps.WithShape(shapeType); return this; }

                /// <summary>Enables particle collision with the specified layer mask.</summary>
                public ParticleSystemBuilder WithCollision(LayerMask mask) { ps.WithCollision(mask); return this; }

                /// <summary>Enables trails for the particles with a specified lifetime ratio.</summary>
                /// <param name="lifetimeRatio">The ratio of the trail's lifetime to the particle's lifetime.</param>
                public ParticleSystemBuilder WithTrails(float lifetimeRatio = 1f) { ps.WithTrails(lifetimeRatio); return this; }

                /// <summary>Applies noise to the particles with the specified strength.</summary>
                public ParticleSystemBuilder WithNoise(float strength) { ps.WithNoise(strength); return this; }

                /// <summary>Sets velocity over the particle's lifetime.</summary>
                public ParticleSystemBuilder WithVelocityOverLifetime(Vector3 velocity) { ps.WithVelocityOverLifetime(velocity); return this; }

                /// <summary>
                /// Adds a sub-emitter to the ParticleSystem.
                /// </summary>
                /// <param name="subEmitter">The sub-emitter ParticleSystem to use.</param>
                /// <param name="type">The emission type (e.g. birth, death).</param>
                /// <param name="properties">The properties the sub-emitter should inherit.</param>
                /// <returns>The current builder instance.</returns>
                public ParticleSystemBuilder WithSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type = ParticleSystemSubEmitterType.Birth, ParticleSystemSubEmitterProperties properties = ParticleSystemSubEmitterProperties.InheritNothing)
                {
                    ps.WithSubEmitter(subEmitter, type, properties);
                    return this;
                }

                /// <summary>
                /// Finalizes and returns the built <see cref="ParticleSystem"/> without playing it.
                /// </summary>
                /// <returns>The configured <see cref="ParticleSystem"/> instance.</returns>
                public ParticleSystem Build() => ps;

                /// <summary>
                /// Finalizes, plays, and returns the built <see cref="ParticleSystem"/>.
                /// </summary>
                /// <returns>The playing <see cref="ParticleSystem"/> instance.</returns>
                public ParticleSystem BuildAndPlay()
                {
                    ps.Play();
                    return ps;
                }

                /// <summary>
                /// Returns the GameObject that contains the built <see cref="ParticleSystem"/>.
                /// </summary>
                /// <returns>The GameObject instance.</returns>
                public GameObject BuildGameObject() => go;
            }
        }
    }
}
