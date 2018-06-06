using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour {
        Rigidbody2D rb2d;
        public float velocitat;
     Vector2 mov;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        mov = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
 
       
    }
    void FixedUpdate ()
    {
        rb2d.MovePosition(rb2d.position + mov * velocitat * Time.deltaTime);
    }
   
}