using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarVida : MonoBehaviour
{
    public GameObject vidaEsqueleto;
    public GameObject musicFight;

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            vidaEsqueleto.SetActive(true);
            musicFight.SetActive(true);
            
        }
    }

   
}
