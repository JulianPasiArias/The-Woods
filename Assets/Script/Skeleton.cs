using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public Transform player;
    public float agroRange;
    public float speed = 3f;
    public float attackRange;
    public float cooldown;
    public float radius;

    private bool died  = false;

    public LayerMask playerLayer;
    public Transform attackPoint;

    public Animator anim;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(died == false)
        {
            LookAtPlayer();
            CheckDistance();
        }
       
    }


    void CheckDistance()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroRange)

        {
            FollowPlayer();
            anim.SetBool("Run", true);

        }
        else
        {
            anim.SetBool("Run", false);

        }
        if (distToPlayer <= attackRange)
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }

    }



    void LookAtPlayer()
    {
        if (transform.position.x < player.position.x)
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


        if (transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(speed, 0);

        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);

        }
    }

    public void DoAttack()
    {
       
        RaycastHit2D hit = Physics2D.CircleCast(attackPoint.position, radius, Vector2.right, 0f, playerLayer);

        if (hit)
        {
            MuerteRespawn lifeComponent = hit.transform.gameObject.GetComponent<MuerteRespawn>();
            Debug.Log(hit.transform.gameObject.name);

            if (lifeComponent != null)
            {
                lifeComponent.Die();
                
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Trampa"))
        {
            anim.SetTrigger("Death");
            died = true;
            Destroy(gameObject, 2);
        }
    }






}

    

