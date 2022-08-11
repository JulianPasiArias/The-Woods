using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Eventos.evento += ChangeScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScale()
    {
        transform.localScale = new Vector2(30, 30);
    }

    private void OnDisable()
    {
        Eventos.evento -= ChangeScale;
    }
}
