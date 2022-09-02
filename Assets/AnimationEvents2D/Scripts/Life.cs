using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float life;

    private Animator animator;

    private void Start()
    {
        print($"Goblin arranca con {life} puntos de vida");
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        life -= damage;

        if (life <= 0f)
        {
            print("Goblin muerto...");
            animator.SetTrigger("DoDie");
        }
        else
        {
            print($"Goblin recibe {damage} puntos de daño y le quedan {life} puntos de vida");
            animator.SetTrigger("DoDamage");
        }
    }

    public void AutoDestroy()
    {
        Destroy(gameObject);
    }
}
