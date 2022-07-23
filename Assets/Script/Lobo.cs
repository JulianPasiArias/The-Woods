using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobo : MonoBehaviour
{
        public Transform player;
        public float agroRange;
        public float speed = 3f;
            
      
        public Animator anim;
        Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
         LookAtPlayer();
         CheckDistance();
    }


    void CheckDistance()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if(distToPlayer < agroRange)
        
        {
            FollowPlayer();
            anim.SetBool("Run", true);

        }
        else 
        {
            anim.SetBool("Run", false);
          
        }
       
    }

    

    void LookAtPlayer()
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
    void FollowPlayer()
    {
        
    
        if(transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(speed, 0);
            
        }
        else 
        {
            rb.velocity = new Vector2(-speed, 0);
            
        }
        
        

    }
    
    
   
      
 

  

    
}
