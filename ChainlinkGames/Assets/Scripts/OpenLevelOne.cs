using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevelOne : MonoBehaviour
{

    public TextMeshProUGUI playerName;
    public void StartGame()
    {
        Debug.Log(playerName.text);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        GameSettings.playerNamestr = playerName.text;
    }
}
