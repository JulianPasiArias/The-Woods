using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject prefab;
    public GameObject roca1,roca2;

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
        if( tiempoRestante < 0f)
        {
          ActivarTrampa(); 
          tiempoRestante = 4;
          Debug.Log ("La trampa se ha activado, CORRE!!");

            CinemachineShake.Instance.ShakeCamera(20f, 20f);
            EfectoSonido(clipTerremoto);

        }
    }

    void ActivarTrampa()
    {
        Instantiate (prefab, spawnPoint.position, Quaternion.identity);
        Destroy(roca1);
        Destroy(roca2);
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }
}
