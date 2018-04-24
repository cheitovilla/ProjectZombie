using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadanos  {

    GameObject ciudadanoMesh;
    string name_col;

    //Aquí se construyen los ciudadanos
    public Ciudadanos() {
        ciudadanoMesh = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ciudadanoMesh.GetComponent<Renderer>().material.color = Color.white;
        Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        ciudadanoMesh.transform.position = pos;
        name_col = ciudadanoMesh.GetComponent<Renderer>().material.color.ToString();
    }


   


}
