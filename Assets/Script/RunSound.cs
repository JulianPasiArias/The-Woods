using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    
    public AudioSource jump;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void RunningSound()
    {
        jump.Play();
    }
}
