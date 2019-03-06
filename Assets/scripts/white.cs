using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class white : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
    public void whiteMov() {
        anim.Play("Armature|ArmatureAction");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
