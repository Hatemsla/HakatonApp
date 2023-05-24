using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HakatonApp
{
    public class HakatonInfo : MonoBehaviour
    {
        public Hakaton hakaton;
        public TMP_Text hakatonName;
        public Toggle format;
        public TMP_Text date;
        public TMP_Text participantCount;
        public TMP_Text prizeFund;

        public void SetInfoPanel()
        {
            hakatonName.text = hakaton.HakatonName;
            format.isOn = hakaton.IsOnline;
            date.text = $"{hakaton.StartDate:yyyy.MM.dd}-{hakaton.EndDate:yyyy.MM.dd}";
            participantCount.text = $"Участников: {hakaton.ParticipantCount}";
            prizeFund.text = $"Призовой фонд: {hakaton.PrizeFund}";
        }
    }
}