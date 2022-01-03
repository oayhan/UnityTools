using UnityEngine;

namespace OTools.UI
{
    public static class UiHelpers
    {
        public static void SetSafeArea(Canvas canvas, RectTransform safeAreaContainer)
        {
            var safeArea = Screen.safeArea;
            var canvasRect = canvas.pixelRect;
   
            var anchorMin = safeArea.position;
            var anchorMax = safeArea.position + safeArea.size;
            anchorMin.x /= canvasRect.width;
            anchorMin.y /= canvasRect.height;
            anchorMax.x /= canvasRect.width;
            anchorMax.y /= canvasRect.height;

            safeAreaContainer.anchorMax = anchorMax;
            safeAreaContainer.anchorMin = anchorMin;
        }
    }
}