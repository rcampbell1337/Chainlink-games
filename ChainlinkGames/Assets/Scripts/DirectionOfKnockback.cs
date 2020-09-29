using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Used to decide which direction the enemy knocks the player back
public class DirectionOfKnockback : MonoBehaviour
{
    public float knockBackValue;

    void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth.hitMoveSpeed = knockBackValue;
    }
}
