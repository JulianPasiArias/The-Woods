using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDungeon : MonoBehaviour
{

    private bool isInRange = false;
    private Animator anim;

    private bool open = false;

    public GameObject dialogo, transition; 
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        OpenDoor();
        ShowDialogue();
        
        if (isInRange && PullLever.isPulled)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                transition.SetActive(true);
                Invoke("Load", 1f);
                PullLever.isPulled = false;
                

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

    

    void OpenDoor()
    {
       if(PullLever.isPulled)
        {
            anim.SetTrigger("Open");
            open = true;
        }
           
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            isInRange = false;
        }
    }


    void ShowDialogue()
    {
        if(open == false)
        {
            if (isInRange && PullLever.isPulled == false)
            {
                dialogo.SetActive(true);
            }
            else
            {
                dialogo.SetActive(false);
            }
        }

    }

    void Load()
    {
        SceneManager.LoadScene(4);
    }
}
