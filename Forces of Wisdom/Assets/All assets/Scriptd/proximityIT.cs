using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class proximityIT : MonoBehaviour
{
    public Vector2 targetPoint;
    float x = 0;
    float y = 0;
    public float velOrc = 4;
    public int triggerDistance = 40;
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
        if (CheckDistance(targetCheck,temp)) { 
            flagX = true; }
        if (flagX == true)
        {
            if ((Time.time) > timeMove)
            {
                timeMove = (Time.time + 4 / velOrc);
                Vector3 move = new Vector3(x, y, 0);
                if ((temp[0]) - 1 > move[0])
                    transform.Translate(-1, 0, 0);
                else if (temp[0] < (move[0]) - 1)
                    transform.Translate(1, 0, 0);
                if ((temp[1]) - 1 > move[1])
                    transform.Translate(0, -1, 0);
                else if (temp[1] < (move[1]) - 1)
                    transform.Translate(0, 1, 0);


            }

            x = targetCheck[0];
            y = targetCheck[1];
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

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            Destroy(gameObject);
        }

    }


}
