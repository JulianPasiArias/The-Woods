using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    
    public GameObject prefab;
    public Transform spawn;

    public float tiempo = 2f;
    public float tiempoRestante;

   
    void Start()
    {
        ResetTime();
    }
   
   
    void Update()
    {
       
         Temporizador();
         
    }

    void Disparo()
    {
        
        Instantiate(prefab,spawn.position,transform.rotation);

    }

    void ResetTime()
    {
        tiempoRestante = tiempo;
    }
    

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if( tiempoRestante <= 0f)
        {
             Disparo();
            ResetTime();
            Debug.Log("Se ha reseteado el temporizador");
        }
    }
    
   

    
}

