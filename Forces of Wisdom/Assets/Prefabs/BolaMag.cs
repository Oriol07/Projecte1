using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMag : MonoBehaviour
{
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


    }
}
