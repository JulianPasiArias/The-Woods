using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour
{
    public GameObject prefab, spawnPoint;

    void Start()
    {
        Eventos.evento += InstantiateObject;
        Eventos.eventoDos += Anuncio;
    }


    void Update()
    {

    }

    void InstantiateObject()
    {
        Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);

    }

    private void OnDisable()
    {
        Eventos.evento -= InstantiateObject;
        Eventos.eventoDos -= Anuncio;
    }

    void Anuncio()
    {
        Debug.Log("Un saludo para Diego");
    }


}
