using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip clipAmmo;

   public void CollectingAmmo()
    {
        EfectoSonido(clipAmmo);
        ColocarTrampa.cooldown = false;
        print("sonido");
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }
}
