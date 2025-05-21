using IuvoUnity._DataStructs;

namespace IuvoUnity
{
    namespace _DataStructs
    {
        public class IuvoAnimation
        {
            public AnimationStateData stateData;
            public AnimationBlendData blendData;
            public AnimationTransitionData transitionData;
            public AnimationClipsData animClips;
            public AnimationEventData eventData;

            public IuvoAnimation()
            {
                stateData = new AnimationStateData();
                blendData = new AnimationBlendData();
                transitionData = new AnimationTransitionData();
                animClips = new AnimationClipsData();
                eventData = new AnimationEventData();
            }

            public IuvoAnimation(AnimationStateData _stateData, AnimationBlendData _blendData,
                AnimationTransitionData _transitionData, AnimationClipsData _animClips,
                AnimationEventData _eventData)
            {
                stateData = _stateData;
                blendData = _blendData;
                transitionData = _transitionData;
                animClips = _animClips;
                eventData = _eventData;
            }
        }
    }
}
