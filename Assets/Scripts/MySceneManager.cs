using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadPrevScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ReloadCurrentScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
