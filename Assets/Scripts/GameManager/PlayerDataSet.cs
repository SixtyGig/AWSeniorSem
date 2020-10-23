using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerDataSet 
{
    // Game Data
    public int totalEPICompletions;
    public int totalAEDCompletions;

    public int totalFailedQuizzes;
    public int totalFailedSimulations;

    // Education Data
    public bool isEducated_EPIPEN;
    public bool isEducated_AED;

}
