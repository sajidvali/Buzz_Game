using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject gameplayUI;
    public void check() {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Debug.Log("Game paused");
            Pause();
        }
    }
    //update is called once per frame
	void Update ()
    { 
		
	}

public void Resume()
{
    gameplayUI.SetActive(false);
    Time.timeScale = 1f;
        GameIsPaused = false;
}
public void Pause()
{
    gameplayUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;

}
public void LoadMenu()
{
    Time.timeScale = 1f;
   // SceneManager.LoadScene("startScene");

}
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}