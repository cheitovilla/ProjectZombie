using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie  {

  
    GameObject zombieMesh;
    string name_col;

    public Zombie(int clase) {

        if (clase == 0) // zombies
        {
            zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombieMesh.GetComponent<Renderer>().material.color = Colores();
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            zombieMesh.transform.position = pos;
            name_col = zombieMesh.GetComponent<Renderer>().material.color.ToString();
        }
        if (clase == 1) //Humanos
        {
            zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombieMesh.GetComponent<Renderer>().material.color = Color.white;
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            zombieMesh.transform.position = pos;
            name_col = zombieMesh.GetComponent<Renderer>().material.color.ToString();
        }
        if (clase ==2)
        {
            zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            zombieMesh.GetComponent<Renderer>().material.color = Color.black;
            Vector3 pos = new Vector3(0, 0, 0);
            zombieMesh.transform.position = pos;
            zombieMesh.AddComponent<FPSMove>();
            zombieMesh.AddComponent<FPSAim>();
            zombieMesh.AddComponent<Camera>();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    Color Colores()
    {
        int col = Random.Range(0, 3);
        if (col == 0)
        {
            return Color.cyan;
        }
        if (col == 1)
        {
            return Color.green;
        }
        if (col == 2)
        {
            return Color.magenta;
        }
        return Color.gray;
    }

    public string Name_color
    {
        set{
            name_col = value;
        }
        get{
            return name_col;
        }
    }


}
