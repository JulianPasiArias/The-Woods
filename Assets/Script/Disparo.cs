using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
   public float speed = 10f;
   public float damage;
   public Vector3 direction;

    void Update()
    {
        Desplazamiento();
    }

    void Desplazamiento()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
