using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarMinas : MonoBehaviour
{

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && ContadorMinas.maxAmmo == false) 
        {
            CollectAmmo collectAmmo = collision.gameObject.GetComponent<CollectAmmo>();
            if(collectAmmo != null)
            {
                collectAmmo.CollectingAmmo();
            }
            ContadorMinas.minas = 5;
            ContadorMinas.maxAmmo = true;
            Destroy(gameObject);
        }
    }
}
