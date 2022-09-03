using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
     public bool isInRange = false;
     public AudioSource abrir;

    public GameObject interact, transition;



   
    
    void Update()
    {
        if(isInRange)
        {
           interact.SetActive(true);
            
            
            if(Input.GetKeyDown(KeyCode.E))
          {
             transition.SetActive(true);
             AbrirPuerta();
             Invoke("LoadNextLevel", 1f);
            
          }
        }
       
        
    }

   void OnTriggerEnter2D(Collider2D col)
   {
       if(col.gameObject.CompareTag("Player"))
       {
           isInRange = true;
       }
       
   }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange= false;
            interact.SetActive(false);
        }
    }

    void AbrirPuerta()
   {
       abrir.Play();
   }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(2);
    }
}
