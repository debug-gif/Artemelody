using System.Collections;
using UnityEngine;

public class slidelBackwards : MonoBehaviour
{
    public float moveDistance;
    public float duration;

    private void Awake()
    {
        StartCoroutine(MoveBackWardsCoroutine(moveDistance ));
    }

    private IEnumerator MoveBackWardsCoroutine(float distance)
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + new Vector3(-distance, 0, 0);
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            float easedT = Mathf.Pow(Mathf.Sin(t * Mathf.PI * 0.5f), 3);

            transform.position = Vector3.Lerp(startPosition, endPosition, easedT);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = endPosition;
    }
}