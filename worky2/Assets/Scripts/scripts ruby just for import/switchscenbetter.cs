using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscenbetter : MonoBehaviour

{

public void playgame()

    {
        SceneManager.LoadScene(1);
    }

public void back()
    {
        SceneManager.LoadScene(0);
    }

}
    
    

   
