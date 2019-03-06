using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camScript : MonoBehaviour {
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void cameraMov()
    {
        anim.Play("camMove");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
