using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public static bool GameIsPaused = false;
    

    
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Escape))

            if(GameIsPaused)
             {
                Resume();
             }
             else
             {
                Pause();
              }
            
    }

    void Pause()
    {

        pauseMenu.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0f;
         Debug.Log("Menu");
        
    }

    void Resume()
    {
  
        pauseMenu.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1f;
        
    }
}
