using System;

namespace HakatonApp
{
    public class HakatonTaskStats
    {
        public TimeSpan MinTaskTime;
        public TimeSpan MaxTaskTime;
        public TimeSpan AvgTaskTime;

        public HakatonTaskStats(TimeSpan minTaskTime, TimeSpan maxTaskTime, TimeSpan avgTaskTime)
        {
            MinTaskTime = minTaskTime;
            MaxTaskTime = maxTaskTime;
            AvgTaskTime = avgTaskTime;
        }
    }
}