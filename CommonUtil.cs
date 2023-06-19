using System;
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

    /// <summary>
    /// 为动作添加监听，忽略相同监听。
    /// </summary>
    static public void AddListener(ref Action action, Action listener) {
        if(!ActionHasListener(action, listener)) {
            action += listener;
        }
    }

    /// <summary>
    /// 为动作添加监听，忽略相同监听。
    /// </summary>
    static public void AddListener<T>(ref Action<T> action, Action<T> listener) {
        if (!ActionHasListener(action, listener)) {
            action += listener;
        }
    }

    /// <summary>
    /// 为动作添加监听，忽略相同监听。
    /// </summary>
    static public void AddListener<T1, T2>(ref Action<T1, T2> action, Action<T1, T2> listener) {
        if (!ActionHasListener(action, listener)) {
            action += listener;
        }
    }

    /// <summary>
    /// 判断该动作是否存在指定监听。
    /// </summary>
    static public bool ActionHasListener(Delegate action, Delegate listener){
        if (action != null) {
            Delegate[] delegates = action.GetInvocationList();
            for (int i = 0; i < delegates.Length; i += 1) {
                if (delegates[i].Equals(listener)) {
                    return true;
                }
            }
        }
        return false;
    }
}
