using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaTimer : MonoBehaviour
{
    public float tiempo = 5f;
    public float tiempoRestante;

    [SerializeField] private GameObject explosion;
    [SerializeField] private Transform explosionSpawn;

    public AudioSource audioS;
    public AudioClip clipExplosion;


    void Start()
    {
        tiempoRestante = tiempo;
        ColocarTrampa.cooldown = true;

    }

    private void Update()
    {
        Temporizador();
        Cooldown();
        
    }


    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if (tiempoRestante < 0f)
        {
            ColocarTrampa.cooldown = false;
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Skeleton"))
        {
            ColocarTrampa.cooldown=false;
            Instantiate(explosion, explosionSpawn.position, Quaternion.identity);
            EfectoSonido(clipExplosion);
            Destroy(gameObject, 1);

        }
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }

    void Cooldown()
    {
        if(ContadorMinas.minas == 0)
        {
            ColocarTrampa.cooldown = true;
        }
    }
}
