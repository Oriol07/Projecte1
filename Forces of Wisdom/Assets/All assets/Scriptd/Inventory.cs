using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public GameObject[] inventory = new GameObject[5];
    public Button[] InventoryButtons = new Button[5];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                InventoryButtons[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                Debug.Log(item.name + "ha sigut afegit");
                itemAdded = true;
                item.SendMessage("DoInteract");
                break;
            }
        }

        if (!itemAdded)
        {
            Debug.Log("inventory Ple - Item no Afegit");
        }

    }

    public GameObject findItemByType(string itemType)
    {
        for (int i = 0; i < inventory.Length; i++)
        {

            if (inventory[i].GetComponent<interactItems>().itemType == itemType)
            {
                return inventory[i];
            }


        }
        return null;
    }
    public void RemoveItem(GameObject item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {

            if (inventory[i] == item)
            {
                inventory[i] = null;
                Debug.Log(item.name + "el item ja no esta al inventari");
                InventoryButtons[i].image.overrideSprite = null;
                break;
            }
        }
    }
}



