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

    // Called On the Intialization of Script
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        moveTowardsPlayer(player, 0);
    }
}
