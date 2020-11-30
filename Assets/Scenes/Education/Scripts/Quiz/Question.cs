using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "question", menuName = "QuestionObject")]
public class Question : ScriptableObject
{
    public string question;
    public string[] answers = new string[4];
    public int correctAnswer;
}
