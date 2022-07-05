using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
   
    public Transform playerPos;
    public float enemySpeed = 2f;
    public float speedToLook = 1f;

    void Start()
    {
    
      
    }

    
    void Update()
    {
         switch(statusEnemy)
        {
            case EnemyType.LookAtPlayer:
            LookAtPlayer();
            break;
            case EnemyType.FollowPlayer:
            FollowPlayer();
            break;
            
        }
        CheckDistance();
    }

    public enum EnemyType 
    {
        LookAtPlayer,
        FollowPlayer
    };

    public EnemyType statusEnemy;
    
    
    void CheckDistance()
    {
        float distance = Vector3.Distance(transform.position, playerPos.position);

        if(distance < 2)
        {
            enemySpeed = 0f;
        }
        else
        {
            enemySpeed = 2f;
        }
    }


    void LookAtPlayer()
    {
        transform.LookAt(playerPos);
        Quaternion newRotation = Quaternion.LookRotation(playerPos.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }

    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, enemySpeed * Time.deltaTime);
    }

    
}

