using System;
using UnityEngine.Experimental.GlobalIllumination;

namespace HakatonApp
{
    public class TopTeam
    {
        private string _hakatonName;
        private string _teamName;
        private decimal _sumEstimation;
        private TimeSpan _sumExecutionTime;
        private decimal _teamPrize;

        public string HakatonName
        {
            get => _hakatonName;
            set => _hakatonName = value;
        }

        public string TeamName
        {
            get => _teamName;
            set => _teamName = value;
        }

        public decimal SumEstimation
        {
            get => _sumEstimation;
            set => _sumEstimation = value;
        }

        public TimeSpan SumExecutionTime
        {
            get => _sumExecutionTime;
            set => _sumExecutionTime = value;
        }

        public decimal TeamPrize
        {
            get => _teamPrize;
            set => _teamPrize = value;
        }

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