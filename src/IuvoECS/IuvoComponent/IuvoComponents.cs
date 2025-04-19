using UnityEngine;
using System;
using System.Collections.Generic;
using IuvoUnity.IuvoECS.IuvoComponents.IuvoComponentInterfaces;

namespace IuvoUnity
{
    namespace IuvoECS
    {
        namespace IuvoComponents
        {
            public abstract class IuvoComponent
            {

            }
            

            public abstract class Configuration : IuvoComponent, IConfigure, IReconfigure
            {
                // base class for the configurations of various objects
                public virtual void OnConfigure(IuvoEntity.IuvoEntity entity) { }
                public virtual void OnReconfigure(IuvoEntity.IuvoEntity entity) { }
            }

            public class NameComponent : IuvoComponent
            {
                string _name { get; set; }
            }

            public class DescriptionComponent : IuvoComponent
            {
                public string _description { get; set; }
            }

            public class Name_DescriptionComponent : IuvoComponent
            {
                public NameComponent _name { get; set; }
                public DescriptionComponent _description { get; set; }
            }

            public class TagComponent : IuvoComponent
            {
                string _tag { get; set; }
            }

            public class IDNumberComponent : IuvoComponent
            {
                public int _id { get; set; }
            }

            public class IuvoRegistryID : IDNumberComponent
            {

            }

            public class IuvoTimerID : IDNumberComponent
            {

            }


            public class IuvoWorldID : IuvoComponent
            {
                public IuvoRegistryID _registryID { get; set; }
                public IuvoTimerID _timerID { get; set; }
                public IuvoEntity.IuvoEntity _entity { get; set; }
            }

            public class IuvoMin_INT_Component : IuvoComponent
            {
                public int _min {  get; set; }
            }

            public class IuvoMax_INT_Component : IuvoComponent
            {
                public int _max { get; set; }
            }

            public class IuvoMinMax_INT_Component : IuvoComponent
            {
                public IuvoMin_INT_Component Minimum { get; set; }
                public IuvoMax_INT_Component Maximum { get; set; }
            }

            public class IuvoMin_FLOAT_Component : IuvoComponent
            {
                public float min {  get; set; }
            }

            public class IuvoMax_FLOAT_Component : IuvoComponent
            {
                public float max {  get; set; }
            }

            public class IuvoMinMax_FLOAT : IuvoComponent
            {
                public IuvoMin_FLOAT_Component Minimum { get; set; }
                public IuvoMax_FLOAT_Component Maximum { get; set; }
            }

            public class TargetComponent : IuvoComponent
            {
                public IuvoEntity.IuvoEntity _targetEntity {  get; set; }
            }

            public class PositionComponent : IuvoComponent
            {
                public Vector3 _position {  get; set; }
            }

            public class RotationComponent : IuvoComponent
            {
                public Quaternion _rotation {  get; set; }
            }

            public class EasyRotationComponent : IuvoComponent
            {
                public Quaternion _quaternion;
                public Vector3 _eulerAngles;

                public Quaternion Quaternion
                {
                    get => _quaternion;
                    set
                    {
                        _quaternion = value;
                        _eulerAngles = _quaternion.eulerAngles;
                    }
                }

                public Vector3 EulerAngles
                {
                    get => _eulerAngles;
                    set
                    {
                        _eulerAngles = value;
                        _quaternion = Quaternion.Euler(_eulerAngles);
                    }
                }

                public void ApplyTo(Transform transform)
                {
                    transform.rotation = _quaternion;
                }

                public void FromTransform(Transform transform)
                {
                    Quaternion = transform.rotation;
                }
            }

            public class ScaleComponent : IuvoComponent
            {
                public Vector3 _scale { get; set; }
            }

            public class TransformComponent : IuvoComponent
            {
                public PositionComponent Position { get; set; }
                public EasyRotationComponent Rotation { get; set; }
                public ScaleComponent Scale { get; set; }
            }

            public class EasyTransformComponent : IuvoComponent
            {
                public PositionComponent _myPosition { get; set; }
                public EasyRotationComponent _myRotation { get; set; }
                public ScaleComponent _myScale { get; set; }
                public ScaleComponent _myWorldScale { get; set; }
            }

            public class PatrolRouteComponent : IuvoComponent
            {
                public List<PositionComponent> _positions {  get; set; }
            }

            public class VelocityComponent : IuvoComponent
            {
                public Vector3 Velocity { get; set; }
            }

            public class InteractionComponent : IuvoComponent
            {
                public Action<IuvoEntity.IuvoEntity> OnInteract { get; set; }
            }

            public class MagnetizeComponent : IuvoComponent
            {
                public float _magneticStrength { get; set; }
                public bool _isMagnetic { get; set; }
            }
        }

    }
}
