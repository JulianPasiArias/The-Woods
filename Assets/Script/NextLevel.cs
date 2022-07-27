using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
     public bool isInRange = false;
     public AudioSource abrir;

   
    
    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(KeyCode.E))
          {
            AbrirPuerta();
            Invoke("LoadNextLevel", 1.0f);
            
          }
        }
        
    }

   void OnTriggerEnter2D(Collider2D col)
   {
       if(col.gameObject.CompareTag("Player"))
       {
           isInRange = true;
       }
       else
       {
           isInRange = false;
       }
   }

   void AbrirPuerta()
   {
       abrir.Play();
   }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
