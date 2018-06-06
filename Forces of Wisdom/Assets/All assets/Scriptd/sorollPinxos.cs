using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sorollPinxos : MonoBehaviour {

    AudioSource pinxosTrampa;
    public AudioClip AudioPinxoTrampa;
    moviment_trampa_pinxos TrampaPinxos;

    void Awake()
    {
        TrampaPinxos = GetComponentInChildren<moviment_trampa_pinxos>();
        pinxosTrampa = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (TrampaPinxos.activatPerMal == true)
        {
            pinxosTrampa.clip = AudioPinxoTrampa;
            pinxosTrampa.Play();
        }
    }
}
