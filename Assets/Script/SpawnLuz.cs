using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLuz : MonoBehaviour
{
    public GameObject luz;
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Planta"))
        {

            luz.SetActive(true);
            
        }
    }
}
