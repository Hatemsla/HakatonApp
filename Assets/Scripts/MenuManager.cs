using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class MenuManager : MonoBehaviour
    {
        public List<Menu> menus;
        public List<SubMenu> subMenus;

        public void OpenMenu(string menuName)
        {
            foreach (var menu in menus)
            {
                if (menu.menuName == menuName)
                    menu.Open();
                else
                    menu.Close();
            }
        }
        
        public void OpenSubMenu(string menuName)
        {
            foreach (var menu in subMenus)
            {
                if (menu.menuName == menuName)
                    menu.Open();
                else
                    menu.Close();
            }
        }
    }
}