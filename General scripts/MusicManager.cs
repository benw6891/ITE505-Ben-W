using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        //when the game starts, checks for preferences for volume
        //if there are none, this is the code for that 
        if(!PlayerPrefs.HasKey("musicVolume")) {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        //if there are saved preferences, they will be loaded
        else {
            Load();
        }
    }

    public void ChangeVolume() {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    //load method for the music volume 
    private void Load() {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    //save method for music volume 
    private void Save() {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
