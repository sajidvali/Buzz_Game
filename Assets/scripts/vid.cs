using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vid : MonoBehaviour {
    public GameObject abcUI;
    public void change() {
        SceneManager.LoadScene("game");
    }
	// Use this for initialization
	void Start () {
        Invoke("change",36);
        Invoke("skip",10);
	}
    void skip() {
        abcUI.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
