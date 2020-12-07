using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManagement : MonoBehaviour
{
    public GameObject saveManager;
    public PlayerData PD;

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
        saveManager = GameObject.FindGameObjectWithTag("SaveManager");
        PD = saveManager.GetComponent<PlayerData>();
    }
    public void Start()
    {
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
         
        questions.RemoveAt(currentQuestion); // Then after this question has been assigned to the UI, we want to remove this question from the pool of total questions | AKA: If we have 10 questions and #1 is displayed on the UI, we now only have 9 questions remaining in the pool to choose from
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
        questions.RemoveAt(currentQuestion); // Once the question has been given to the user, this removes it from the bank of possible questions

        if (questions.Count == 0) // Once there are no more questions, remove the UI from the player's View
        {
            canvas.enabled = false;
            FinalResults();
            return;
        }

        GenerateQuestion(); // Generates a new question to populate the UI
    }
    public void IsIncorrect() 
    {
        numQuestionsIncorrect++;
        questions.RemoveAt(currentQuestion);

        if (questions.Count == 0) // Once there are no more questions, remove the UI from the player's View
        {
            canvas.enabled = false;
            FinalResults();
            return;
        }
        GenerateQuestion();
    }
    public void FinalResults() 
    {
        correctPercentage = numQuestionsCorrect / numTotalQuestions; // Calculating what the final score was

        if ((correctPercentage >= PD.passingScore) && (numQuestionsCorrect + numQuestionsIncorrect) == numTotalQuestions) // If they pass
        {
            if (PD.isEducated_EPI == false)
            {
                PD.isEducated_EPI = true;
            }
            PD.totalEPIQuizPasses++;

            PD.Save();
        }
        else // If they fail 
        {
            PD.totalEPIQuizFailures++;
            PD.Save();
        }
    }
}
