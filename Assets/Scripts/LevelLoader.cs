using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private int currentSceneIndex;
    private int timeToWait = 4;

    void Start()
    {

        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadScene());
        }

    }


    IEnumerator LoadScene()
    {

        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


}
