using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject prefab;
    private bool rockSpawned = false;
    public GameObject roca1, luz;

    public float tiempo = 3f;
    public float tiempoRestante;

    public AudioSource audioS;
    public AudioClip clipTerremoto;



    void Start()
    {
        
        ResetTime();
    }

    
    void Update()
    {
       if(DestroyRock.rockDestroyed)
        {
            luz.SetActive(true);
            Debug.Log("A new path has been revealed");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
    
        if(col.transform.gameObject.tag == "Player")
        {
           
            Temporizador();
           
            
           
            
        }

    }

     void ResetTime()
    {
        tiempoRestante = tiempo;
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if( tiempoRestante < 0f && rockSpawned == false)
        {
          ActivarTrampa();
            rockSpawned = true;
            tiempoRestante = 4;
          Debug.Log ("IT´S A TRAP!! RUN!!");

            CinemachineShake.Instance.ShakeCamera(10f, 25f);
            EfectoSonido(clipTerremoto);

            

        }
       
    }

    void ActivarTrampa()
    {
        Instantiate (prefab, spawnPoint.position, Quaternion.identity);
        Destroy(roca1);

        



    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }
}
