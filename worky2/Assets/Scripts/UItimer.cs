using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UItimer : MonoBehaviour
{
    public float timeLeft;
    public bool TimerOn = false;
    public bool endless = true;

    public GameObject Over;
    public MoveBrush brush;
    public GameObject spriteManager;
    public TextMeshProUGUI TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimerOn)
        {
            if (endless)
            {
                this.gameObject.SetActive(false);
            }
            else
            {
                if (timeLeft > 0)
                {
                    timeLeft -= Time.deltaTime;
                    updateTimer(timeLeft);
                }
                else
                {
                    spriteManager.SetActive(true);
                    Destroy(brush.current);
                    brush.follow = false;
                    timeLeft = 0;
                    TimerOn = false;
                    Over.SetActive(true);
                    this.gameObject.SetActive(false);
                }
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
