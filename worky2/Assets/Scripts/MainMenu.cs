using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int MainScene;


    public void backToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(MainScene);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}

