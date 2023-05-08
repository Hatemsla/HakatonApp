using UnityEngine;

namespace DefaultNamespace
{
    public class SubMenu : MonoBehaviour
    {
        public string menuName;

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}