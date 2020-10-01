using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Allows the player to pause the game on "escape" button press
// Note: (The next step will be a load and save game function in the pause menu)
public class PauseGame : MonoBehaviour
{

    // Checks whether or not the game is paused
    public static bool GameIsPaused;

    // will be set to active on pause
    public GameObject pauseMenuUI;

    // Checks pause status
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // These 2 functions manipulate the ingame time to pause and resume the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    // Takes the player back to the start menu
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    // Code can be added here on launch
    public void QuitGame()
    {
        // Exit game
    }
}
