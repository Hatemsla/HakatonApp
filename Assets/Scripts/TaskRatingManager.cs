using System.Collections.Generic;
using UnityEngine;

namespace HakatonApp
{
    public class TaskRatingManager : MonoBehaviour
    {
        public Transform content;
        public TaskRatingInfo taskPrefab;
        public List<TaskRatingInfo> taskRatingInfos = default;
        
        public void CreateTasksInfoPanels(TaskRating taskRating)
        {
            var taskInfo = Instantiate(taskPrefab, content, false);
            taskInfo.TaskRating = taskRating;
            taskInfo.SetInfoPanel();
            taskRatingInfos.Add(taskInfo);
        }

        public void ClearHakatonsInfoPanel()
        {
            foreach (var hakatonInfo in taskRatingInfos)
            {
                Destroy(hakatonInfo.gameObject);
            }
            
            taskRatingInfos.Clear();
        }
    }
}