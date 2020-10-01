using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// A class that allows the player to jump on the "spacebar" button press
public class JumpScript : MonoBehaviour
{

    // How high can the player jump
    public float jumpHeight;

    // Makes sure the player cannot jump more than once while in the air
    private bool isJumping = false;
    private Rigidbody2D rb;

    // Find the players rb for adjustment
    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Checks to see if the player wants to jump
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpHeight);
            isJumping = true;
        }
    }

    // Resets the players ability to jump
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
