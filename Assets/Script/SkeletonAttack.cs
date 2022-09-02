using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SkeletonAttack : MonoBehaviour
{
    public LayerMask player;

    public UnityEvent<GameObject> OnPlayerDetected;

    private Animator animator;

    [Range(.1f, 1)]
    public float radius;

    public bool PlayerDetected { get; private set; }

    [Header("Gizmo Parameter")]
    public Color gizmoColor = Color.green;
    public bool showGizmos = true;
    

    
    void Update()
    {
        var collider = Physics2D.OverlapCircle(transform.position, radius, player);
        PlayerDetected = collider != null;
        if (PlayerDetected)
        { 
            OnPlayerDetected?.Invoke(collider.gameObject);
            animator.SetTrigger("Attack");
        }

    }

    private void OnDrawGizmos()
    {
        if(showGizmos)
        {
            Gizmos.color = gizmoColor;
            Gizmos.DrawSphere(transform.position, radius);
        }
    }
}
