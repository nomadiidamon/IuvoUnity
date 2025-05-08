using System.Collections.Generic;
using UnityEngine;
using IuvoUnity._BaseClasses;

namespace IuvoUnity
{
    namespace _DataStructs
    {

        public class AnimationStateData : IDataStructBase
        {
            int hashID;
            string name;
        }

        public class AnimationBlendData : IDataStructBase
        {
            float _blendSpeed;
            float _blendTime;
        }

        public class AnimationTransitionData : IDataStructBase
        {
            float _transitionSpeed;
            float _transitionTime;
        }

        public class AnimationClipData : IDataStructBase
        {
            AnimationClip _animationClip { get; set; }
        }

        public class AnimationClipsData : IDataStructBase
        {
            List<AnimationClipData> _clips;
        }

        public class AnimationEventData : IDataStructBase
        {
            AnimationEvent _animationEvent { get; set; }
        }



    }
}