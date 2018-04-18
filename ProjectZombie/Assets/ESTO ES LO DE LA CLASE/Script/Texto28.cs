using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto28 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    Vector3 pos = Vector3.zero;
	// Update is called once per frame
	void Update () {
        bool Akey = Input.GetKey(KeyCode.A);
        bool Skey = Input.GetKey(KeyCode.S);
        bool DKey = Input.GetKey(KeyCode.D);
        bool WKey = Input.GetKey(KeyCode.W);

        transform.position = pos;

        if (Akey)
        {
            pos.x = pos.x - 0.1f;
        }
        if (DKey)
        {
            pos.x = pos.x + 0.1f;
        }
        if (WKey)
        {
            pos.z = pos.z + 0.1f;
        }
        if (Skey)
        {
            pos.z = pos.z - 0.1f;
        }
        transform.position = pos;
	}
}
