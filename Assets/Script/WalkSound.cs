using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSound : MonoBehaviour
{
    public AudioSource walk;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WalkingSound()
    {
        walk.Play();
    }
}
