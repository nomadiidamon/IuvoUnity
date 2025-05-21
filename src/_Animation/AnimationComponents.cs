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

            public AnimationStateData()
            {
                name = "animName";
                hashID = 0;
            }

            public AnimationStateData(string name)
            {
                this.name = name;
                hashID = name.GetHashCode();
            }
        }

        public class AnimationBlendData : IDataStructBase
        {
            float _blendSpeed;
            float _blendTime;

            public AnimationBlendData()
            {
                _blendSpeed = 1.0f;
                _blendTime = 0.0f;
            }

            public AnimationBlendData(float blendSpeed, float blendTime)
            {
                _blendSpeed = blendSpeed;
                _blendTime = blendTime;
            }
        }

        public class AnimationTransitionData : IDataStructBase
        {
            float _transitionSpeed;
            float _transitionTime;

            public AnimationTransitionData()
            {
                _transitionSpeed = 1.0f;
                _transitionTime = 0.0f;
            }

            public AnimationTransitionData(float transitionSpeed, float transitionTime)
            {
                _transitionSpeed = transitionSpeed;
                _transitionTime = transitionTime;
            }
        }

        public class AnimationClipData : IDataStructBase
        {
            AnimationClip _animationClip { get; set; }

            public AnimationClipData()
            {
                _animationClip = null;
            }

            public AnimationClipData(AnimationClip clip)
            {
                _animationClip = clip;
            }

        }

        public class AnimationClipsData : IDataStructBase
        {
            List<AnimationClipData> _clips;

            public AnimationClipsData()
            {
                _clips = new List<AnimationClipData>();
            }

            public AnimationClipsData(List<AnimationClipData> clips)
            {
                _clips = clips ?? new List<AnimationClipData>();
            }
        }

        public class AnimationEventData : IDataStructBase
        {
            AnimationEvent _unityAnimEvent { get; set; }
            System.Action _nativeAnimEvent {  get; set; }

            public AnimationEventData()
            {
                _unityAnimEvent = new AnimationEvent();
                _nativeAnimEvent = null;
            }

            public AnimationEventData(AnimationEvent unityEvent, System.Action nativeEvent)
            {
                _unityAnimEvent = unityEvent;
                _nativeAnimEvent = nativeEvent;
            }
        }



    }
}