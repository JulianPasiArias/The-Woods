using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorMinas : MonoBehaviour
{
    public static int minas = 3;
    Text  textMinas;


    void Start()
    {
        textMinas = GetComponent<Text>();
    }

   
    void Update()
    {
        textMinas.text = minas.ToString();

        if(minas > 3)
            minas = 3;
    }
}
