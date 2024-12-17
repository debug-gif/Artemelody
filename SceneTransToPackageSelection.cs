using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransToPackageSelection : MonoBehaviour
{
    public float time;
    public void Trans()
    {
        Invoke("Load", time);
    }
    private void Load()
    {
        SceneManager.LoadScene("PackageSelection");
    }
}
