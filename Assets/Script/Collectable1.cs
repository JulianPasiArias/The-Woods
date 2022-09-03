﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable1 : MonoBehaviour
{
    public AudioSource audioS;
    public AudioClip clipCollectable;

    public void CollectLife()
    {
        EfectoSonido(clipCollectable);
    }

    void EfectoSonido(AudioClip _clip)
    {
        audioS.clip = _clip;
        audioS.Play();
    }


}
