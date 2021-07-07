using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public string name;
    public int health;
    public float[] position;
    public int currentScene;

    public PlayerData (GameObject player)
    {
        name = GameSettings.playerNamestr;
        health = PlayerHealth.currentHealth;
        currentScene = SceneManager.GetActiveScene().buildIndex;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
