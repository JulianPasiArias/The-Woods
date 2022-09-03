﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMenu : MonoBehaviour
{
    public GameObject gameOver;
    

    
    void Update()
    {
        Invoke("ShowCanvas", 2.0f);
    }


    void ShowCanvas()
    {
        if (SkeletonKing.princessReleased)
        {
            gameOver.SetActive(true);
            

        }
    }

}
