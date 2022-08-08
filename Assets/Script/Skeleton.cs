
using UnityEngine;

public class Skeleton : Enemy
{

    private void Start()
    {
        BasicAttack();
        BoneAttack();
        CheckRange();
    }

    public void BoneAttack()
    {
        Debug.Log("Realizando ataque de hueso");
    }

    public override void CheckRange()
    {
        base.CheckRange();
       
        Debug.Log("Perseguir Jugador");
        

    }


}
