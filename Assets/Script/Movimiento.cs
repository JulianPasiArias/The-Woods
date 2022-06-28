using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;

    public GameObject camaraUno;
    public GameObject camaraDos;


    void Start()
    {
        
    }

  
    void Update()
    {
       MovimientoPj(); 
       if(Input.GetKeyDown(KeyCode.C))
       {
            CambioCamara();
       }
       
    }


    void MovimientoPj()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput,0,verticalInput)* speed * Time.deltaTime);
    }


    void CambioCamara()
    {
        if (camaraUno.activeInHierarchy)
        {
            camaraDos.SetActive(true);
            camaraUno.SetActive(false);
        }
        else
        {
            camaraDos.SetActive(false);
            camaraUno.SetActive(true);
        }
     
    }
}


