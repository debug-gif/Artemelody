using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public float time;
    public void quit()
    {
        Invoke("GameQuit", time);
    }
    void GameQuit()
    {
        Application.Quit();
    }
}
