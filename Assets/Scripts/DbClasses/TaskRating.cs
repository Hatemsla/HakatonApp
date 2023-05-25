using System;
using UnityEngine;

namespace HakatonApp
{
    public class TaskRating
    {
        public string HakatonName { get; set; }
        public string TeamName { get; set; }
        public string ShortTaskDesc { get; set; }
        public string JudgeTeamName { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        public decimal Estimation { get; set; }

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