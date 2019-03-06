using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secAni : MonoBehaviour {
    public Animator a;
	// Use this for initialization
	void Start () {
        a = GetComponent<Animator>();
	}
    public void playAn() {
        a.Play("Armature|ArmatureAction_002");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
