using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antorcha : MonoBehaviour
{
    [SerializeField] private GameObject luz, fuego;

    public AudioSource audioS;
    public AudioClip clipFuego;

    public float tiempo = 10f;
    public float tiempoRestante;

    private bool deboPrender = true;
    void Start()
    {
        ResetTime();
    }

   
    void Update()
    {
       if(deboPrender == false)
        {
            Temporizador();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
       if(deboPrender)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                
                luz.SetActive(true);
                fuego.SetActive(true);
                EfectoSonido(clipFuego);
                deboPrender = false;
                


            }
        }
        
        
    }

   

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }

    void ResetTime()
    {
        tiempoRestante = tiempo;
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if (tiempoRestante < 0f)
        {
            luz.SetActive(false);
            fuego.SetActive(false);
            deboPrender = true;
            ResetTime();

        }
    }
}
