using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransToSettings : MonoBehaviour
{
    public float time;
    public void TS()
    {
        Invoke("Load", time);
    }
    private void Load()
    {
        SceneManager.LoadScene("Settings");
    }
}
