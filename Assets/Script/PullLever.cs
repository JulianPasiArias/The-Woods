using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullLever : MonoBehaviour
{
    private bool isInRange = false;
    private Animator anim;
    public static bool isPulled = false;

    public AudioSource audioS;
    public AudioClip clipPull;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                LeverPull();
                isPulled = true;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            
            isInRange = true;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }    
    }

    void LeverPull()
    {
        anim.SetTrigger("Pull");
        EfectoSonido(clipPull);
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }
}
