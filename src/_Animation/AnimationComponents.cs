using System.Collections.Generic;
using UnityEngine;

namespace IuvoUnity
{   
    namespace IuvoECS
    {
        namespace IuvoComponents
        {

                public class AnimationStateData
                {
                    int hashID;
                    string name;
                }

                public class AnimationBlendData
                {
                    float _blendSpeed;
                    float _blenTime;
                }

                public class AnimationTransitionData
                {
                    float _transitionSpeed;
                    float _transitionTime;
                }

                public class AnimationClipData
                {
                    AnimationClip _animationClip { get; set; }
                }

                public class AnimationClipsData
                {
                    List<AnimationClipData> _clips;
                }

                public class AnimationEventData
                {
                    AnimationEvent _animationEvent { get; set; }
                }

            
        }
    }
}