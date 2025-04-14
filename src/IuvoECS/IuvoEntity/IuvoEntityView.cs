using UnityEngine;

namespace IuvoUnity.IuvoECS
{
    namespace IuvoEntity
    {
        public class EntityView : MonoBehaviour
        {
            IuvoEntity _Entity { get; set; }

            public void Initialize(IuvoEntity entity)
            {
                _Entity = entity;
            }
        }
    }
}