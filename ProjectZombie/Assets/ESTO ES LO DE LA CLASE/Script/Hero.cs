using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero  {

    GameObject heroeMesh;

    public Hero() {


            heroeMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            heroeMesh.GetComponent<Renderer>().material.color = Color.black;
            Vector3 pos = new Vector3(0, 0, 0);
            heroeMesh.transform.position = pos;
            heroeMesh.AddComponent<FPSMove>();
            heroeMesh.AddComponent<FPSAim>();
            heroeMesh.AddComponent<Camera>();
        

    }



}
