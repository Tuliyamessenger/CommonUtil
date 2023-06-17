using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CommonUtil
{
    /// <summary>
    /// 获取屏幕坐标换算成Canvas上的位置。
    /// </summary>
    static public Vector2 GetPosAtCanvasScaler(Vector2 screenPos, RectTransform canvasRect, Vector2 anchor) {
        screenPos /= canvasRect.localScale;
        screenPos -= canvasRect.sizeDelta * anchor;
        return screenPos;
    }
}
