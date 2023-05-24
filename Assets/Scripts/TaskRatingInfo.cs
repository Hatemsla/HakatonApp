using TMPro;
using UnityEngine;

namespace HakatonApp
{
    public class TaskRatingInfo : MonoBehaviour
    {
        public TaskRating TaskRating;
        public TMP_Text hakatonName;
        public TMP_Text teamName;
        public TMP_Text shortDesc;
        public TMP_Text judgeTeamName;
        public TMP_Text executionTime;
        public TMP_Text estimation;
        
        public void SetInfoPanel()
        {
            hakatonName.text = TaskRating.HakatonName;
            teamName.text = $"Команда: {TaskRating.TeamName}";
            shortDesc.text = $"Задача: {TaskRating.ShortTaskDesc}";
            judgeTeamName.text = $"Команда судей: {TaskRating.JudgeTeamName}";
            executionTime.text = $"Время выполнения: {TaskRating.ExecutionTime}";
            estimation.text = $"Баллы: {TaskRating.Estimation}";
        }
    }
}