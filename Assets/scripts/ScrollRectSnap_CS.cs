using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
//using exp;
public class ScrollRectSnap_CS : MonoBehaviour
{
    //int [] array = new int[] {1,2,3,4,5,6,7,8};
    // readonly string[] s = new string[] {"John","jhon"};
    // private int temp=0;
    //public RectTransform gamepanel;// To hold the ScrolPanel
    public Button[] bttn;
    public Text[] t;
    public Button currentObject;
    public int multiple = 1;
    int buttonIndex, track = 1, warning = 0;
    int max = 8;
    public Animator sec;
    //public Timer tim;
    public Text game;
    public Text warn;
    //public sendValue sm;
    //PlayerInput pi;
    public void setValue()
    {

        buttonIndex = makeCurrentObject.current;
        Debug.Log("button no. " + buttonIndex + "Button text:" + t[buttonIndex].text);
        onClick();
    }

    public static Text[] shuffleText(Text[] A)
    {
        //Debug.Log("in Shuffle");
        //Random rnd = ThreadLocalRandom.current();
        System.Random rnd = new System.Random();
        for (int i = A.Length - 1; i > 0; i--)
        {
            int ind = rnd.Next(i + 1);
            string a = A[ind].text;
            A[ind].text = A[i].text;
            A[i].text = a;

            //  Debug.Log(A[i].text);
        }

        return A;
    }
    public void Begin()
    {
        t = shuffleText(t);
        // Debug.Log("In begin multiple "+multiple);
        //for (int i = 0; i < 10; i++)
        //    Debug.Log("button no. "+i+" Button value "+t[i].text);
        track = 1;
        warning = 0;
        Time.timeScale = 1;
    }
    //when k is even, pc should select correct button.
    //search k value
    private int findElement(Text[] A, int k)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i].text == k.ToString())
            {
                return i;
            }
        }
        return -1;
    }
    void Start()
    {
        // sec = GetComponent<Animator>();

        // sm = GameObject.Find("temp").GetComponent<sendValue>();
        // multiple = sm.value;
        //  Debug.Log("tadaaa   "+multiple);
        Begin();
    }
    private void gameOver()
    {

        //game.text = "GAME OVER";
        //SceneManager.LoadScene("gameOver");
        GameObject.FindWithTag("rest").SetActive(true);
        Debug.Log("You Lose");
        Time.timeScale = 0;
    }
    private void showWarning()
    {
        Debug.Log("mistake " + warning);
        warn.text = "Warning " + (warning);
    }
    //void play() {
    //    first.Play("Armature|ArmatureAction_002");
    //}
    void pc()
    {

        if (track % 2 == 0)
        {
            Debug.Log("In pc logic");
            sec.Play("Armature|ArmatureAction_002");
            int pos = findElement(t, track);
            t[pos].text = "" + (track + max);
            game.text = "" + track;
            track++;
            Timer.resetTimer();
            t = shuffleText(t);
        }
        // Invoke("play",1);
    }
    private void onClick()
    {
        int buttonValue = 1;
        try
        {
            int.TryParse(t[buttonIndex].text, out buttonValue);
            //Debug.Log("button text "+ t[buttonIndex].text);
            Debug.Log("In try Value is " + buttonValue);
            if (buttonValue == 0)
            {
                //same for both the players
                if ((track) % multiple == 0)
                {
                    // Debug.Log("In TEXT if part");
                    int pos = findElement(t, track);
                    // Debug.Log("pos " + pos);
                    game.text = "" + track;
                    t[pos].text = "" + (track + max);
                    track++;
                   // PlayerInput.UpdateXpBar(3);
                    t = shuffleText(t);
                    //pi.UpdateXpBar();
                }
                else
                {
                    // Debug.Log("In Catch else part");
                    warning++;
                    // Debug.Log("From  try");
                    showWarning();
                    if (warning == 3)
                        gameOver();
                }
            }
            else
            {
                checkPlayer(buttonValue);
            }
            System.Random rnd = new System.Random();
            Invoke("pc", rnd.Next(1, 3));
        }
        catch { }


    }
    public void checkPlayer(int buttonValue)
    {
        // Debug.Log(t[buttonIndex].text, t[buttonIndex].gameObject);
        // Debug.Log("In player logic");
        //sec.Play("Armature|ArmatureAction_002");
        if (buttonValue % multiple == 0 && buttonValue == track)
        {
            // Debug.Log("from last ...track and warning" + track);
            warning++;

            showWarning();
            if (warning == 3)
                gameOver();
        }
        else if (buttonValue == track && track % multiple != 0)
        {
            t[buttonIndex].text = "" + (track + max);
            game.text = "" + track;
            track++;
            //tim.time = 5;
            //Debug.Log("time " + tim.time);
            t = shuffleText(t);
            Debug.Log("track " + track);
            //exp.PlayerInput.UpdateXpBar(3);
            // pi.UpdateXpBar();
        }
        else
        {
            Debug.Log("clicked on wrong value " + t[buttonIndex].text);
            warning++;
            showWarning();
            if (warning == 3)
                gameOver();

        }
    }
    void Update()
    {

    }
}
