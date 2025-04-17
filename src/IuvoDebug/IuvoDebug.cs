using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IuvoUnity.IuvoECS.IuvoComponents;
using UnityEngine;

namespace IuvoUnity
{
    namespace IuvoDebug
    {
        public static class _Debug
        {
            public static void DebugTransform(Transform toDebug)
            {
                DebugPosition(toDebug.position);
                DebugRotation(toDebug.rotation);
                DebugEulerAngles(toDebug.eulerAngles);
                DebugScale(toDebug.localScale);
                DebugLossyScale(toDebug.lossyScale);
            }

            public static void DebugPosition(Vector3 position)
            {
                Debug.Log("Position: X=" + position.x + " Y=" + position.y + " Z=" + position.z);
            }

            public static void DebugRotation(Quaternion rotation)
            {
                Debug.Log("Quaternion: X=" + rotation.x + " Y=" + rotation.y + " Z=" + rotation.z + "W=" + rotation.w);
            }

            public static void DebugEulerAngles(Vector3 eulerAngles)
            {
                Debug.Log("Angles: X=" + eulerAngles.x + " Y=" + eulerAngles.y + " Z=" + eulerAngles.z);
            }

            public static void DebugScale(Vector3 scale)
            {
                Debug.Log("Scale: X=" + scale.x + " Y=" + scale.y + " Z=" + scale.z);
            }

            public static void DebugLossyScale(Vector3 lossyScale)
            {
                Debug.Log("Lossy Scale: X=" + lossyScale.x + " Y=" + lossyScale.y + " Z=" + lossyScale.z);
            }
        }

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

