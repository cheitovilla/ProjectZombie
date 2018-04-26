using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplos : MonoBehaviour {

    public int i;

	// Use this for initialization
	void Start () {

        if (i ==0)
        {
            Debug.Log("i is zero");
        }
        else if (i == 1)
        {
            Debug.Log("i is one");
        }
        else if (i==2)
        {
            Debug.Log("i is two");
        }
        else if (i == 3)
        {
            Debug.Log("i is three");
        }
        else if (i ==4)
        {
            Debug.Log("i is four");
        }
        else
        {
            Debug.Log("i is greater than 4");
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
