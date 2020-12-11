using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManagement : MonoBehaviour
{
    public GameObject saveManager;
    public PlayerData PD;

    public GameObject quizCanvas;

    public List<Question> questions; // List of Questions (and their answers)
    public GameObject[] options; // Array of buttos on the UI
    public int currentQuestion; // holds current question index

    private int numTotalQuestions;
    private int numQuestionsCorrect;
    private int numQuestionsIncorrect;
    private float correctPercentage;

    public Text questionText; // Location where the Question's text component is located
    public Canvas canvas;

    public void Awake()
    {
        try
        {
            saveManager = GameObject.FindGameObjectWithTag("SaveManager");
            PD = saveManager.GetComponent<PlayerData>();
        }
        catch
        {
            Debug.Log("No Save Manager detected.");
        }
    }
    public void Start()
    {
        PD.Load();

        numTotalQuestions = questions.Count;
        // Any previous data reset to zero
        numQuestionsCorrect = 0;
        numQuestionsIncorrect = 0;

        correctPercentage = 0.0f;

        GenerateQuestion();  // Then we select the first question from that bank to display to the user
    }

    public void GenerateQuestion() // This generates a question and then assigns its (both possible and correct) answers 
    {
        currentQuestion = Random.Range(0, questions.Count);
        questionText.text = questions[currentQuestion].question;
        
        Debug.Log(questions[currentQuestion].question);

        GenerateAnswers(); // Every time we generate a question, answers will also be allotted to it
    }

    public void GenerateAnswers() // This generates the answers for the question selected above
    {
        for (int i = 0; i < options.Length; i++) 
        {
            options[i].GetComponent<Answers>().isCorrect = false; // We only want one correct answer (and we want to determine that on an individual basis per question). This is just to verify that all "correctly-marked" questions have been set to false
            options[i].transform.GetChild(0).GetComponent<Text>().text = questions[currentQuestion].answers[i];

            if (questions[currentQuestion].correctAnswer == i + 1) 
            {
                options[i].GetComponent<Answers>().isCorrect = true; // This assigns the correct value to whichever option's text field contains the correct answer
            }
        }
    }

    public void IsCorrect() 
    {
        numQuestionsCorrect++;
        
        Debug.Log("Number of Correct: " + numQuestionsCorrect);
        Debug.Log("Number of Incorrect: " + numQuestionsIncorrect);

        questions.RemoveAt(currentQuestion); // Once the question has been given to the user, this removes it from the bank of possible questions

        if (questions.Count == 0) // Once there are no more questions, remove the UI from the player's View
        {
            canvas.enabled = false;
            FinalResults();
        }
        else
        {
            GenerateQuestion(); // Generates a new question to populate the UI
        }
    }
    public void IsIncorrect() 
    {
        numQuestionsIncorrect++;

        Debug.Log("Number of Correct: " + numQuestionsCorrect);
        Debug.Log("Number of Incorrect: " + numQuestionsIncorrect);

        questions.RemoveAt(currentQuestion); // Once the question has been given to the user, this removes it from the bank of possible questions

        if (questions.Count == 0) // Once there are no more questions, remove the UI from the player's View
        {
            canvas.enabled = false;
            FinalResults();
        }
        else
        {
            GenerateQuestion(); // Generates a new question to populate the UI
        }
    }
    public void FinalResults() 
    {
        Debug.Log(numQuestionsCorrect);
        Debug.Log(numTotalQuestions);

        correctPercentage = ((float)numQuestionsCorrect / (float)numTotalQuestions); // Calculating what the final score was (percentage) | We're multiplying by 100 to make it an even decimal
        Debug.Log("This is the percent correct:" + correctPercentage * 100 + "%");
        Debug.Log("Required Score:" + PD.passingScore);
        if (correctPercentage >= PD.passingScore) // If they pass
        {
            if (PD.isEducated_EPI == false)
            {
                PD.isEducated_EPI = true;
            }

            Debug.Log("Student Passed");
            PD.totalEPIQuizPasses++;
            PD.Save();
            SceneManager.LoadScene("MainMenu");
        }
        else // If they fail - Update total Quiz Failures, then save the data
        {
            Debug.Log("Student Failed");
            PD.totalEPIQuizFailures++;
            PD.Save();
            SceneManager.LoadScene("MainMenu");
        }
    }
}
