using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
{
    public SpriteRenderer SR;
    public Sprite beforeImage;
    public Sprite afterImage;
    public KeyCode KeyToPress;
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            SR.sprite = afterImage;
        }
        if (Input.GetKeyUp(KeyToPress))
        {
            SR.sprite = beforeImage;
        }
    }
}
