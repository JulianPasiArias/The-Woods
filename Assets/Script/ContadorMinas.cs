using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorMinas : MonoBehaviour
{
    public static int minas = 5;
    Text  textMinas;
    public static bool maxAmmo = true;


    void Start()
    {
        textMinas = GetComponent<Text>();
    }

   
    void Update()
    {
        textMinas.text = minas.ToString();

        if(minas >= 5)
        {
            minas = 5;
            
           
        }
           
            

    }
}
