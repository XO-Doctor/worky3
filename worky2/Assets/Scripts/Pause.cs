using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public MoveBrush brush;
    public GameObject PauseMenu;
    public GameObject spriteManager;
    public static bool isPaused;

    void Start()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        spriteManager.SetActive(false);
        brush.follow = false;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        spriteManager.SetActive(true);
        brush.follow = true;
        Time.timeScale = 1f;
        isPaused = false;
    }

    //public void Quit()
    //{
       // aplication.Quit();
    //}

}
