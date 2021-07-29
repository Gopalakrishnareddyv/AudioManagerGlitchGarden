using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float autoLoadLevelTimer;
    private void Start()

    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Invoke("LoadNextLevel", autoLoadLevelTimer);

        }
    }
    //[System.Obsolete]
    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        //Application.LoadLevel(name);
    }
    public void PreviousLevel(string name)
    {
        SceneManager.LoadScene(name);
        //Application.LoadLevel(name);
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    //[System.Obsolete]

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadPreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
}
