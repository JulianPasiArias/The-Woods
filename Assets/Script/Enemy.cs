
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    
    
    


    public void BasicAttack()

    {
        Debug.Log("Atacando");
    }

    public virtual void CheckRange()
    {

        Debug.Log("Checkeando Distancia");
    }

}
