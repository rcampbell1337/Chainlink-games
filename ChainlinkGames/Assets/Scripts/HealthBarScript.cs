using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// A class that visually displays the players current health
public class HealthBarScript : MonoBehaviour
{

    // Slider adjusts the healthbar graphic in the UI
    public Slider slider;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Updates the health
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
