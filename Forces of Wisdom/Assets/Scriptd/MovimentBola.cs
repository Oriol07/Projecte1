using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentBola : MonoBehaviour {

    public int velocitat = 5;
    public float TimeToDestroy = 3f;
    public float MaximumRange = 30;
    int count = 0;
    Event e = Event.current;
    Vector3 Dir = new Vector3();
    Camera cam;
    Transform my;
    Rigidbody2D body;
    TargetEnemy targetEnemy;
    

    void Start()
    {
        cam = Camera.main;
        my = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();
        targetEnemy = GetComponent<TargetEnemy>();
    }
    void Update()
    {

        Vector3 defTarget = new Vector3(velocitat, 0, 0);
        transform.Translate(defTarget);
        count++;
        if (count > MaximumRange)
        {
            count = 0;
            DestroyObject(this.gameObject);
        }

        onEnable();
        /*if (Input.GetMouseButtonDown(0))
        {

            x = Input.GetAxis("Mouse X");
            y = Input.GetAxis("Mouse Y");
        } */
    }

    void onEnable()
    {
        StartCoroutine(AutoDestroy(TimeToDestroy));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MAP")
        {
            Object.Destroy(this.gameObject); // M’elimino
        }
    }
    IEnumerator AutoDestroy(float time)
    {
        yield return new WaitForSeconds(time);

        Destroy(gameObject);
    }


}

