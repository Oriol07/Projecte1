using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canviNivell : MonoBehaviour
{
    public string NomScene;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(NomScene, LoadSceneMode.Single);

        }
    }
}
