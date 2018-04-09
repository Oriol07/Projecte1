using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMag : MonoBehaviour
{
    public int velocitat = 100;
    public float TimeToDestroy = 3f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocitat);
    }
    void onEnable()
    {
        StartCoroutine_Auto(AutoDestroy(TimeToDestroy));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MAP")
        {
            Object.Destroy(this.gameObject); // M’elimino
        }
    } 
    IEnumerator AutoDestroy (float time)
    {
        yield return new WaitForSeconds(time);

        Destroy(gameObject);
    }
}