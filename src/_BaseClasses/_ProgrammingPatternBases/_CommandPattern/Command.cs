using System;
using System.Collections.Generic;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        public abstract class Command
        {
            public abstract void Execute();
            public abstract void Undo();
        }
    }
}