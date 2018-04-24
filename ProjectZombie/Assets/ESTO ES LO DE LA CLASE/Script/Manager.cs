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

       
        int randon_ = Random.Range(1, 5); //zombie
        for (int i = 0; i < randon_; i++)
        {
            Zombie z = new Zombie();
            Debug.Log("Soy un zombie color " + z.Name_color);
        }

        for (int j = 0; j < randon_; j++) //ciudadano
        {
            int rango_edad = Random.Range(15, 100);
            Ciudadanos z = new Ciudadanos();
            Debug.Log("Hola soy " + names[j] + ", y mi edad es " + rango_edad);
        }

      //  for (int k = 0; k < 1; k++) //heroe
     //   {
            Hero h = new Hero();
    //    }

    }

    // Update is called once per frame
    void Update () {
		
	}


}
