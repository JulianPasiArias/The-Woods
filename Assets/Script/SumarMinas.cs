using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarMinas : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ContadorMinas.minas = 3;
            Destroy(gameObject);
        }
    }
}
