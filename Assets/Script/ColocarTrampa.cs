using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocarTrampa : MonoBehaviour
{
    [SerializeField] private GameObject trampa;
    [SerializeField] private Transform spawnTrampa;

    
    public static bool cooldown = false;

    
    void Update()
    {
       if(cooldown == false)
        {
            SetTrap();
            
        }
       
    }

    void SetTrap()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Instantiate(trampa, spawnTrampa.position, Quaternion.identity);
            ContadorMinas.minas -= 1;
            ContadorMinas.maxAmmo = false;



        }
    }

   
}
