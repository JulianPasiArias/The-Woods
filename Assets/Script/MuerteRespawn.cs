using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteRespawn : MonoBehaviour
{
    
    public Animator anim;
    private Vector3 respawnPoint;

    public AudioSource audioS;
    public AudioClip clipMuerte;


  

   void Start()
   {
       respawnPoint = transform.position;
      
      
   }

  

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag ("Planta"))
        {
            Die();
            Invoke("Respawn", 1.0f);
           
            Debug.Log("Moriste");
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint;
        anim.SetTrigger("Idle");
        
        
       
    }

     

    void Die()
    {
        anim.SetTrigger("Death");
        EfectoSonido(clipMuerte);
        PlayerUI.health -= 1;
        

    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }

    
}
