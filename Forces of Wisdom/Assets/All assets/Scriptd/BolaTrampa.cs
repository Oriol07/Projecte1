using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaTrampa : MonoBehaviour
{

    public float velocitat = 0.5f;
    public float TimeToDestroy = 3f;
    int count = 0;

    // Update is called once per frame
    void Update()
    {
        Vector3 defTarget = new Vector3(velocitat, 0, 0);
        transform.Translate(defTarget);
        count++;
        if (count > 100)
        {
            DestroyObject(this);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            var hit = col.gameObject;
            var health = hit.GetComponent<BarraVida>();
            if (health != null)
            {
                health.Damage(20);
            }
            if (health == null)
            {
                Destroy(col.gameObject);
                Destroy(gameObject);
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            }


        }
        if (col.gameObject.tag == "MAP")
        {
            Object.Destroy(this.gameObject); // M’elimino
        }

    }
}
