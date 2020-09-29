using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// A class that determines the players current health variable
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    // Reference to the healthbar graphic ingame
    public HealthBarScript healthbar;

    // Knocks the player back at this speed defined by external box colliders
    public static float hitMoveSpeed;

    // References the players position for a knockback effect
    private Rigidbody2D rb;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Death condition
    void Update()
    {
        healthbar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    // Function used whenever hit conditions are met
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Vector2 damageKnockback = new Vector2(hitMoveSpeed, 100);
        rb.AddForce(damageKnockback);
    }

    // If the player touches an enemy they take damage and are knocked back
    // Note: (There is scope to add different damages taken from different enemies)
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(currentHealth);
            TakeDamage(5);
        }
    }
}
