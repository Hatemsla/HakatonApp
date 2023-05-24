using System;
using UnityEngine;

namespace HakatonApp
{
    public class TaskRating
    {
        private string _hakatonName;
        private string _teamName;
        private string _shortTaskDesc;
        private string _judgeTeamName;
        private TimeSpan _executionTime;
        private decimal _estimation;

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

        public string ShortTaskDesc
        {
            get => _shortTaskDesc;
            set => _shortTaskDesc = value;
        }

        public string JudgeTeamName
        {
            get => _judgeTeamName;
            set => _judgeTeamName = value;
        }

        public TimeSpan ExecutionTime
        {
            get => _executionTime;
            set => _executionTime = value;
        }

        public decimal Estimation
        {
            get => _estimation;
            set => _estimation = value;
        }

        public TaskRating(string hakatonName, string teamName, string shortTaskDesc, string judgeTeamName,
            TimeSpan executionTime, decimal estimation)
        {
            HakatonName = hakatonName;
            TeamName = teamName;
            ShortTaskDesc = shortTaskDesc;
            JudgeTeamName = judgeTeamName;
            ExecutionTime = executionTime;
            Estimation = estimation;
        }
    }
}