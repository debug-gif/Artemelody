using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOnAwake : MonoBehaviour
{
    public SceneTransition sceneTransition; // 引用SceneTransition脚本

    private void Awake()
    {
        // 确保SceneTransition脚本已经设置好
        if (sceneTransition == null)
        {
            Debug.LogError("SceneTransition script is not set in the inspector!");
            return;
        }

        // 触发淡入效果
        sceneTransition.StartCoroutine(sceneTransition.FadeInCoroutine(sceneTransition.fadeInTime));
    }
}