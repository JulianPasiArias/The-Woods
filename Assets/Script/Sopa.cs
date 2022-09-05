using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sopa : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Player") && PlayerUI.maxHealth == false)
        {
            print("asdasfa");
            Collectable1 collectable = collision.gameObject.GetComponent<Collectable1>();
            if(collectable != null)
            {
                collectable.CollectLife();
            }
            PlayerUI.health += 1;
            Destroy(gameObject);
        }
        
    }

   
}
