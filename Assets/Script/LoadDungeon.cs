using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDungeon : MonoBehaviour
{

    public bool isInRange = false;
    private Animator anim;

    private bool open = false;

    public GameObject dialogo; 
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
                SceneManager.LoadScene(4);
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
        if(isInRange && PullLever.isPulled == false)
        {
            dialogo.SetActive(true);
        }
        else
        {
            dialogo.SetActive(false);
        }
    }
}
