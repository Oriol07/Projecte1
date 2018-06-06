using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofre : MonoBehaviour {
    public string tagName;
    public GameObject[] objects;
    public Transform spawnPoint;
    private bool chestOpened;

	
	void OntriggerEnter2D (Collider2D col) {
        if (col.gameObject.tag == tagName && !chestOpened)
            OpenChest();
	}
	
	
	void OpenChest () {
        chestOpened = true;
        GameObject item = Instantiate(objects[Random.Range(0, objects.Length)]) as GameObject;
    }
}
