﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform weaponTip;
   
    public float fireRate = 5f;
    public float damage = 25f;
    public LayerMask Objectiu;
    public float range = 100f;
    float x;
    float y;
    float timeFire = 0;
    PlayerControl playerControl;
    TargetEnemy targetEnemy;
	// Use this for initialization
	void Start () {
        playerControl = GetComponent<PlayerControl>();
        targetEnemy = GetComponent<TargetEnemy>();
	}
	public void Atacant(){
        if (fireRate == 0)
        {
            Shoot();
        }
        if (Time.time > timeFire)
        {
            timeFire = Time.time + 1 / fireRate;
            Shoot();
        }
    }

 
    void Shoot()
    {
        Vector2 firepos = new Vector2(weaponTip.position.x, weaponTip.position.y);
        Vector2 dir = new Vector2(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"));
<<<<<<< Updated upstream:Forces of Wisdom/Assets/Scriptd/PlayerAttack.cs
        
=======

>>>>>>> Stashed changes:Forces of Wisdom/Assets/PlayerAttack.cs
        RaycastHit2D hit = Physics2D.Raycast(firepos, dir, range, Objectiu);
        Debug.DrawRay(firepos, dir * range, Color.blue, 1f);
        DrawBola();
       

    }

	// Update is called once per frame
	void Update () {
     /*   x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y"); */
    }
    void DrawBola()
    {
<<<<<<< Updated upstream:Forces of Wisdom/Assets/Scriptd/PlayerAttack.cs
        if (Input.GetKeyDown("F")){ 
        Quaternion rot = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 1);
        Instantiate(bulletPrefab, weaponTip.position, rot);
        //Instantiate(bulletPrefab, weaponTip.position, rot);
    }
=======
     
            Quaternion rot = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 1);
            Instantiate(bulletPrefab, weaponTip.position, rot);
            //Instantiate(bulletPrefab, weaponTip.position, rot);
>>>>>>> Stashed changes:Forces of Wisdom/Assets/PlayerAttack.cs
        
    }

   
}
