using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // This Class contains what the active session data is, and is in change of loading/saving to the data file

    // Game Data
    public int totalEPICompletions;
    public int totalAEDCompletions;

    public int totalFailedQuizzes;
    public int totalFailedSimulations;

    // Education Data
    public bool isEducated_EPIPEN;
    public bool isEducated_AED;

    // 

    public PlayerDataSet saveData;

    public void Start()
    {
        saveData = new PlayerDataSet();
    }

    public void Save() 
    {
        saveData.isEducated_EPIPEN = this.isEducated_EPIPEN;
        saveData.isEducated_AED = this.isEducated_AED;

        saveData.totalEPICompletions = this.totalEPICompletions;
        saveData.totalAEDCompletions = this.totalAEDCompletions;

        saveData.totalFailedQuizzes = this.totalFailedQuizzes;
        saveData.totalFailedSimulations = this.totalFailedSimulations;

        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, saveData);
        file.Close();
    }

    public void Load() 
    {
        string destination = Application.persistentDataPath + "/savefile.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            GenerateDefaults();
            Save();
            file = File.OpenRead(destination);
        }

        BinaryFormatter bf = new BinaryFormatter();
        saveData = (PlayerDataSet)bf.Deserialize(file);
        file.Close();

        this.isEducated_EPIPEN = saveData.isEducated_EPIPEN;
        this.isEducated_AED = saveData.isEducated_AED;

        this.totalEPICompletions = saveData.totalEPICompletions;
        this.totalAEDCompletions = saveData.totalAEDCompletions;

        this.totalFailedQuizzes = saveData.totalFailedQuizzes;
        this.totalFailedSimulations = saveData.totalFailedSimulations;

    }

    public void GenerateDefaults()
    {
        this.isEducated_EPIPEN = false;
        this.isEducated_AED = false;

        this.totalEPICompletions = 0;
        this.totalAEDCompletions = 0;

        this.totalFailedQuizzes = 0;
        this.totalFailedSimulations = 0;
    }
}
