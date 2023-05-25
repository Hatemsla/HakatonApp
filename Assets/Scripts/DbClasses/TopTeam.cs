using System;
using UnityEngine.Experimental.GlobalIllumination;

namespace HakatonApp
{
    public class TopTeam
    {
        public string HakatonName { get; set; }
        public string TeamName { get; set; }
        public decimal SumEstimation { get; set; }
        public TimeSpan SumExecutionTime { get; set; }
        public decimal TeamPrize { get; set; }

        public TopTeam(string hakatonName, string teamName, decimal sumEstimation, TimeSpan sumExecutionTime,
            decimal teamPrize)
        {
            HakatonName = hakatonName;
            TeamName = teamName;
            SumEstimation = sumEstimation;
            SumExecutionTime = sumExecutionTime;
            TeamPrize = teamPrize;
        }
    }
}