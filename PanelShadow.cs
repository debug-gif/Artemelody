using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelShadow : MonoBehaviour
{
    public RectTransform panelRectTransform;
    public Image shadowImage;
    public Vector2 shadowOffset = new Vector2(0, -5); // ��Ӱƫ��������������Ϊ����ƫ��
    public float shadowBlur = 5f; // ��Ӱģ����
    public Color shadowColor = new Color(0, 0, 0, 0.5f); // ��Ӱ��ɫ

    void Start()
    {
        // ������ӰImage��λ��
        RectTransform shadowRect = shadowImage.GetComponent<RectTransform>();
        shadowRect.sizeDelta = panelRectTransform.sizeDelta + new Vector2(shadowBlur, shadowBlur);
        shadowRect.position = panelRectTransform.position + (Vector3)shadowOffset;

        // ������ӰImage����ɫ��͸����
        shadowImage.color = shadowColor;

        // ������ӰImage��Raycast TargetΪfalse
        shadowImage.raycastTarget = false;
    }

    void Update()
    {
        // ��̬������Ӱ��λ�ã���ƥ������λ��
        if (shadowImage != null && panelRectTransform != null)
        {
            RectTransform shadowRect = shadowImage.GetComponent<RectTransform>();
            shadowRect.position = panelRectTransform.position + (Vector3)shadowOffset;
        }
    }
}