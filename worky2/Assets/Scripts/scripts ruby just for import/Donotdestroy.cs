using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donotdestroy : MonoBehaviour
{
    void Awake()
    {
        List<GameObject> musicObj = new List<GameObject>();
        musicObj.AddRange(GameObject.FindGameObjectsWithTag("GameMusic"));

        if( musicObj.Count > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
