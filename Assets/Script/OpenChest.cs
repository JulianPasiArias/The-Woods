using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public bool isInRange = false;
    private Animator anim;
    public static bool isOpen = false;

    public AudioSource audioS;
    public AudioClip clipOpen;

    public GameObject canvas;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Open();
                isOpen = true;
                canvas.SetActive(true);
                Destroy(canvas, 3);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            isInRange = true;
        }
        else
        {
            isInRange = false;
        }
    }
    void Open()
    {
        anim.SetTrigger("Open");
        EfectoSonido(clipOpen);
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }

    

}
