using System.Collections.Generic;
using UnityEngine;

namespace HakatonApp
{
    public class TopTeamsManager : MonoBehaviour
    {
        public Transform content;
        public TopTeamsInfo topTeamPrefab;
        public List<TopTeamsInfo> topTeamsInfos = default;
        
        public void CreateTopTeamsPanels(TopTeam topTeam)
        {
            var topTeamPanel = Instantiate(topTeamPrefab, content, false);
            topTeamPanel.TopTeam = topTeam;
            topTeamPanel.SetInfoPanel();
            topTeamsInfos.Add(topTeamPanel);
        }

        public void ClearHakatonsInfoPanel()
        {
            foreach (var hakatonInfo in topTeamsInfos)
            {
                Destroy(hakatonInfo.gameObject);
            }
            
            topTeamsInfos.Clear();
        }
    }
}