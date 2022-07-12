using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;


    private float rotateSpeed = 100f;
    


    void Start()
    {
        
    }

  
    void Update()
    {
       MovimientoPj(); 
       
       
    }


    void MovimientoPj()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, 0, verticalInput) * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, horizontalInput, 0 ) * rotateSpeed * Time.deltaTime);
    }


   
}


