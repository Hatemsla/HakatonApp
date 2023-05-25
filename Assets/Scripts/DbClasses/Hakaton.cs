using System;
using Unity.VisualScripting;

namespace HakatonApp
{
    public class Hakaton
    {
        public string HakatonName { get; set; }
        public bool IsOnline { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PrizeFund { get; set; }
        public int ParticipantCount { get; set; }

        public Hakaton(string hakatonName, bool isOnline, DateTime startDate, DateTime endDate, decimal prizeFund,
            int participantCount)
        {
            HakatonName = hakatonName;
            IsOnline = isOnline;
            StartDate = startDate;
            EndDate = endDate;
            PrizeFund = prizeFund;
            ParticipantCount = participantCount;
        }
    }
}