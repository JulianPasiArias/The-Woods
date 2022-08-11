using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Eventos : MonoBehaviour
{
    public static event Action evento;
    public static event Action eventoDos;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            evento?.Invoke();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            eventoDos?.Invoke();
        }
    }   


}
