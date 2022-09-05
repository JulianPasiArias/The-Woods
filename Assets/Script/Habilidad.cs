using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Habilidad : MonoBehaviour
{
    public Image abilityImage1;
    public float cooldown1 = 5;
    bool isCooldown = false;
    public KeyCode ability1;
    void Start()
    {
        abilityImage1.fillAmount = 0;
    }

    
    void Update()
    {
        Abillity1();
        if(ContadorMinas.minas == 0)
        {
            abilityImage1.fillAmount = 1;
        }
        if(ColocarTrampa.cooldown == false)
        {
            abilityImage1.fillAmount = 0;
        }
    }

    void Abillity1()
    {
        if(Input.GetKey(ability1) && isCooldown == false)
        {
            isCooldown = true;
            abilityImage1.fillAmount = 1;
        }
        if(isCooldown)
        {
            abilityImage1.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if(abilityImage1.fillAmount <= 0)
            {
                abilityImage1.fillAmount = 0;
                isCooldown = false; 
            }    
        }
    }
}
