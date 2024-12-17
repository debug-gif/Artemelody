using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOnAwake : MonoBehaviour
{
    public SceneTransition sceneTransition; // ����SceneTransition�ű�

    private void Awake()
    {
        // ȷ��SceneTransition�ű��Ѿ����ú�
        if (sceneTransition == null)
        {
            Debug.LogError("SceneTransition script is not set in the inspector!");
            return;
        }

        // ��������Ч��
        sceneTransition.StartCoroutine(sceneTransition.FadeInCoroutine(sceneTransition.fadeInTime));
    }
}