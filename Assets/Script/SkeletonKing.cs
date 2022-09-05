using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonKing : MonoBehaviour
{
    public Transform player;
    public float agroRange;
    public float speed = 3f;
    public float attackRange;
    public float cooldown;
    public float radius;

    public GameObject carcel;
    public GameObject enraged;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

   public static bool died = false;
    public static bool princessReleased = false;

    public LayerMask playerLayer;
    public Transform attackPoint;

    [SerializeField] private Color colorEnraged = Color.white;
    private Renderer rend;

    public Animator anim;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        rend = GetComponent<Renderer>();
    }

   
    void Update()
    {
        if (died == false)
        {
            LookAtPlayer();
            CheckDistance();
            Die();
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
        if (collision.gameObject.CompareTag("Trampa"))
        {
            TakeDamage(20);
            
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
       if(currentHealth <= 50)

        {
            enraged.SetActive(true);
            speed = 10f;
            rend.material.color = colorEnraged;

        }

       if(currentHealth <= 0)

        {
            carcel.SetActive(false);
            princessReleased = true;
            anim.SetTrigger("Death");
            died = true;
            Destroy(gameObject, 3);
        }
    }
}
