using TMPro;
using UnityEngine;

namespace HakatonApp
{
    public class HakatonTaskStatsInfo : MonoBehaviour
    {
        public TMP_Text minTaskTime;
        public TMP_Text maxTaskTime;
        public TMP_Text avgTaskTime;

        public void SetInfoPanel(HakatonTaskStats hakatonTaskStats)
        {
            minTaskTime.text = $"Минимальное время выполнения задачи: {hakatonTaskStats.MinTaskTime:hh\\:mm\\:ss}";
            maxTaskTime.text = $"Максимальное время выполнения задачи: {hakatonTaskStats.MaxTaskTime:hh\\:mm\\:ss}";
            avgTaskTime.text = $"Среднее время выполнения задачи: {hakatonTaskStats.AvgTaskTime:hh\\:mm\\:ss}";
        }
    }
}