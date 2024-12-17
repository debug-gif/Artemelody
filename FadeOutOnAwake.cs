using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutOnAwake : MonoBehaviour
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
        sceneTransition.StartCoroutine(sceneTransition.FadeOutCoroutine(sceneTransition.fadeOutTime));
    }
}