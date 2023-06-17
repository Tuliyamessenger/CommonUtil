using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CommonUtil
{
    /// <summary>
    /// ��ȡ��Ļ���껻���Canvas�ϵ�λ�á�
    /// </summary>
    static public Vector2 GetPosAtCanvasScaler(Vector2 screenPos, RectTransform canvasRect, Vector2 anchor) {
        screenPos /= canvasRect.localScale;
        screenPos -= canvasRect.sizeDelta * anchor;
        return screenPos;
    }
}
