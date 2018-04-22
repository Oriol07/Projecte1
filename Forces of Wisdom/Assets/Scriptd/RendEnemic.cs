using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendEnemic : MonoBehaviour {

    public GameObject PrefabOrc;
    public GameObject PrefabBoss;
    public GameObject PrefabOgro;

    // Use this for initialization


   public void orc()
    {
        Instantiate(PrefabOrc);
    }

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

}
}
