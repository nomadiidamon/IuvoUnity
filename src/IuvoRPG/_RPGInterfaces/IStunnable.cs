using System;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        public interface IStunnable
        {

            void Stun(float time);
            bool isStunned { get; set; }
        }
    }
}