using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnim: MonoBehaviour
{
    public AnimationCurve showCurve;
    public AnimationCurve hideCurve;
    public float animationSpeed;
    public GameObject panel;

    IEnumerator ShowPanel(GameObject gameobject)
    {
        float timer = 0;
        while (timer <= 1)
        {
            gameObject.transform.localScale = Vector3.one * showCurve.Evaluate(timer);
            timer += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }
    IEnumerator HidePanel(GameObject gameobject)
    {
        float timer = 0;
        while (timer <= 1)
        {
            gameObject.transform.localScale = Vector3.one * hideCurve.Evaluate(timer);
            timer += Time.deltaTime * animationSpeed;
            yield return null;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShowPanel(gameObject));
        }
        else if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(HidePanel(gameObject));
        }
    }
}