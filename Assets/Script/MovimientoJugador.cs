using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
   public int vida = 100;
   public Vector3 direccion;
   public Vector3 escala;
   public Vector3 movJugador;
   public float velocidad = 10.0f;

    void Start()
    {
       transform.localScale = escala;
       Debug.Log("La vida del jugador es 100");
    }

  
    void Update()
    {
        Curar();
        Lastimar();
        Movimiento();

    }

     void Movimiento()
    {
        transform.position += new Vector3(2, 0, 0);    
        transform.Translate(movJugador * velocidad * Time.deltaTime);
    }

    void Curar()
    {
       Debug.Log(vida++);
    }

    void Lastimar()
    {
       Debug.Log(vida--);
    }

}
