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

    private IEnumerator MoveRightWithEasing(float distance)//左面的滑块合上
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + new Vector3(distance, 0, 0);
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            // 使用正弦函数进行缓动，创造先加速后减速的效果
            float t = elapsedTime / duration;
            float easedT = Mathf.Pow(Mathf.Sin(t * Mathf.PI * 0.5f), 3); // 正弦函数在 [0, PI/2] 上升，在 [PI/2, PI] 下降

            transform.position = Vector3.Lerp(startPosition, endPosition, easedT);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = endPosition; // 确保最终位置准确
    }
}