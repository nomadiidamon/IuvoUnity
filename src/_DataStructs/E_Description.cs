using IuvoUnity._BaseClasses;
using System.Collections.Generic;


namespace IuvoUnity
{
    namespace _DataStructs
    {
        public class Description : IDataStructBase
        {
            public string _description;
        }

        public class LongDescription : IDataStructBase
        {
            public List<string> _sentences;
        }
    }
}