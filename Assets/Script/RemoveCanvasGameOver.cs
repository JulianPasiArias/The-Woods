using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCanvasGameOver : MonoBehaviour
{
    public static bool mainMenuActive = true;
    void Awake()
    {
      
     
            GameOverMenu.gameOver = false;
            Time.timeScale = 1;
        
        
    }

   
}
