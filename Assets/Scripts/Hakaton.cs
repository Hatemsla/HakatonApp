﻿using System;

namespace HakatonApp
{
    [Serializable]
    public class Hakaton
    {
        private string _hakatonName;
        private bool _isOnline;
        private DateTime _startDate;
        private DateTime _endDate;
        private decimal _prizeFund;
        private int _participantCount;

        public string HakatonName
        {
            get => _hakatonName;
            set => _hakatonName = value;
        }

        public bool IsOnline 
        {
            get => _isOnline;
            set => _isOnline = value;
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => _startDate = value;
        }

        public DateTime EndDate
        {
            get => _endDate;
            set => _endDate = value;
        }

        public decimal PrizeFund
        {
            get => _prizeFund;
            set => _prizeFund = value;
        }

        public int ParticipantCount
        {
            get => _participantCount;
            set => _participantCount = value;
        }

        public Hakaton(string hakatonName, bool isOnline, DateTime startDate, DateTime endDate, decimal prizeFund,
            int participantCount)
        {
            _hakatonName = hakatonName;
            _isOnline = isOnline;
            _startDate = startDate;
            _endDate = endDate;
            _prizeFund = prizeFund;
            _participantCount = participantCount;
        }

        public Hakaton()
        {
        }
    }
}