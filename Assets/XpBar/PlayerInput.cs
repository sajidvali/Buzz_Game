 using UnityEngine;
using UnityEngine.UI;


public class PlayerInput : MonoBehaviour
{

    public Slider XpBar;
    public Text scoreText;
    int score;
    int value;
   private void Start()
    {
        XpBar.value = PlayerPrefs.GetInt("value");
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        score = PlayerPrefs.GetInt("score");
    }

    public void UpdateXpBar(int value)
    {
        XpBar.value += value;
        PlayerPrefs.SetInt("value", (int)XpBar.value);

        if (XpBar.value == XpBar.maxValue )
        {
           XpBar.value = XpBar.value - XpBar.value;
            score++;
            scoreText.text = "" + score;
            PlayerPrefs.SetInt("score", score);
           
           //scoreText.text = Text.ToString();
        }
    }
    public void ResthighScore()
    {
        PlayerPrefs.DeleteAll();
        scoreText.text = "0";
        score = 0;
        XpBar.value = 0;
        value = 0;
    }
    
}
