using System.Collections.Generic;
using UnityEngine;

namespace HakatonApp
{
    public class HakatonInfoManager : MonoBehaviour
    {
        public Transform content;
        public HakatonInfo hakatonInfoPrefab;
        public List<HakatonInfo> hakatonInfos = default;

        public void CreateHakatonsInfoPanels(Hakaton hakaton)
        {
            var hakatonInfo = Instantiate(hakatonInfoPrefab, content, false);
            hakatonInfo.hakaton = hakaton;
            hakatonInfo.SetInfoPanel();
            hakatonInfos.Add(hakatonInfo);
        }

        public void ClearHakatonsInfoPanel()
        {
            foreach (var hakatonInfo in hakatonInfos)
            {
                Destroy(hakatonInfo.gameObject);
            }
            
            hakatonInfos.Clear();
        }
    }
}