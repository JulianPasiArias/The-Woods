using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    public Transform playerPos;
    public float speedToLook = 1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }

     void LookAtPlayer()
    {
        
        Quaternion newRotation = Quaternion.LookRotation(playerPos.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }
}
