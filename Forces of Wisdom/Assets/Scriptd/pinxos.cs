using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinxos : MonoBehaviour {

    private PlayerControl playerControl;
    private PlayerAttack playerAttack;
    Collider2D pinxoscol;

	void Start () {
        pinxoscol = this.GetComponent<Collider2D>();

	}
	
	
	void Update () {
		
	}

    public void pinxosOn()
    {
        pinxoscol.enabled = true;

    }
    public void pinxos0ff()
    {
        pinxoscol.enabled = false;
    }
    void OntriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
