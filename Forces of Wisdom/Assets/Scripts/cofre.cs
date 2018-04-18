using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cofre : MonoBehaviour {
    public string tagName;
    public GameObject[] objects;
    public Transform spawnPoint;
    private bool chestOpened;

	
	void OntriggerEnter (Collider col) {
        if (col.gameObject.tag == tagName && !chestOpened)
            OpenChest();
	}
	
	
	void OpenChest () {
        chestOpened = true;
        GameObject item = Instantiate(objects[Random.Range(0, objects.Length)]), spawnPoint.position, spawnPoint.rotation)as GameObject;
	}
}
