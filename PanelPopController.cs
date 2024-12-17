using UnityEngine;
using UnityEngine.UI; // 引用UI命名空间
using System.Collections;

public class PanelPopController : MonoBehaviour
{
    public Button buttonShow; // 显示面板的按钮引用
    public Button buttonHide; // 隐藏面板的按钮引用
    public RectTransform panelRectTransform; // 面板的RectTransform引用
    public float duration; // 动画持续时间，可以根据需要调整

    private Vector3 originalScale; // 面板的原始缩放值

    void Start()
    {
        // 记录面板的原始缩放值
        originalScale = panelRectTransform.localScale;

        // 初始化面板为缩放为0（隐藏状态）
        panelRectTransform.localScale = Vector3.zero;

        // 为两个按钮添加点击事件监听
        buttonShow.onClick.AddListener(ShowPanel);
        buttonHide.onClick.AddListener(HidePanel);
    }

    void ShowPanel()
    {
        // 使用协程进行平滑弹出
        StartCoroutine(ScalePanelCoroutine(Vector3.zero, originalScale));
    }

    void HidePanel()
    {
        // 使用协程进行平滑缩回
        StartCoroutine(ScalePanelCoroutine(originalScale, Vector3.zero));
    }

    IEnumerator ScalePanelCoroutine(Vector3 fromScale, Vector3 toScale)
    {
        float time = 0;
        while (time < duration)
        {
            // 计算当前时间的比例
            time += Time.deltaTime;
            float t = time / duration;

            // 根据时间比例更新面板的缩放
            panelRectTransform.localScale = Vector3.Lerp(fromScale, toScale, t);

            yield return null;
        }

        // 确保面板到达最终缩放值
        panelRectTransform.localScale = toScale;
    }
}