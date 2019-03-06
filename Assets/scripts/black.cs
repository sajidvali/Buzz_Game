using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class black : MonoBehaviour {
    public Animator anin;
	// Use this for initialization
	void Start () {
        anin = GetComponent<Animator>();
	}
    public void firstMov() {
        anin.Play("Armature|ArmatureAction_002");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
