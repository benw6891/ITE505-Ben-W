using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [Header("Levels to load")]
    public string _newGameLevel;
    private string levelToLoad;   
    [SerializeField] private GameObject noSavedGameDialog = null;

    //bringing in our coins value so that we can reset it
    [SerializeField]
    private FloatSO coinsSO;

    //variable for if the player selects new game option. Level 1 is then loaded.
    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);
        //coins are reset because new game (not using rn)
        //coinsSO.Value = coinsSO.Value * 0;
    }


//When player clicks to load a saved game, the below code will check to see if anything is saved 


    public void LoadGameDialogYes()
    {
        if(PlayerPrefs.HasKey("SavedLevel"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
        else 
        {
            noSavedGameDialog.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}



