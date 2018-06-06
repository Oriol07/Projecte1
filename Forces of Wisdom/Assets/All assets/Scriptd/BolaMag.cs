using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMag : MonoBehaviour
{
    public int velocitat = 10;
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
        if (col.gameObject.tag == "Enemic")
        {
            var hit = col.gameObject;
            var health = hit.GetComponent<BarraVida>();
            if (health != null)
            {
                health.Damage(10);
            }
            if (health == null) Destroy(col.gameObject);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "MAP")
        {
            Object.Destroy(this.gameObject); // M’elimino
        }

    }
}
