using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour {
    private Animator anim;
    bool tmp = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!tmp) { 
        anim.SetTrigger("pot");
            tmp = true;
        }

    }
}
