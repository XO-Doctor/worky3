using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{

    public Sprite[] Sprites;

    Slider Slider;

    public Image Handle;


    // Start is called before the first frame update
    void Start()
    {
        Slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float val = Slider.value / Slider.maxValue;

        //Get number for thing
        val *= Sprites.Length;

        if((int)val > Sprites.Length - 1)
        {
            val = Sprites.Length - 1;
        }

        Handle.sprite = Sprites[(int)val];

    }
}
