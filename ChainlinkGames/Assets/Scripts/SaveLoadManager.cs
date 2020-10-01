using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(player);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        GameSettings.playerNamestr = data.name;
        PlayerHealth.currentHealth = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        player.transform.position = position;
    }
}
