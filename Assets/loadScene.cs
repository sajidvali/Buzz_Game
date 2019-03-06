using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour { 
        public void scroll ()
        {
            SceneManager.LoadScene("startGame");
        }

    public void help ()
    {
        SceneManager.LoadScene("levels");
    }
    public void goToAbout() {
        SceneManager.LoadScene("about");
    }
    public void backToMainScene() {
        SceneManager.LoadScene("startGame");
    }
    public void optionScene() {
        SceneManager.LoadScene("options");
    }
    public void toGame() {
        //SceneManager.LoadScene("camAddedScene");
        SceneManager.LoadScene("gamePlay");
    }
}
