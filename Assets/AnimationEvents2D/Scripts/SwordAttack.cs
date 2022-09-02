using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public float damage;
    public float cooldown;
    public  float radius;
    public LayerMask layerMask;
    public Transform attackPoint;

    private float timer;

    private Animator animator;

    private void Start()
    {
        timer = cooldown;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Timer();
    }

    private void Timer()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            animator.SetTrigger("DoAttack");
            timer = cooldown;
        }
    }

    public void DoAttack()
    {
        RaycastHit2D hit = Physics2D.CircleCast(attackPoint.position, radius, Vector2.right, 0f, layerMask);

        if (hit)
        {
            Life lifeComponent = hit.transform.gameObject.GetComponent<Life>();

            if (lifeComponent != null)
            {
                lifeComponent.TakeDamage(damage);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 0.25f);
        Gizmos.DrawSphere(attackPoint.position, radius);
    }
}
