using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderCode : MonoBehaviour
{
    public UItimer timer;

    public TextMeshProUGUI Text;
    public Slider slider;

    public void UpdateDisplay()
    {
        timer.timeLeft = slider.value * 5;
        float valueu = slider.value * 5;
        float minutes = Mathf.FloorToInt(valueu / 60);
        float seconds = Mathf.FloorToInt(valueu % 60);

        Text.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        if (slider.value == 0)
        {
            timer.endless = true;
        }
        else
        {
            timer.endless = false;
        }
    }
}
