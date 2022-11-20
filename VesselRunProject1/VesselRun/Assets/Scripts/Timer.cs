using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timestart = 60.0f; //time we will count down from, changes incriment in update 

    //UI Selection
    public TextMeshProUGUI timer;
    [SerializeField] TextMeshProUGUI YouWIn;
    [SerializeField] TextMeshProUGUI Restartui;

    //FLag for that toggles a bool in asteroids that stops spawing after the player has won.
    public static bool StopAteroidsFlag = false;

    //Audio SFX and Source
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip youwin;

    //select audio source
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    //Sets Ui and Timer tostring
    void Start()
    {
        Restartui.enabled = false;
        YouWIn.enabled = false;
        timer.enabled = true;
        timer.text = timestart.ToString();
    }


    void Update()
    {
        //Debug.Log(timestart);
        //When you win the timer will no longer display
        //sets all ui to win conditions
        //if the timer runs out a win has occured
        if(timestart <= 0.0f)
        {
            StopAteroidsFlag = true;
            YouWIn.enabled = true;
            audio.PlayOneShot(youwin);
            Restartui.enabled = true;
            timer.enabled = false;
        }
        //Incrimenting timer and dsiplaying tht value via function displaytime
        else
        {
            timestart -= Time.deltaTime;
            displaytime();
        }
    }

    //function takes in timerstart and modfies that value to fit "0:00"
    void displaytime()
    {
        int minutes = Mathf.FloorToInt(timestart / 60);
        int seconds = Mathf.FloorToInt(timestart % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
