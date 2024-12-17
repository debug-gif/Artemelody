using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]private Rigidbody2D drop;
    [SerializeField] private float xInput;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //xInput=Input.GetAxisRaw("Horizontal");
        //drop.velocity = new Vector2(xInput, drop.velocity.y);
        //       if (Input.GetKeyDown(KeyCode.Space))
        //     {
        Debug.Log("1");
        drop.velocity = new Vector2(0, -10);
        //     }
    }
}
