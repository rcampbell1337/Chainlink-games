using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// A class to record constant variables throughout the game, at present it only records
// Player name, but in future it will be added to
public class GameSettings : MonoBehaviour
{
    // Variables to set the player name
    public static string playerNamestr;
    public TextMeshProUGUI playerName;
    void Start()
    {
        playerName.text = playerNamestr;
    }
}
