using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAogro : MonoBehaviour {
    int time;
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform weaponTip;
    public int timeEspera;
    public bool SorollDisparar;

    // Use this for initialization
    void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time++;
        EscupirBola();
	}

    void EscupirBola()
    {
        if (time == timeEspera)
        {
            Quaternion rot = Quaternion.Euler(Input.GetAxisRaw("HorizontalShoot"), Input.GetAxisRaw("VerticalShoot"), 1);
            Instantiate(bulletPrefab, weaponTip.position, rot);
            time = 0;
            SorollDisparar = true;
        }
        else
        {
            SorollDisparar = false;
        }

    }
}
