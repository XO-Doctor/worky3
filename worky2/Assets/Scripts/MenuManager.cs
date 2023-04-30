using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject self;
    public MoveBrush brush;
    public UItimer timer;
    public void Monster()
    {
        brush.sprites = brush.monstersprites;
        startGame();
    }

    public void Surreal()
    {
        brush.sprites = brush.surrealsprites;
        startGame();
    }

    public void Abstract()
    {
        brush.sprites = brush.abstractsprites;
        brush.isAbstract = true;
        startGame();
    }

    void startGame()
    {
        self.SetActive(false);
        brush.Begin();
        timer.TimerOn = true;
    }
}
