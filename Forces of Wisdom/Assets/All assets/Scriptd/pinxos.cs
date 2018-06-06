using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinxos : MonoBehaviour {

   
    private PlayerAttack playerAttack;
    public GameObject trampa;
    Collider2D pinxoscol;
    float timeMove = 0;

    void Start () {
        pinxoscol = this.GetComponent<Collider2D>();

	}
	
	
	void Update () {
        if ((Time.time) > timeMove)
        {
            timeMove = (Time.time + 4);
            if (pinxoscol.enabled == true)
            {
                pinxosOff();
            }
            else
            {
                pinxosOn();
            }
        }
	}

    void pinxosOn()
    {
        pinxoscol.enabled = true;

    }
    void pinxosOff()
    {
        pinxoscol.enabled = false;
    }
    void OntriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
