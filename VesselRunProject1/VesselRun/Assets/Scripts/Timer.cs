using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timestart = 60.0f;
    public TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = timestart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timestart -= Time.deltaTime;
        //timer.text = Mathf.Round(timestart).ToString();
        displaytime();
    }

    void displaytime()
    {
        int minutes = Mathf.FloorToInt(timestart / 60);
        int seconds = Mathf.FloorToInt(timestart % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
