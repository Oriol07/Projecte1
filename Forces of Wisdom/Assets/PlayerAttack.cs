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
    float x;
    float y;
    float timeFire = 0;
    PlayerControl playerControl;

	// Use this for initialization
	void Start () {
        playerControl = GetComponent<PlayerControl>();

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
        Vector2 dir = new Vector2(x, y);

        RaycastHit2D hit = Physics2D.Raycast(firepos, dir, range, Objectiu);
        Debug.DrawRay(firepos, dir * range, Color.blue, 1f);
        DrawBola();

    }
	// Update is called once per frame
	void Update () {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
    }
    void DrawBola()
    {
        Quaternion rot = Quaternion.Euler(x, y, 1);
        Instantiate(bulletPrefab, weaponTip.position, rot);
    }

   
}
