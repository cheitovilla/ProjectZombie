using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie  {

  
    GameObject zombieMesh;
    string name_col;

    //Aquí se construye el zombie
    public Zombie() {
            zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
            zombieMesh.GetComponent<Renderer>().material.color = Colores();
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            zombieMesh.transform.position = pos;
            name_col = zombieMesh.GetComponent<Renderer>().material.color.ToString();
    }
	
    //Aquí se le asigna los colores
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
        set
        {
            name_col = value;
        }
        get
        {
            return name_col;
        }
    }

}
