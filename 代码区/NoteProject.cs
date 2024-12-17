using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteProject : MonoBehaviour
{
    public bool canBePress;
    public KeyCode keyTopress;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyTopress))
        {
            if(canBePress)
            {
                gameObject.SetActive(false);
                GameManager.instance.NoteHit();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="判定点1")
        {
            canBePress = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag=="判定点1"&&gameObject.activeSelf)
        {
            canBePress = false;
            GameManager.instance.NoteMiss();
        }
    }
}
