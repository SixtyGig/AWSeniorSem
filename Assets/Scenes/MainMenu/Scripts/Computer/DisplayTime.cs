using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public GameObject gameTimeDisplay;
    public string hours;
    public string minutes;
    public string seconds;

    private void Awake()
    {
        gameTimeDisplay = GameObject.FindGameObjectWithTag("GameTimeDisplay");
    }
    // Start is called before the first frame update
    void Start()
    {
        this.hours = "-1";
        this.minutes = "-1";
        this.seconds = "-1";
    }

    // Update is called once per frame
    void Update()
    {
        this.hours = "" + System.DateTime.Now.Hour;

        // All this is basically just formatting for the clock, so that "0" shows up. I used integers before, and that was omitting the zeroes.
        if (System.DateTime.Now.Minute < 10)
        {
            this.minutes = "0" + System.DateTime.Now.Minute;
        }
        else
        {
            this.minutes = "" + System.DateTime.Now.Minute;
        }

        if (System.DateTime.Now.Second < 10)
        {
            this.seconds = "0" + System.DateTime.Now.Second;
        }
        else 
        {
            this.seconds = "" + System.DateTime.Now.Second;
        }

        this.gameTimeDisplay.GetComponent<Text>().text = "" + hours + ":" + minutes + ":" + seconds;
    }
}
