using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the behavior of the slime enemy
/// </summary>
public class Slime : Enemy
{
    // The player model
    [SerializeField] private GameObject player;
    
    public Slime()
    {
        // Movement Speed of the Slime
        movementSpeed = 0.005f;
        // Health of the Slime
        health = 100f;
        // Damage the slime does
        damage = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        moveTowardsPlayer();
    }

    /// <summary>
    /// Moves the slime towards the player
    /// </summary>
    void moveTowardsPlayer()
    {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 0, player.transform.position.z), movementSpeed);
    }
}
