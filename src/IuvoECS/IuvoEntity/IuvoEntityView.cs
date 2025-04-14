using UnityEngine;

namespace IuvoUnity.IuvoECS
{
    namespace IuvoEntity
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