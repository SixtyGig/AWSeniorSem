using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    private QuizManagement quizManager; // This is just to create a reference for the quiz manager so we can access the QuizManagement script
    public bool isCorrect = false;

    private void Awake()
    {
        quizManager = GameObject.FindGameObjectWithTag("QuizManager").GetComponent<QuizManagement>(); // Locates the Quiz Manager in the scene
    }

    public void AnswerOnClick()
    {
        if (isCorrect == true)
        {
            Debug.Log("CORRECT");
            quizManager.IsCorrect();
        }
        else 
        {
            Debug.Log("WRONG");
            quizManager.IsIncorrect();
        }
    }
}
