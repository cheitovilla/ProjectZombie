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

       //Aqui se llaman a los zombies
        int randon_ = Random.Range(5,10); 
        for (int i = 0; i < randon_; i++)
        {
            Zombie z = new Zombie();
            Debug.Log("Soy un zombie color " + z.Name_color);

            int rango_edad = Random.Range(15, 100);
            Ciudadanos c = new Ciudadanos();
            Debug.Log("Hola soy " + names[i] + ", y mi edad es " + rango_edad);
        }

        //Aqui se crean los ciudadanos
        //for (int j = 0; j < randon_; j++) 
        //{
        //    int rango_edad = Random.Range(15, 100);
        //    Ciudadanos z = new Ciudadanos();
        //    Debug.Log("Hola soy " + names[j] + ", y mi edad es " + rango_edad);
        //}

        //Aquí se llama al heroe
        Hero h = new Hero();
    

    }

}
