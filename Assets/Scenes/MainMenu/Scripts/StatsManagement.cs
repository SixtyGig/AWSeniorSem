using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManagement : MonoBehaviour
{
    private GameObject saveManager;
    private PlayerData PD;

    private Text testPass;
    private Text testFail;

    private void Awake()
    {
        saveManager = GameObject.FindGameObjectWithTag("SaveManager");
        PD = saveManager.GetComponent<PlayerData>();

        testPass = GameObject.FindGameObjectWithTag("TestPassNum").GetComponent<Text>();
        testFail = GameObject.FindGameObjectWithTag("TestFailNum").GetComponent<Text>();
    }

    private void Start()
    {
        PD.Load();

        testPass.text = PD.totalEPIQuizPasses.ToString();
        testFail.text = PD.totalEPIQuizFailures.ToString();
    }
}
