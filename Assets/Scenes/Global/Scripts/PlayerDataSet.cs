using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerDataSet 
{
    // Game Data
    public int totalEPIQuizPasses;
    public int totalEPIQuizFailures;

    public int totalPassedSimulations;
    public int totalFailedSimulations;

    // Education Data
    public bool isEducated_EPI;
    public bool isTrained_EPI;

    // Education Data - Quiz


    // Current Active Module/Activity
    public string currentModule;
}
