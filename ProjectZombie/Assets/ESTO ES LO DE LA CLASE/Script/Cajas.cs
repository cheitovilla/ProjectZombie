using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cajas : MonoBehaviour {

    public BoxParameters myParameters; //pag 39

 


	// Use this for initialization
	void Start () {
        myParameters.width = 2;
        myParameters.height = 3;
        myParameters.depth = 4;
        myParameters.color = new Color(1,0,0,1);
    }
	
	// Update is called once per frame
	void UpdateCube (BoxParameters box) {
        Vector3 size = new Vector3(box.width, box.height, box.depth);
        transform.localScale = size;
        GetComponent<Renderer>().material.color = box.color;
	}

    void Update() {
        float h = (100 * Mathf.Sin(Time.fixedDeltaTime)) / 10;
        myParameters.height = h;
        UpdateCube(myParameters);
    }

}
public struct BoxParameters
{
    public float width;
    public float height;
    public float depth;
    public Color color;
}
