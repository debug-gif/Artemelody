using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderl : MonoBehaviour
{
    public float moveDistanceLeft;
    public float moveDistanceRight;
    public float duration = 1f;

    public void MoveRight()
    {
        StartCoroutine(MoveRightWithEasing(moveDistanceRight));
    }

    private IEnumerator MoveRightWithEasing(float distance)//����Ļ������
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + new Vector3(distance, 0, 0);
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            // ʹ�����Һ������л����������ȼ��ٺ���ٵ�Ч��
            float t = elapsedTime / duration;
            float easedT = Mathf.Pow(Mathf.Sin(t * Mathf.PI * 0.5f), 3); // ���Һ����� [0, PI/2] �������� [PI/2, PI] �½�

            transform.position = Vector3.Lerp(startPosition, endPosition, easedT);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = endPosition; // ȷ������λ��׼ȷ
    }
}