using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moviment_trampa_pinxos : MonoBehaviour
{
    int segons;
    int contador;
    private Animator animator;
    private Collider2D trampa;
    public bool activatPerMal;


    void Start()
    {
        animator = GetComponent<Animator>();
        trampa = GetComponent<Collider2D>();
        trampa.isTrigger = false;
    }


    void Update()
    {
        contador++;
        if (contador == 35)
        {
            contador = 0;
            segons++;
        }
        if (segons < 5)
        {
            animator.SetBool("activat", true);
            activatPerMal = true;
            trampa.isTrigger = true;

        }
        if (segons > 5)
        {
            if (segons == 10) { segons = 0; }
            animator.SetBool("activat", false);
            activatPerMal = false;
            trampa.isTrigger = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        //if (activatPerMal)
        
            if (col.gameObject.tag == "Player")
            {
                var hit = col.gameObject;
                var health = hit.GetComponent<BarraVida>();

                if (health != null)
                {
                    health.Damage(10);
                }
                if (health == null)
                {
                    Destroy(col.gameObject);
                    Destroy(gameObject);
                }
            }
        
    }
}