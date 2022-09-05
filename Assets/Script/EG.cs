using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EG : MonoBehaviour
{
    public GameObject easterEgg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            easterEgg.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            easterEgg.SetActive(false);
        }
    }

}
