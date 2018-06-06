using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBoss : MonoBehaviour
{
    int time;
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform weaponTip;
    public int timeEspera;
    bool nearby;
    int pattern = 1;
    public int countdownStart;
    int countdown;
    public Transform enemyTarget;
    public int triggerDistance = 25;
    // Use this for initialization
    void Start()
    {
        time = 0;
        countdown = countdownStart;
        nearby = false;
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 targetCheck = enemyTarget.position;
        Vector3 temp = transform.position;
        time++;
        EscupirBola();
        nearby = CheckDistance(targetCheck, temp);
        if (nearby == true)
        {
            countdown--;
            if (countdown < 0)
            {
                DestroyObject(this.gameObject);
            }
        }
        else countdown = countdownStart;
    }

    void EscupirBola()
    {
        if (time == timeEspera)
        {
            switch (pattern) {
                case 1:
                    Quaternion rot = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 1);
                    Instantiate(bulletPrefab, weaponTip.position, rot);
                    Instantiate(bulletPrefab, weaponTip.position, rot);
                    Instantiate(bulletPrefab, weaponTip.position, rot);
                    Instantiate(bulletPrefab, weaponTip.position, rot);
                    pattern++;
                    break;
                case 2:
                    Quaternion rot2 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 45);
                    Instantiate(bulletPrefab, weaponTip.position, rot2);
                    Instantiate(bulletPrefab, weaponTip.position, rot2);
                    Instantiate(bulletPrefab, weaponTip.position, rot2);
                    Instantiate(bulletPrefab, weaponTip.position, rot2);
                    pattern++;
                    break;
                case 3:
                    Quaternion rot3 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 90);
                    Instantiate(bulletPrefab, weaponTip.position, rot3);
                    Instantiate(bulletPrefab, weaponTip.position, rot3);
                    Instantiate(bulletPrefab, weaponTip.position, rot3);
                    Instantiate(bulletPrefab, weaponTip.position, rot3);
                    pattern++;
                    break;
                case 4:
                    Quaternion rot4 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 135);
                    Instantiate(bulletPrefab, weaponTip.position, rot4);
                    Instantiate(bulletPrefab, weaponTip.position, rot4);
                    Instantiate(bulletPrefab, weaponTip.position, rot4);
                    Instantiate(bulletPrefab, weaponTip.position, rot4);
                    pattern++;
                    break;
                case 5:
                    Quaternion rot5 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 180);
                    Instantiate(bulletPrefab, weaponTip.position, rot5);
                    Instantiate(bulletPrefab, weaponTip.position, rot5);
                    Instantiate(bulletPrefab, weaponTip.position, rot5);
                    Instantiate(bulletPrefab, weaponTip.position, rot5);
                    pattern++;
                    break;

                case 6:
                    Quaternion rot6 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 225);
                    Instantiate(bulletPrefab, weaponTip.position, rot6);
                    Instantiate(bulletPrefab, weaponTip.position, rot6);
                    Instantiate(bulletPrefab, weaponTip.position, rot6);
                    Instantiate(bulletPrefab, weaponTip.position, rot6);
                    pattern++;
                    break;
                case 7:
                    Quaternion rot7 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 270);
                    Instantiate(bulletPrefab, weaponTip.position, rot7);
                    Instantiate(bulletPrefab, weaponTip.position, rot7);
                    Instantiate(bulletPrefab, weaponTip.position, rot7);
                    Instantiate(bulletPrefab, weaponTip.position, rot7);
                    pattern++;
                    break;
                case 8:
                    Quaternion rot8 = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 315);
                    Instantiate(bulletPrefab, weaponTip.position, rot8);
                    Instantiate(bulletPrefab, weaponTip.position, rot8);
                    Instantiate(bulletPrefab, weaponTip.position, rot8);
                    Instantiate(bulletPrefab, weaponTip.position, rot8);
                    pattern = 1;
                    break;
                
        }
            time = 0;
        }

    }
    bool CheckDistance(Vector3 targetCheck, Vector3 temp)
    {
        float distanceX = targetCheck[0] - temp[0];
        float distanceY = targetCheck[1] - temp[1];
        distanceX = distanceX * distanceX;
        distanceY = distanceY * distanceY;
        float distance = distanceX + distanceY;
        distance = Mathf.Sqrt(distance);
        if (distance > triggerDistance)
            return false;
        else return true;

    }
}
