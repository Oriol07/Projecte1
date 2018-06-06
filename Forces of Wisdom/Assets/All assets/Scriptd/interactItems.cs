using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactItems : MonoBehaviour {

    public bool inventory;
    public string itemType;

	public void DoInteract()
    {
        gameObject.SetActive(false);
    }
}
