using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentBola : MonoBehaviour {

    public int velocitat = 5;
    public float TimeToDestroy = 3f;
    Event e = Event.current;
    Vector2 mousePos = new Vector2();
    Vector3 Dir = new Vector3();
    Camera cam;
    Transform my;
    Rigidbody2D body;

    void Start()
    {
        cam = Camera.main;
        my = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        
        transform.Translate(mouse * Time.deltaTime * velocitat, Camera.main.transform); // no segueix camera


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

