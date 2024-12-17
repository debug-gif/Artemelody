using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelShadow : MonoBehaviour
{
    public RectTransform panelRectTransform;
    public Image shadowImage;
    public Vector2 shadowOffset = new Vector2(0, -5); // 阴影偏移量，这里设置为向下偏移
    public float shadowBlur = 5f; // 阴影模糊度
    public Color shadowColor = new Color(0, 0, 0, 0.5f); // 阴影颜色

    void Start()
    {
        // 设置阴影Image的位置
        RectTransform shadowRect = shadowImage.GetComponent<RectTransform>();
        shadowRect.sizeDelta = panelRectTransform.sizeDelta + new Vector2(shadowBlur, shadowBlur);
        shadowRect.position = panelRectTransform.position + (Vector3)shadowOffset;

        // 设置阴影Image的颜色和透明度
        shadowImage.color = shadowColor;

        // 设置阴影Image的Raycast Target为false
        shadowImage.raycastTarget = false;
    }

    void Update()
    {
        // 动态更新阴影的位置，以匹配面板的位置
        if (shadowImage != null && panelRectTransform != null)
        {
            RectTransform shadowRect = shadowImage.GetComponent<RectTransform>();
            shadowRect.position = panelRectTransform.position + (Vector3)shadowOffset;
        }
    }
}