using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CocheRojoController : MonoBehaviour {

    float velocidad = 25f;
    public KeyCode Tecla_derecha = KeyCode.A;
    public Text ganador;
    public string Nombre;
    public GameObject Victoria;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown("a"))
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
