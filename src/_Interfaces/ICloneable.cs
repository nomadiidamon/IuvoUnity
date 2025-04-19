using System;
namespace IuvoUnity
{
    namespace _Interfaces
    {
        public interface ICloneable<T>
        {
            //Return a perfect copy of the object
            T Clone();
        }

    }
}