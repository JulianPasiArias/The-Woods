using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLetter : MonoBehaviour
{
    public GameObject letter;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            letter.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            letter.SetActive(false);
        }
    }
}
