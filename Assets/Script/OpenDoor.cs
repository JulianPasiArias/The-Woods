using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    
   

   
    void Update()
    {
        if(PullLever.isPulled)
        {
            Destroy(gameObject);
        }
    }
}
