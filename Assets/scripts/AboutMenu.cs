using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void callFacebook()
    {
        Application.OpenURL(@"googlechrome://https://www.facebook.com/walkpathstudious");
    }
    public void callTwitter()
    {
        Application.OpenURL(@"googlechrome://https://www.twitter.com/walkpath1");
    }
    public void callInstagram()
    {
        Application.OpenURL(@"googlechrome://http://instagram.com");
    }
    public void callPlaystore()
    {
        Application.OpenURL(@"googlechrome://playstore.com");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
