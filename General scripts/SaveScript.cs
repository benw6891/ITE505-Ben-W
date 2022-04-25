/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//GameData is a function in Unity

[RequireComponent(typeof(GameData))]
public class SaveScript : MonoBehaviour
{

    private GameData gameData;
    private string savePath;

//SAVING SECTION (then loading)


    void Start()
    { //saving to persistent data path because it works on all platforms 
        gameData = GetComponent<GameData>();
        savePath = Application.persistentDataPath + "/gamesave.save";
    }

    public void SaveData()
    {
        var save = new Save()
        {
            coins = gameData.GameInteger,
           // SavedString = gameData.GameString
        };

        var binaryFormatter = new BinaryFormatter();
        using (var fileStream = File.Create(savePath))
        {
            binaryFormatter.Serialize(fileStream, save); 
        }

        Debug.Log("Data saved successfully!");
    }

    //LOADING SECTION

    public void LoadData()
    {
        if (File.Exists(savePath))
        {
            Save save;

            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = File.Open(savePath, FileMode.Open))
            {
                save = (Save)binaryFormatter.Deserialize(fileStream);
            }

            gameData.GameInteger = save.SavedInteger;
            gameData.GameString = save.SavedString;
            gameData.ShowData();

            Debug.Log("Data loaded!");
        }
        else 
        {
            Debug.LogWarning("No saved game.");
        }
    }
} 

*/ 