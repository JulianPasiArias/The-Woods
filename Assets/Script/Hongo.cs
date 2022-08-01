using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D col)

    {
        if(col.gameObject.CompareTag("Player"))
        {
           
            Destroy(gameObject);
            Debug.Log("Hay algo sospechoso acerca de este lugar");
            
           
        }

    }
  
}
