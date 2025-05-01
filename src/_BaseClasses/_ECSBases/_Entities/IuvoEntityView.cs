using UnityEngine;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _ECS
        {
            public class EntityView : MonoBehaviour
            {
                public IuvoEntity _Entity { get; private set; }

                public void Initialize(IuvoEntity entity)
                {
                    _Entity = entity;
                }
            }
        }
    }
}