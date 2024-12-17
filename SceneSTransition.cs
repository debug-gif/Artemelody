using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Canvas canvas; // 引用Canvas
    public Image blackScreen; // 引用用于黑屏的Image
    public float fadeInTime = 1f; // 淡入时间
    public float fadeOutTime = 1f; // 淡出时间

    private void Start()
    {
        // 确保引用的组件已经设置好
        if (canvas == null || blackScreen == null)
        {
            Debug.LogError("Canvas or Black Screen Image is not set in the inspector!");
            return;
        }

        // 初始时隐藏黑屏
        blackScreen.color = new Color(0, 0, 0, 0);
    }

    // 调用此方法来开始场景转换
    public void LoadSceneWithFade(string sceneName)
    {
        StartCoroutine(FadeInOut(sceneName));
    }

    private IEnumerator FadeInOut(string sceneName)
    {
        // 淡出
        yield return FadeOutCoroutine(fadeOutTime);

        // 加载新场景
        SceneManager.LoadScene(sceneName);

        // 淡入
        //yield return FadeInCoroutine(fadeInTime);
    }

    public IEnumerator FadeOutCoroutine(float time)
    {
        // 从完全透明到完全不透明
        float elapsedTime = 0f;
        while (elapsedTime < time)
        {
            elapsedTime += Time.deltaTime;
            blackScreen.color = new Color(0, 0, 0, Mathf.Lerp(0f, 1f, elapsedTime / time));
            yield return null;
        }
    }

    public IEnumerator FadeInCoroutine(float time)
    {
        // 从完全不透明到完全透明
        float elapsedTime = 0f;
        while (elapsedTime < time)
        {
            elapsedTime += Time.deltaTime;
            blackScreen.color = new Color(0, 0, 0, Mathf.Lerp(1f, 0f, elapsedTime / time));
            yield return null;
        }
    }
}