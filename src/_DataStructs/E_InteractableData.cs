using IuvoUnity._BaseClasses;

namespace IuvoUnity
{

    namespace _DataStructs
    {
        [System.Serializable]
        public struct InteractableData : IDataStructBase
        {
            public DataName displayName;
            public DataDescription tooltip;
            public bool isEnabled;
        }
    }
}