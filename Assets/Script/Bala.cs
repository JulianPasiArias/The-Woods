using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    
    public GameObject prefab;
    public Transform spawn;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))

        {
           Disparo();
        }

        if(Input.GetKeyDown(KeyCode.L))

        {
           Disparo();
        }
        if(Input.GetKeyDown(KeyCode.J))

        {
           Disparo();
        }
    }

    void Disparo()
    {
        Instantiate(prefab,spawn.position,transform.rotation);
        Debug.Log("El jugador esta disparando");
    }
    
    

    
}

