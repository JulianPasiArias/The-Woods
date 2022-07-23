using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    
    
    public float tiempo = 2f;
    public float tiempoRestante;
    Quaternion rotacionInicial;
    private int numeroRandom = 0;

    void Start()
    {
        rotacionInicial = transform.rotation;
        ResetTime();
    }

   
    void Update()
    {
        numeroRandom = Random.Range(0, 20);
    }

    void OnTriggerEnter(Collider col)
    {
    
        if(col.transform.gameObject.tag == "Player")
        {
           
            Temporizador();
            Debug.Log ("Chocaste con la Pared Dorada");
        }

    }

     void ResetTime()
    {
        tiempoRestante = tiempo;
    }

    void MoverPared()
    {
        transform.position = new Vector3 (numeroRandom, 0, numeroRandom);
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if( tiempoRestante < 0f)
        {
          MoverPared(); 
          tiempoRestante = 2;
          transform.Rotate (new Vector3(numeroRandom, numeroRandom, numeroRandom) *Time.deltaTime);
        }
    }
}
