using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IuvoUnity.IuvoECS.IuvoComponents;

namespace IuvoUnity
{
    namespace IuvoDebug
    {

        public class DebugToggle : IuvoComponent
        {
            public bool _debugOn = false;
        }
        public class DebugString : IuvoComponent
        {
            public string _debugString;
        }
        public class DebugLineNumber : IuvoComponent
        {
            public int _debugOnLine;
        }

        public class DebugDuo : IuvoComponent
        {
            public DebugString _debugString;
            public DebugToggle _debugToggle;
        }

        public class DebugTrio : IuvoComponent
        {
            public DebugToggle _debugToggle;
            public DebugString _debugString;
            public DebugLineNumber _debugLineNumber;
        }

        public class DebugConsole : IuvoComponent
        {
            public void WriteLine(string message, IuvoECS.IuvoEntity.IuvoEntity entity, [CallerLineNumber] int lineNumber = 0)
            {
                {
                    Console.WriteLine(string.Format("[{0}][{1}] : {2}", entity.ToString(), lineNumber, message));
                }
            }
        }
        public class Debugger : IuvoComponent
        {
            public DebugDuo _debugDuo;
            public Dictionary<int, DebugDuo> _debugStatements;
            public DebugConsole _debugConsole;
        }

        public class BreakpointComponent : IuvoComponent
        {
            public int LineNumber;
            public string ConditionDescription;
        }




    }

}

