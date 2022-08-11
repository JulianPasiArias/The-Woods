using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerObjeto : MonoBehaviour
{
    [SerializeField] private GameObject sprite;

    public void DesactivarObjeto()
    {
        sprite.SetActive(false);
    }

    public void Saludo()
    {
        Debug.Log("Hola mundo");
    }

    public void Despedida()
    {
        Debug.Log("Adios mundo");
    }
}
