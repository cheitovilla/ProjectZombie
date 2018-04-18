using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

    

    int myInt;
    int[] myInts;
    object myObject;
    object[] myObjects;
    public int numBoxes = 10;
    public GameObject[] boxes;
    public float spacing;


	// Use this for initialization
	void Start () {
        boxes = new GameObject[numBoxes];

        for (int i = 0; i < numBoxes; i++)
        {

            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.AddComponent<Monster>();
            Monster m = box.GetComponent<Monster>() as Monster;
            boxes[i] = box;
        }
	}
	
	// Update is called once per frame
	void Update () {
        int i = 0;
       
        foreach (GameObject go in boxes)
        {
            float wave = Mathf.Sin(Time.fixedTime + i);
            go.transform.position = new Vector3(1.0f, 0, 0);
            go.transform.position = new Vector3(i * spacing, wave, 0);
            i++;
            print(i);
        }
	}
}
