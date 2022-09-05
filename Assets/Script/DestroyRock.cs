using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRock : MonoBehaviour
{
    public static bool rockDestroyed = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Planta"))
        {
            
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cueva"))
        {
            rockDestroyed = true;
            Debug.Log("luz");
            Destroy(gameObject, 2);
        }
    }
}
