using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {


    // Use this for initialization
    void Start () {
        string[] names = new string[] {
            "Stubbs", "Rob", "White", "Yasuli yamile", "Mohame Ali", "Mohame Aca", "Cuchin", "Clara", "Bladimir", "Trump", "Santos", "Marquez", "Mc Flurry", "Carlos", "Fredi", "Juanda", "Pato", "Mia",
            "Coluchi", "Elkin"
        };

       
        int randon_zombies = Random.Range(5, 10);
        for (int i = 0; i < randon_zombies; i++)
        {
            Zombie z = new Zombie(0);
            Debug.Log("Soy un zombie color " + z.Name_color);
        }

        for (int j = 0; j < names.Length; j++)
        {
            int rango_edad = Random.Range(15, 100);
            Zombie z = new Zombie(1);
            Debug.Log("Hola soy " + names[j] + ", y mi edad es " + rango_edad);
        }

        for (int k = 0; k < 1; k++)
        {
            Zombie z = new Zombie(2);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}


}
