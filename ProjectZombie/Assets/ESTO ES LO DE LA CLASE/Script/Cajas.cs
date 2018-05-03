using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajas : MonoBehaviour {

    public BoxParameters myParameters; 

 


	// Use this for initialization
	void Start () {
        myParameters.width = 20;
        myParameters.height = 30;
        myParameters.depth = 40;
        myParameters.color = new Color(1,0,0,1);
    }
	
	// Update is called once per frame
	void UpdateCube (BoxParameters box) {
        Vector3 size = new Vector3(box.width, box.height, box.depth);
        transform.localScale = size;
        GetComponent<Renderer>().material.color = box.color;
	}

  

}
public struct BoxParameters
{
    public float width;
    public float height;
    public float depth;
    public Color color;
}
