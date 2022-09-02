using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip clipAmmo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Minas"))
        {
            EfectoSonido(clipAmmo);
            ColocarTrampa.cooldown = false;
        }
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }
}
