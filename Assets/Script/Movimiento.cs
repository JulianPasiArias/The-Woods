using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;
    private float jumpForce = 8f;
    private bool isJumping = false;

    public Transform groundCheck;
    private bool isGrounded;
    public LayerMask piso;
    
    public AudioSource audioS;
    public AudioClip clipRisa;

    private Rigidbody2D rb2D;

    public Animator anim;



    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        Debug.Log("Tengo que encontrar ese hongo para ayudar a mi hija");
    }

  
    void Update()
    {
       MovimientoPj(); 
       if(isGrounded)
       {
           Jump();
       }
     
    }
       
    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }


    void MovimientoPj()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, piso);
    
        float horizontalInput = Input.GetAxisRaw("Horizontal") * speed;
        float verticalInput = Input.GetAxisRaw("Vertical") * speed;
        
        Vector3 inputPlayer = new Vector2(horizontalInput,0);

        transform.Translate(inputPlayer * speed * Time.deltaTime);


        if(horizontalInput >0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (horizontalInput <0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if(inputPlayer != Vector3.zero)
        {
            anim.SetBool("Walk", true);
                  
        }
        else
        {
            anim.SetBool("Walk", false);
           
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 4f;
            anim.SetBool("Run", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 3f;
            anim.SetBool("Run", false);
        }
       
    }

    void Jump()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = Vector2.up * jumpForce;
            anim.SetBool("Jump", true);
            isJumping = true;
        }
        else
        {
            anim.SetBool("Jump", false);
        }
      
    }

    void OnTriggerEnter2D(Collider2D coli)
    {
        if(coli.gameObject.CompareTag("Hongo"))
        {
            EfectoSonido(clipRisa);
            Debug.Log("Con esto podré curar a mi hija");
        }
    }

   
   
 

   


   
}


