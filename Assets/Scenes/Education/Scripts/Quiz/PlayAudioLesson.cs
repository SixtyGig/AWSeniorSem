using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioLesson : MonoBehaviour
{
    public GameObject questionCanvasUI;
    public GameObject teacher;

    private AudioSource audioSource;
    private AudioClip lessonAudio;
    private bool isPlayingLessonAudio = false;
    private float clipLength;

    private bool displayQuestionUI = false;


    // Start is called before the first frame update
    public void Awake()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        lessonAudio = audioSource.clip;
    }
    public void Start()
    {
        // First disables the canvas and enables the teacher
        questionCanvasUI.SetActive(false);
        teacher.SetActive(true);

        if (isPlayingLessonAudio == false) 
        {
            isPlayingLessonAudio = true;
            StartCoroutine(PlayLessonAudio(lessonAudio));
        }
    }

    private IEnumerator PlayLessonAudio(AudioClip clip) 
    {
        while (isPlayingLessonAudio)
        {
             
            // Lesson audio plays, waits until it's done playing, then continues on
            audioSource.Play();
            clipLength = audioSource.clip.length;
            yield return new WaitForSeconds(clipLength);
            isPlayingLessonAudio = false;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (displayQuestionUI == false)
        {
            if (isPlayingLessonAudio == false) 
            {
                teacher.SetActive(false);

                questionCanvasUI.SetActive(true);
                displayQuestionUI = true;
                Debug.Log("Quiz UI is now Active");
            }
        }
    }
}
