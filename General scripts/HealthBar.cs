using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//I can use this code on the player, and player has some additional code 

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //gradient is necessary for the color change when player reaches lower levels of health 
    public Gradient gradient;
    public Image fill;

    //updates the slider for health 
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        //when player is at max health, color will be green (from gradient)
        fill.color = gradient.Evaluate(1f);
    }

    //whenever I call the SetHealth function, script will find slider and adjust the value 
    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
