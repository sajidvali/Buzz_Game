using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class firstani : MonoBehaviour
{
    public Animator a;
    // Use this for initialization
    void Start()
    {
        a = GetComponent<Animator>();
   
        a.Play("Armature|ArmatureAction_002");
    }
    // Update is called once per frame
    void Update()
    {

    }
}