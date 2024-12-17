using UnityEngine;
using UnityEngine.UI; // ����UI�����ռ�
using System.Collections;

public class PanelPopController : MonoBehaviour
{
    public Button buttonShow; // ��ʾ���İ�ť����
    public Button buttonHide; // �������İ�ť����
    public RectTransform panelRectTransform; // ����RectTransform����
    public float duration; // ��������ʱ�䣬���Ը�����Ҫ����

    private Vector3 originalScale; // ����ԭʼ����ֵ

    void Start()
    {
        // ��¼����ԭʼ����ֵ
        originalScale = panelRectTransform.localScale;

        // ��ʼ�����Ϊ����Ϊ0������״̬��
        panelRectTransform.localScale = Vector3.zero;

        // Ϊ������ť��ӵ���¼�����
        buttonShow.onClick.AddListener(ShowPanel);
        buttonHide.onClick.AddListener(HidePanel);
    }

    void ShowPanel()
    {
        // ʹ��Э�̽���ƽ������
        StartCoroutine(ScalePanelCoroutine(Vector3.zero, originalScale));
    }

    void HidePanel()
    {
        // ʹ��Э�̽���ƽ������
        StartCoroutine(ScalePanelCoroutine(originalScale, Vector3.zero));
    }

    IEnumerator ScalePanelCoroutine(Vector3 fromScale, Vector3 toScale)
    {
        float time = 0;
        while (time < duration)
        {
            // ���㵱ǰʱ��ı���
            time += Time.deltaTime;
            float t = time / duration;

            // ����ʱ�����������������
            panelRectTransform.localScale = Vector3.Lerp(fromScale, toScale, t);

            yield return null;
        }

        // ȷ����嵽����������ֵ
        panelRectTransform.localScale = toScale;
    }
}