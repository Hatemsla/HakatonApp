using TMPro;
using UnityEngine;

namespace HakatonApp
{
    public class TopTeamsInfo : MonoBehaviour
    {
        public TopTeam TopTeam;
        public TMP_Text hakatonName;
        public TMP_Text teamName;
        public TMP_Text sumEstimation;
        public TMP_Text sumExecutionTime;
        public TMP_Text teamPrize;
        
        public void SetInfoPanel()
        {
            hakatonName.text = TopTeam.HakatonName;
            teamName.text = $"Команда: {TopTeam.TeamName}";
            sumEstimation.text = $"Набранные баллы: {TopTeam.SumEstimation}";
            sumExecutionTime.text = $"Общее время: {TopTeam.SumExecutionTime}";
            teamPrize.text = $"Выиграли: {TopTeam.TeamPrize}";
        }
    }
}