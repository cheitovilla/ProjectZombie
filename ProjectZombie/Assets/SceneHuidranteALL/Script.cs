using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Desarmar(){
        anim.SetTrigger("desarma");
    }

    public void Volver() {
        anim.SetTrigger("idle");
    }

    public void Desmontar() {
        anim.SetTrigger("desmontar");
    }
}
