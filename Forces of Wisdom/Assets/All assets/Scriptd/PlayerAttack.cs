using System.Collections;
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
    int angle;
    float x;
    float y;
    float timeFire = 0;
    PlayerControl playerControl;
    TargetEnemy targetEnemy;
	// Use this for initialization
	void Start () {
        angle = 1;
        playerControl = GetComponent<PlayerControl>();
        targetEnemy = GetComponent<TargetEnemy>();
	}



	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            angle = 90;
        if (Input.GetKey(KeyCode.D))
            angle = 1;
        if (Input.GetKey(KeyCode.A))
            angle = 150;
        if (Input.GetKey(KeyCode.S))
            angle = 270;

        if (fireRate == 0)
        {

            DrawBola();
        }
        if (Time.time > timeFire)
        {

            DrawBola();
            timeFire = Time.time + 1 / fireRate;
        }
    }
    void DrawBola()
    {
        if (Input.GetKey(KeyCode.K))
        { 
        Quaternion rot = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), angle);
        Instantiate(bulletPrefab, weaponTip.position, rot);
    }
        
    }

   
}
