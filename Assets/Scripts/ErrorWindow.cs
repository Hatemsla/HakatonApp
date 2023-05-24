using System.Collections;
using TMPro;
using UnityEngine;

namespace HakatonApp
{
    public class ErrorWindow : MonoBehaviour
    {
        public GameObject errorPanel;
        public TMP_Text errorText;
        public float fadeDuration = 1.0f;
        public float displayDuration = 2.0f;
        
        private bool _isShowingError = false;

        private void Start()
        {
            // Начать с прозрачного окна ошибки
            SetErrorWindowAlpha(0f);
        }

        public void ShowError(string message)
        {
            // Если окно ошибки уже отображается, игнорируем новый запрос
            if (_isShowingError)
            {
                return;
            }

            // Установить текст ошибки
            errorText.text = message;

            // Запустить корутину для плавного появления и исчезновения окна ошибки
            StartCoroutine(FadeInAndOutErrorWindow());
        }

        private IEnumerator FadeInAndOutErrorWindow()
        {
            _isShowingError = true;

            // Постепенно увеличивать прозрачность окна ошибки
            for (float t = 0f; t < fadeDuration; t += Time.deltaTime)
            {
                float alpha = Mathf.Lerp(0f, 1f, t / fadeDuration);
                SetErrorWindowAlpha(alpha);
                yield return null;
            }

            // Дождаться окончания анимации появления
            yield return new WaitForSeconds(displayDuration);

            // Постепенно уменьшать прозрачность окна ошибки
            for (float t = 0f; t < fadeDuration; t += Time.deltaTime)
            {
                float alpha = Mathf.Lerp(1f, 0f, t / fadeDuration);
                SetErrorWindowAlpha(alpha);
                yield return null;
            }

            _isShowingError = false;
        }

        private void SetErrorWindowAlpha(float alpha)
        {
            // Установить прозрачность окна ошибки и его дочерних объектов
            CanvasGroup canvasGroup = errorPanel.GetComponent<CanvasGroup>();
            canvasGroup.alpha = alpha;
        }
    }
}