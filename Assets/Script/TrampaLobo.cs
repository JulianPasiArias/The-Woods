using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaLobo : MonoBehaviour
{
    public Transform loboSpawn;
    public GameObject lobo;

    public AudioSource audioS;
    public AudioClip clipFuego;
       
  

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SpawnLobo();
            Debug.Log("Espero que la casa esté a salvo");
        }
    }

    void SpawnLobo()
    {
        Instantiate (lobo, loboSpawn.position, Quaternion.identity);
        EfectoSonido(clipFuego);
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }

}
