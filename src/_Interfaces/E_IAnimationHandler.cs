
using UnityEngine;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        public interface IAnimationHandler
        {
            void Play(string animationName);
            void Play(AnimationClip clip);
            void Stop();
            void SetBlend(float blendTime);
            bool IsPlaying(string animationName);
            AnimationClip GetCurrentClip();
        }
    }
}