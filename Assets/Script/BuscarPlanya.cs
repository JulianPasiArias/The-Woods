using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarPlanya : MonoBehaviour
{
    public GameObject[] planta; 
    void Start()
    {
        planta = GameObject.FindGameObjectsWithTag("Planta");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
