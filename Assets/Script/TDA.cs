using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDA : MonoBehaviour
{
   public List<SpriteRenderer> sprites;
    
   public SpriteRenderer nuevoSprite;

   public GameObject[] objetos;

   public Stack imagenes = new Stack();


    void Start()
    {
        imagenes.Push("imagen1");
        imagenes.Push("imagen2");
        imagenes.Push("imagen3");
        imagenes.Push("imagen4");

        Debug.Log(imagenes.Pop());
  
        objetos[2].SetActive(false);

        RecorrerObjetosInversa();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sprites.Add(nuevoSprite);
        }

        RecorrerObjetos();
    }

    void RecorrerObjetos()
    {
        
        
        foreach(GameObject sprite in objetos)
        {
            imagenes.Push(sprite);
            sprite.transform.localPosition = new Vector2(2f,2f);
        }

       
    }   

    void RecorrerObjetosInversa()
    {
        for (int i = objetos.Length; i >= 0 ; i--)
        {
            Debug.Log(i);
        }
    }



    
    
}
