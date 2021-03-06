﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocheController : MonoBehaviour {

    float velocidad = 25f;
    public KeyCode Derecha = KeyCode.D;
    public KeyCode Izquierda = KeyCode.A;
    public Text ganador;
    public string Nombre;
    public GameObject Victoria;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(Derecha))
        {
            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(Izquierda))
        {
            this.transform.Translate(-velocidad * Time.deltaTime, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Victoria.SetActive(true);
        ganador.text = Nombre;
        Time.timeScale = 0;
    }

}

