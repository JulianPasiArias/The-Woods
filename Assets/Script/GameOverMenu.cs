using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    
    public void MainMenu()
    {
        MuerteRespawn.isDead = false;
        Time.timeScale = 1; 
        SceneManager.LoadScene(0);
        
    }
}
