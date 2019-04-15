using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour {

    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.Space)) {
            anim.SetBool("Go", true);
        }

        Debug.Log(anim.GetBool("Go"));
	}

    public void resetGo() {
        anim.SetBool("Go", false);
    }
}
