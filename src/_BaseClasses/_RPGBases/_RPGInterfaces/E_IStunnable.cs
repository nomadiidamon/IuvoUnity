using System;

namespace IuvoUnity
{
    namespace _Interfaces
    {

        namespace _RPG
        {
            public interface IStunnable
            {

                void Stun(float time);
                bool isStunned { get; set; }
            }
        }
    }
}