using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    public Transform player;
    public bool isSizeChanged = false;

    
    void OnTriggerExit(Collider collision)
    {
         if (isSizeChanged == false && collision.transform.gameObject.tag == "Player")
        {
            Debug.Log("Has chocado con el Portal");
            collision.transform.localScale = player.transform.localScale /2;
            isSizeChanged = true;
        }

        else if( isSizeChanged == true && collision.transform.gameObject.tag == "Player" )
        {
            Debug.Log("Has chocado con el Portal");
            collision.transform.localScale = player.transform.localScale *2;
            isSizeChanged = false;
        }

    }
       
    

  

   
}
