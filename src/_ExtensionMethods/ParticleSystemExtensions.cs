using System;
using UnityEngine;

namespace IuvoUnity._ExtensionMethods
{
    public static class ParticleSystemExtensions
    {
        public static void WithEmissionRate(this ParticleSystem ps, float emissionRate)
        {
            if (ps == null) return;
            var emission = ps.emission;
            emission.rateOverTime = emissionRate;
        }

        public static void WithColorOverLifetime(this ParticleSystem ps, Gradient gradient)
        {
            if (ps == null || gradient == null) return;
            var col = ps.colorOverLifetime;
            col.enabled = true;
            col.color = gradient;
        }

        public static void WithSizeOverLifetime(this ParticleSystem ps, AnimationCurve curve)
        {
            if (ps == null || curve == null) return;
            var size = ps.sizeOverLifetime;
            size.enabled = true;
            size.size = new ParticleSystem.MinMaxCurve(1, curve);
        }

        public static void WithStartColor(this ParticleSystem ps, Color color)
        {
            if (ps == null) return;
            var main = ps.main;
            main.startColor = color;
        }

        public static void WithStartSize(this ParticleSystem ps, float size)
        {
            if (ps == null) return;
            var main = ps.main;
            main.startSize = size;
        }

        public static void WithStartLifetime(this ParticleSystem ps, float lifetime)
        {
            if (ps == null) return;
            var main = ps.main;
            main.startLifetime = lifetime;
        }

        public static void WithStartSpeed(this ParticleSystem ps, float speed)
        {
            if (ps == null) return;
            var main = ps.main;
            main.startSpeed = speed;
        }

        public static void WithLooping(this ParticleSystem ps, bool loop)
        {
            if (ps == null) return;
            var main = ps.main;
            main.loop = loop;
        }

        public static void WithDuration(this ParticleSystem ps, float duration)
        {
            if (ps == null) return;
            var main = ps.main;
            main.duration = duration;
        }

        public static void WithShape(this ParticleSystem ps, ParticleSystemShapeType shapeType)
        {
            if (ps == null) return;
            var shape = ps.shape;
            shape.enabled = true;
            shape.shapeType = shapeType;
        }

        public static void WithCollision(this ParticleSystem ps, LayerMask collisionMask)
        {
            if (ps == null) return;
            var collision = ps.collision;
            collision.enabled = true;
            collision.type = ParticleSystemCollisionType.World;
            collision.collidesWith = collisionMask;
        }

        public static void WithTrails(this ParticleSystem ps, float lifetimeRatio = 1f)
        {
            if (ps == null) return;
            var trails = ps.trails;
            trails.enabled = true;
            trails.lifetime = lifetimeRatio;
        }

        public static void WithNoise(this ParticleSystem ps, float strength)
        {
            if (ps == null) return;
            var noise = ps.noise;
            noise.enabled = true;
            noise.strength = strength;
        }

        public static void WithVelocityOverLifetime(this ParticleSystem ps, Vector3 velocity)
        {
            if (ps == null) return;
            var velocityModule = ps.velocityOverLifetime;
            velocityModule.enabled = true;
            velocityModule.x = velocity.x;
            velocityModule.y = velocity.y;
            velocityModule.z = velocity.z;
        }

        public static void AddSubEmitter(this ParticleSystem ps, ParticleSystem subEmitter, ParticleSystemSubEmitterType type = ParticleSystemSubEmitterType.Birth, ParticleSystemSubEmitterProperties properties = ParticleSystemSubEmitterProperties.InheritNothing)
        {
            if (ps == null || subEmitter == null) return;
            var subEmitters = ps.subEmitters;
            subEmitters.AddSubEmitter(subEmitter, type, properties);
        }
    }

    public class ParticleSystemBuilder
    {
        private GameObject go;
        private ParticleSystem ps;

        public ParticleSystemBuilder(string name = "ParticleSystem")
        {
            go = new GameObject(name ?? nameof(ParticleSystem));
            ps = go.AddComponent<ParticleSystem>();
            var main = ps.main;
            main.playOnAwake = false;
        }

        public ParticleSystemBuilder SetParent(Transform parent)
        {
            go.transform.SetParent(parent);
            return this;
        }

        public ParticleSystemBuilder SetPosition(Vector3 position)
        {
            go.transform.position = position;
            return this;
        }

        public ParticleSystemBuilder WithStartColor(Color color) { ps.WithStartColor(color); return this; }
        public ParticleSystemBuilder WithStartSize(float size) { ps.WithStartSize(size); return this; }
        public ParticleSystemBuilder WithStartLifetime(float lifetime) { ps.WithStartLifetime(lifetime); return this; }
        public ParticleSystemBuilder WithStartSpeed(float speed) { ps.WithStartSpeed(speed); return this; }
        public ParticleSystemBuilder WithEmissionRate(float rate) { ps.WithEmissionRate(rate); return this; }
        public ParticleSystemBuilder WithColorOverLifetime(Gradient gradient) { ps.WithColorOverLifetime(gradient); return this; }
        public ParticleSystemBuilder WithSizeOverLifetime(AnimationCurve curve) { ps.WithSizeOverLifetime(curve); return this; }
        public ParticleSystemBuilder WithLooping(bool loop) { ps.WithLooping(loop); return this; }
        public ParticleSystemBuilder WithDuration(float duration) { ps.WithDuration(duration); return this; }
        public ParticleSystemBuilder WithShape(ParticleSystemShapeType shapeType) { ps.WithShape(shapeType); return this; }
        public ParticleSystemBuilder WithCollision(LayerMask mask) { ps.WithCollision(mask); return this; }
        public ParticleSystemBuilder WithTrails(float lifetimeRatio = 1f) { ps.WithTrails(lifetimeRatio); return this; }
        public ParticleSystemBuilder WithNoise(float strength) { ps.WithNoise(strength); return this; }
        public ParticleSystemBuilder WithVelocityOverLifetime(Vector3 velocity) { ps.WithVelocityOverLifetime(velocity); return this; }

        public ParticleSystemBuilder WithSubEmitter(ParticleSystem subEmitter, ParticleSystemSubEmitterType type = ParticleSystemSubEmitterType.Birth, ParticleSystemSubEmitterProperties properties = ParticleSystemSubEmitterProperties.InheritNothing)
        {
            ps.AddSubEmitter(subEmitter, type, properties);
            return this;
        }

        public ParticleSystem Build() => ps;

        public ParticleSystem BuildAndPlay()
        {
            ps.Play();
            return ps;
        }

        public GameObject BuildGameObject() => go;
    }

    public static class ParticleSystemPresetFactory
    {
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
