using UnityEngine;

namespace HakatonApp
{
    public class BackButtonHandler : MonoBehaviour
    {
        private bool _backButtonPressed = false;  // Флаг для отслеживания первого нажатия кнопки "Назад"
        private float _backButtonTimeout = 2f; // Время ожидания между нажатиями кнопки "Назад"
        private float _backButtonTimer = 0f;     // Таймер для отслеживания времени между нажатиями

        void Update()
        {
            // Проверяем нажатие кнопки "Назад" на Android
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!_backButtonPressed)
                {
                    // Устанавливаем флаг первого нажатия кнопки "Назад" и запускаем таймер
                    _backButtonPressed = true;
                    _backButtonTimer = Time.time;
                }
                else
                {
                    // Проверяем, прошло ли достаточно времени между нажатиями
                    if (Time.time - _backButtonTimer <= _backButtonTimeout)
                    {
                        // Закрываем приложение
                        Application.Quit();
                    }
                    else
                    {
                        // Если прошло слишком много времени, сбрасываем флаг первого нажатия
                        _backButtonPressed = false;
                    }
                }
            }
        }
    }
}