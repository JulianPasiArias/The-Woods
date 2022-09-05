using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteRespawn : MonoBehaviour
{
    
    public Animator anim;
    private Vector3 respawnPoint;

    public AudioSource audioS;
    public AudioClip clipMuerte;

    public static bool isDead = false;
    


  

   void Start()
   {
       respawnPoint = transform.position;


   }

  

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag ("Planta"))
        {
            Die();
            
            Debug.Log("You Died"); 
        }
        
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("CheckPoint"))
        {
            respawnPoint = transform.position;
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint;
        anim.SetTrigger("Idle");
        isDead = false;
        ColocarTrampa.cooldown = false;
        PlayerUI.maxHealth = false;



    }

     

    public void Die()
    {
        anim.SetTrigger("Death");
        EfectoSonido(clipMuerte);
        PlayerUI.health -= 1;
        isDead = true;
        Invoke("Respawn", 1.0f);



    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }

    
}
