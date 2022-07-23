using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuervo : MonoBehaviour
{
    
    public Transform player;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        if(transform.position.x < player.position.x)
        {
            
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else 
        {
            
             GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
