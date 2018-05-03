using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {


    // Use this for initialization
    void Start () {

        //Los nombres al randon para los nombres de los ciudadanos
        string[] names = new string[] {
            "Stubbs", "Rob", "White", "Yasuli yamile", "Mohame Ali", "Mohame Aca", "Cuchin", "Clara", "Bladimir", "Trump", "Santos", "Marquez", "Mc Flurry", "Carlos", "Fredi", "Juanda", "Pato", "Mia",
            "Coluchi", "Elkin"
        };

        // la cantidad que van aparecer 
        int randon_ = Random.Range(10,20); 

        //se crea el hereo
        new Hero();

        //Acá se crean los zombies y los ciudadanos
        for (int i = 1; i < randon_; i++)
        {
            int ale = Random.Range(1, 3);
     
            if (ale ==1)
            {
                Zombie z = new Zombie();
                Debug.Log("Soy un zombie color " + z.Name_color);
            }
           else
            {
                int rango_edad = Random.Range(15, 100);
                new Ciudadanos();
                Debug.Log("Hola soy " + names[i] + ", y mi edad es " + rango_edad);
            }   
        }
    }

}
