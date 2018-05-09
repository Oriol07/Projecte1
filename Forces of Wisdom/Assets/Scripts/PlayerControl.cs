using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour {
        Rigidbody2D rb2d;
        public float velocitat;
     Vector2 mov;
    private PlayerAttack playerAttack;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        playerAttack = GetComponent<PlayerAttack>();
	}
	
	// Update is called once per frame
	void Update () {
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            );
        if (Input.GetMouseButtonDown(0) && playerAttack.fireRate == 0){
            playerAttack.Atacant();
        }
        if (Input.GetMouseButton(0) && playerAttack.fireRate > 0)
        {
            playerAttack.Atacant();
        }
        else
        {

        }
 
        /*
        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + mov,
            velocit * Time.deltaTime
            );
/*
        if (Input.GetKey(KeyCode.W))
            moviment.AddForce(new Vector2(0, 1) * velocitat);
        if (Input.GetKey(KeyCode.D))
            moviment.AddForce(new Vector2(1, 0) * velocitat);
        if (Input.GetKey(KeyCode.A))
            moviment.AddForce(new Vector2(-1, 0) * velocitat);
        if (Input.GetKey(KeyCode.S))
            moviment.AddForce(new Vector2(0, -1) * velocitat);
            */
    }
    void FixedUpdate ()
    {
        rb2d.MovePosition(rb2d.position + mov * velocitat * Time.deltaTime);
    }
   
}