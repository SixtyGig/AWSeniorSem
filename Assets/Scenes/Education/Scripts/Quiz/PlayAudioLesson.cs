using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioLesson : MonoBehaviour
{
    public GameObject questionCanvasUI;

    private AudioSource audioLesson;
    private bool displayQuestionUI = false;

    // Start is called before the first frame update
    public void Awake()
    {
        audioLesson = this.gameObject.GetComponent<AudioSource>();
    }
    public void Start()
    {
        Debug.Log("Waiting For 5 Seconds");
        audioLesson.Play();
        while (audioLesson.isPlaying == true) 
        { 
            // Wait for the Audio Lesson to finish
            //new WaitForSeconds(1); 
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (displayQuestionUI == false)
        {
            if (audioLesson.isPlaying == false) 
            {
                new WaitForSeconds(2);
                questionCanvasUI.SetActive(true);
                displayQuestionUI = true;
                Debug.Log("Quiz UI is now Active");
            }
        }
    }
}
