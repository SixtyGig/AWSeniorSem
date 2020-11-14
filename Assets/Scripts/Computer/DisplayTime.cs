using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public GameObject gameTimeDisplay;
    public int hours;
    public int minutes;

    // Start is called before the first frame update
    void Start()
    {
        this.hours = -1;
        this.minutes = -1;
    }

    // Update is called once per frame
    void Update()
    {
        this.hours = System.DateTime.Now.Hour;
        this.minutes = System.DateTime.Now.Minute;
        this.gameTimeDisplay.GetComponent<Text>().text = "" + hours + ":" + minutes;
    }
}
