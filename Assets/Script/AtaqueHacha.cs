using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueHacha : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}
