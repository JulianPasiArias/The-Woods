
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life;
    public string nombre;
    public float speed;
    public float agroRange;
    public GameObject player;
    
    


    public void BasicAttack()

    {
        Debug.Log("Atacando");
    }

    public virtual void CheckRange()
    {

        Debug.Log("Checkeando Distancia");
    }

}
