using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ZombiParametres {
    public GameObject zombieMesh;
    public Color zombieColor; //3 colores
    public string Gusto;
}

public struct CiudadanoParametres {
    public string ciudadanosName; //20 names
    public int cidadanoEdad; // 15 -100
}


public class Utils : MonoBehaviour {

	// Use this for initialization
	void Start () {

        string[] ciudadanosName = new string[] {
            "Stubbs", "Rob", "White", "Yasuli yamile", "Mohame Ali", "Mohame Aca", "Cuchin", "Clara", "Bladimir", "Trump", "Santos", "Marquez", "Mc Flurry", "Carlos", "Fredi", "Juanda", "Pato", "Mia",
            "Coluchi", "Elkin"
        };


        new Hero();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
