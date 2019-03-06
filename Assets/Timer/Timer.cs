using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using unityEngine.TextMeshProUGUI;

public class Timer : MonoBehaviour
{
    Image fillImg;
    float timeAmt = 5;
    public static float time;
    public Text timeText;
    //  public TextMeshPro timeText;
    // Use this for initialization
    public static void resetTimer() {
        time = 5;
    }
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = timeAmt;
        // print(time);
    }
    public  void timeUp()
    {
        while (time >= 0)
        {
            // if (time >= 0)
            //{
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
            timeText.text = time.ToString("F0");
            //print(Time.deltaTime);
            //}
        }
    }
    // Update is called once per frame
    //public static void resetTimer()
    //{
    //    time = 5f;
    //    // Debug.Log("reset");
    //}
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
            timeText.text = time.ToString("F0");
            // print(time);
        }
    }
}
