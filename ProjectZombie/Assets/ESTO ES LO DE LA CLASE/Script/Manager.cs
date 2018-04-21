using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

   

    // Use this for initialization
    void Start () {
        string[] names = new string[] {
            "stubbs",
            "rob",
            "white"
        };



        int randon_zombies = Random.Range(5, 10);
        for (int i = 0; i < randon_zombies; i++)
        {
            Zombie z = new Zombie(0);
            Debug.Log("Soy un zombie color " + z.Name_color);
        }

        

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Heroe() {
       
    }

    

}
