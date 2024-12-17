using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public Canvas canvas; // ����Canvas
    public Image blackScreen; // �������ں�����Image
    public float fadeInTime = 1f; // ����ʱ��
    public float fadeOutTime = 1f; // ����ʱ��

    private void Start()
    {
        // ȷ�����õ�����Ѿ����ú�
        if (canvas == null || blackScreen == null)
        {
            Debug.LogError("Canvas or Black Screen Image is not set in the inspector!");
            return;
        }

        // ��ʼʱ���غ���
        blackScreen.color = new Color(0, 0, 0, 0);
    }

    // ���ô˷�������ʼ����ת��
    public void LoadSceneWithFade(string sceneName)
    {
        StartCoroutine(FadeInOut(sceneName));
    }

    private IEnumerator FadeInOut(string sceneName)
    {
        // ����
        yield return FadeOutCoroutine(fadeOutTime);

        // �����³���
        SceneManager.LoadScene(sceneName);

        // ����
        //yield return FadeInCoroutine(fadeInTime);
    }

    public IEnumerator FadeOutCoroutine(float time)
    {
        // ����ȫ͸������ȫ��͸��
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
        // ����ȫ��͸������ȫ͸��
        float elapsedTime = 0f;
        while (elapsedTime < time)
        {
            elapsedTime += Time.deltaTime;
            blackScreen.color = new Color(0, 0, 0, Mathf.Lerp(1f, 0f, elapsedTime / time));
            yield return null;
        }
    }
}