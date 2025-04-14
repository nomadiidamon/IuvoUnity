using UnityEngine;
using System;
using System.Collections.Generic;

namespace IuvoUnity
{
    namespace IuvoECS
    {
        namespace IuvoComponents
        {
            public abstract class IuvoComponent
            {
                public virtual void OnAdd(IuvoEntity.IuvoEntity entity) { }
                public virtual void OnRemove(IuvoEntity.IuvoEntity entity) { }
            }

            public abstract class Configuration : IuvoComponent
            {
                // base class for the configurations of various objects
                public virtual void OnConfigure(IuvoEntity.IuvoEntity entity) { }
                public virtual void Reconfigure(IuvoEntity.IuvoEntity entity) { }
            }

            public class NameComponent : IuvoComponent
            {

                string _name { get; set; }
            }

            public class TagComponent : IuvoComponent
            {

                string _name { get; set; }
            }

            public class IDNumberComponent : IuvoComponent
            {
                public int _id;
            }

            public class IuvoRegistryID : IDNumberComponent
            {

            }

            public class IuvoTimerID : IDNumberComponent
            {

            }


            public class IuvoWorldID : IuvoComponent
            {
                public IuvoRegistryID _registryID;
                public IuvoTimerID _timerID;
                public IuvoEntity.IuvoEntity _entity;
            }

            public class IuvoMin_INT_Component : IuvoComponent
            {
                public int _min;
            }

            public class IuvoMax_INT_Component : IuvoComponent
            {
                public int _max;
            }

            public class IuvoMinMax_INT_Component : IuvoComponent
            {
                public IuvoMin_INT_Component Minimum;
                public IuvoMax_INT_Component Maximum;
            }

            public class IuvoMin_FLOAT_Component : IuvoComponent
            {
                public float min;
            }

            public class IuvoMax_FLOAT_Component : IuvoComponent
            {
                public float max;
            }

            public class IuvoMinMax_FLOAT : IuvoComponent
            {
                public IuvoMin_FLOAT_Component Minimum;
                public IuvoMax_FLOAT_Component Maximum;
            }

            public class TargetComponent : IuvoComponent
            {
                public IuvoEntity.IuvoEntity _targetEntity;
            }

            public class PositionComponent : IuvoComponent
            {
                public Vector3 _position;
            }

            public class RotationComponent : IuvoComponent
            {
                public Quaternion _rotation;
            }

            public class ScaleComponent : IuvoComponent
            {
                public Vector3 _scale;
            }

            public class TransformComponent : IuvoComponent
            {
                public PositionComponent Position;
                public RotationComponent Rotation;
                public ScaleComponent Scale;
            }

            public class PatrolRouteComponent
            {
                public List<PositionComponent> _positions;
            }

            public class VelocityComponent : IuvoComponent
            {
                public Vector3 Velocity;
            }

            public class InteractionComponent : IuvoComponent
            {
                public Action<IuvoEntity.IuvoEntity> OnInteract;
            }

            public class MagnetizeComponent : IuvoComponent
            {
                public float _magneticStrength;
                public bool _isMagnetic;
            }
        }

    }
}
