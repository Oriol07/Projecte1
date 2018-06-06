using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguiCam : MonoBehaviour {

    public Transform objectiu;
    public float suavizado = 5f;
    Vector3 desface;
    // Use this for initialization
    void Start()
    {
        desface = transform.position - objectiu.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 positionObjectiu = objectiu.position + desface;
        transform.position = Vector3.Lerp(transform.position, positionObjectiu, suavizado * Time.deltaTime);
    }
}
