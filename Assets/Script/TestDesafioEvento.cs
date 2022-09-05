using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestDesafioEvento : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            myTrigger.Invoke();
        }
    }
}
