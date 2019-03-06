using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public void changeScene() {
        SceneManager.LoadScene("House");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
