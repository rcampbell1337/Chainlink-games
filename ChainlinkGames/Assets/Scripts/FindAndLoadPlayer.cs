using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindAndLoadPlayer : MonoBehaviour
{
    public GameObject findPlayer;
    public GameObject takeItems;
    public GameObject destroyScene;
    Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void FindPlayerAndLoad(bool load)
    {
        if (load)
        {
            LoadPlayer();
        }
        Destroy(destroyScene);
        SceneManager.LoadScene(scene.buildIndex + 1, LoadSceneMode.Additive);
        SceneManager.MoveGameObjectToScene(takeItems, SceneManager.GetSceneByBuildIndex(scene.buildIndex + 1));
        takeItems.SetActive(true);
    }

    void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        GameSettings.playerNamestr = data.name;
        PlayerHealth.currentHealth = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        findPlayer.transform.position = position;
    }
}
