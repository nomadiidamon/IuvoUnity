namespace IuvoUnity
{
    namespace IuvoTime
    {
        public enum Timer_Activity_Mode
        {
            LONG_TERM_COUNTDOWN, SHORT_COUNTDOWN, COUNTDOWN,
            LONG_TERM_TIMER, SHORT_TERM_TIMER, TIMER,
            LONG_TERM_STOPWATCH, SHORT_TERM_STOPWATCH, STOPWATCH,
            SPECIAL_ACTIVITY, NULL
        }

        public enum Count_Logic
        {
            TICK_ON_FRAMES,
            TICK_ON_TIME
        }
    }
}
