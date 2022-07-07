using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
  public Transform playerPos;
    public float enemySpeed = 2f;

    void Start()
    {
        
    }

   
    void Update()
    {
        FollowPlayer();
        CheckDistance();
    }


     void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, enemySpeed * Time.deltaTime);
    }

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
}
