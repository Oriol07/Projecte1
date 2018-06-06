using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorollDisparar : MonoBehaviour {

    AudioSource armaOgro;
    public AudioClip AudioArmaOgro;
    IAogro ArmaEnemiga;
	
	void Awake () {
        ArmaEnemiga = GetComponentInChildren<IAogro>();
        armaOgro = GetComponent<AudioSource>();
	}
	

	void Update () {
		if (ArmaEnemiga.SorollDisparar == true)
        {
            armaOgro.clip = AudioArmaOgro;
            armaOgro.Play();
        }
	}
}
