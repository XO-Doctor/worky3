using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public List<SpriteRenderer> spigs = new List<SpriteRenderer>();
    public SpriteRenderer cur;
    public int spiglayer = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y < 0 && spigs.Count != 1 && spiglayer != 1)
        {
            spigs.RemoveAt(spiglayer - 1);
            spigs.Insert(spiglayer - 2, cur);
            spiglayer -= 1;
            spigs[spiglayer - 1].sortingOrder = spiglayer;
            spigs[spiglayer].sortingOrder = spigs[spiglayer].sortingOrder + 1;
        }
        if (Input.mouseScrollDelta.y > 0 && spigs.Count != 1 && spiglayer != spigs.Count)
        {
            spigs.RemoveAt(spiglayer - 1);
            spigs.Insert(spiglayer, cur);
            spiglayer += 1;
            spigs[spiglayer - 1].sortingOrder = spiglayer;
            spigs[spiglayer - 2].sortingOrder = spigs[spiglayer - 2].sortingOrder - 1;
        }
    }
}
