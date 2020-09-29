using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// Starts the game after inputting player name
public class OpenLevelOne : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameSettings.playerNamestr = playerName.text;
    }
}
