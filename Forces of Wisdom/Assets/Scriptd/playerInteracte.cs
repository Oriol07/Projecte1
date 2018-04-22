using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteracte : MonoBehaviour {

    public GameObject currentinterItem = null;
    public interactItems currentinteractItemsScript = null;
    public Inventory inventory;

    void Update()
    {
        if(Input.GetButtonDown("Interact")&& currentinterItem)
        {
            if (currentinteractItemsScript.inventory)
            {
                inventory.AddItem(currentinterItem);
            }
            currentinterItem.SendMessage("DoInteract");
        }
        if (Input.GetButtonDown("use potion"))
        {
            GameObject pocio_mag = inventory.findItemByType("habilitat mag");
            if(pocio_mag != null)
            {
                //us de la pocio + aplicar efecte
            }
        }
        if (Input.GetButtonDown("use potion"))
        {
            GameObject pocio_caballer = inventory.findItemByType("habilitat caballer");
            if (pocio_caballer != null)
            {
                //us de la pocio + aplicar efecte
            }
        }
        if (Input.GetButtonDown("use potion"))
        {
            GameObject pocio_lladre = inventory.findItemByType("habilitat lladre");
            if (pocio_lladre != null)
            {
                //us de la pocio + aplicar efecte
            }
        }
    }

    void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag("interactItem"))
        {
            Debug.Log(other.name);
            currentinterItem = other.gameObject;
            currentinteractItemsScript = currentinterItem.GetComponent<interactItems>();
            
        }
	}

     void OnTriggerExit2D(Collider2D other)
    {
       if (other.CompareTag("interactItem"))
        {
            if (other.CompareTag("interactItem"))
            {
                currentinterItem = null;
            }
          
        }
    }

}
