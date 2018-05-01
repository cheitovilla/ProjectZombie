using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseStruct : MonoBehaviour {

    BoxParameters thatBox;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        thatBox = GameObject.Find("Cube").GetComponent<Cajas>().myParameters;
        transform.position = new Vector3(0, thatBox.height * 0.5f, -10);
	}
}
