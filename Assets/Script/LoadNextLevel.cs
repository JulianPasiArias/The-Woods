using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{

    public GameObject transition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            transition.SetActive(true);
            Invoke("Load", 1f);
        }    
    }

    void Load()
    {
        SceneManager.LoadScene(3);
    }
}
