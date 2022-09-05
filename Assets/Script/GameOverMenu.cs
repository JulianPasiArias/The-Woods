using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public static bool gameOver = false;
    private void Update()
    {
        if(gameOver)
        {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
          
        }
    }

    public void MainMenu()
    {
       
        MuerteRespawn.isDead = false;
        Time.timeScale = 1;
       
      
        Load();
        
       
        
    }

    void Load()
    {
        SceneManager.LoadScene(0);
    }

   

   
}
