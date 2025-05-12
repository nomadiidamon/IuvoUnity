using IuvoUnity._BaseClasses;
using System.Collections.Generic;


namespace IuvoUnity
{
    namespace _DataStructs
    {
        public class DataDescription : IDataStructBase
        {
            public string _description;
        }

        public class DataLongDescription : IDataStructBase
        {
            public List<string> _sentences;
        }
    }
}