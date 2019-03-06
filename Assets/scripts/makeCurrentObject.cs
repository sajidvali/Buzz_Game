using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeCurrentObject : MonoBehaviour {
    Button b = null;
    public static int current;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick1()
    {
        int.TryParse(gameObject.name, out current);
        Debug.Log("button number " + gameObject.name);
        GameObject obj = GameObject.FindWithTag("buttonScript");//scroll rect snap owner or whatever
        ScrollRectSnap_CS cs = obj.GetComponent<ScrollRectSnap_CS>();
        cs.currentObject = this.b;//gameObject
        Debug.Log("Pressed button "+current);

    }
}
