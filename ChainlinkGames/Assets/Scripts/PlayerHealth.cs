using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            TakeDamage(10);
        }
        healthbar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
