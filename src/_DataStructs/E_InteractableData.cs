using IuvoUnity._BaseClasses;

namespace IuvoUnity
{

    namespace _DataStructs
    {
        [System.Serializable]
        public struct InteractableData : IDataStructBase
        {
            public string displayName;
            public string tooltip;
            public bool isEnabled;
        }
    }
}