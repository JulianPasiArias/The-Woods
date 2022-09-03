using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerUI : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOverText, mainMenuText, mainMenuBlood;
    public static int health;

    public static bool maxHealth = true;
    

    void Start()
    {
        health = 3;
       
        gameOverText.SetActive(false);
        mainMenuText.SetActive(false);
        mainMenuBlood.SetActive(false);


       
    }

   
    void Update()
    {
        if (health > 3)
        {
            health = 3;
            maxHealth = true;
        }
            
       
        
        
      

        switch(health)
        {
            case 3:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(true); 
                break;

            case 2:
                heart1.SetActive(true);
                heart2.SetActive(true);
                heart3.SetActive(false);
                break;

            case 1:
                heart1.SetActive(true);
                heart2.SetActive(false);
                heart3.SetActive(false);
                break;

            case 0: 
                heart1.SetActive(false);
                heart2.SetActive(false);
                heart3.SetActive(false);
                Invoke("TiempoParado", 0.8f);
                gameOverText.SetActive(true);
                mainMenuText.SetActive(true);
                mainMenuBlood.SetActive(true);

                break;

        }


    }

    void TiempoParado()
    {
        Time.timeScale = 0;
    }
}
