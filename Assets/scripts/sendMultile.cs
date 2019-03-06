using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sendMultile : MonoBehaviour {
    public Text t;
    public int textValue;
    //public sendValue tm;
	// Use this for initialization
	void Start () {
        //tm = GameObject.Find("temp").GetComponent<sendValue>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick2()
    {
        int.TryParse(t.text, out textValue);
        GameObject obj = GameObject.FindWithTag("buttonScript");//scroll rect snap owner or whatever
        ScrollRectSnap_CS cs = obj.GetComponent<ScrollRectSnap_CS>();
        cs.multiple = textValue;//gameObject
       // Debug.Log("Multiple = "+textValue);
       // tm.value = textValue;
    }
}
