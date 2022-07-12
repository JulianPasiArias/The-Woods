using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        if(col.transform.gameObject.tag == "Player")
        {
            Debug.Log("Has chocado con el Muro");
        }
    }
}
