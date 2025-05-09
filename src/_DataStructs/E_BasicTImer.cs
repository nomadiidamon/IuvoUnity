using IuvoUnity._BaseClasses;

namespace IuvoUnity
{
    namespace _DataStructs { 

        [System.Serializable]
        public struct Timer : IDataStructBase
        {
            public float duration;
            public float elapsed;

            public bool IsFinished => elapsed >= duration;

            public void Reset() => elapsed = 0;
            public void Tick(float deltaTime) => elapsed += deltaTime;
        }
    }
}
