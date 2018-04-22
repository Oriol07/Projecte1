using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    int waypoint = 0;
    float xB = 70;
    float yB = 40;
    float x = 0;
    float y = 0;
    public float velOrc = 4;
    public int triggerDistance = 15;
    bool flagY = false;
    bool flagX = false;
    public Transform enemyTarget;
    float timeMove = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetCheck = enemyTarget.position;
        Vector3 temp = transform.position;
        if ((Time.time) > timeMove)
        {
            timeMove = (Time.time + 4 / velOrc);
            Vector3 move = new Vector3(xB + x, yB + y, 0);
            if ((temp[0]) - 1 > move[0])
                transform.Translate(-1, 0, 0);
            else if (temp[0] < (move[0]) - 1)
                transform.Translate(1, 0, 0);
            else flagX = true;
            if ((temp[1]) - 1 > move[1])
                transform.Translate(0, -1, 0);
            else if (temp[1] < (move[1]) - 1)
                transform.Translate(0, 1, 0);
            else flagY = true;


        }
        bool targetFlag = CheckDistance(targetCheck, temp);
        if (targetFlag == true)
            waypoint = -1;
        if ((flagX == true) && (flagY == true) && (waypoint != -1))
        {
            flagX = false;
            flagY = false;
            waypoint++;
            if (waypoint > 11)
                waypoint = 0;
        }

        switch (waypoint)
        {
            case -1:
                x = targetCheck[0];
                y = targetCheck[1];
                break;
            case 1:
                x = -15;
                y = 0;
                break;

            case 2:
                x = -48;
                y = 0;
                break;

            case 3:
                x = -50;
                y = 15;
                break;

            case 4:
                x = -60;
                y = 30;
                break;

            case 5:
                x = -50;
                y = 42;
                break;

            case 6:
                x = -60;
                y = 42;
                break;

            case 7:
                x = -60;
                y = 10;
                break;

            case 8:
                x = -50;
                y = 10;
                break;

            case 9:
                x = -45;
                y = 0;
                break;

            case 10:
                x = -45;
                y = -30;
                break;

            case 11:
                x = -15;
                y = -30;
                break;


            default:
                x = 0;
                y = 0;
                break;
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
