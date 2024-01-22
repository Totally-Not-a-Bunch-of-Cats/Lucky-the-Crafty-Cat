using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Parent class of all enemies that will hold universal information
/// </summary>
public class Enemy : MonoBehaviour
{   
    // Movement Speed of the Slime
    [SerializeField] protected float movementSpeed = 0.1f;
    // Health of the Slime
    [SerializeField] protected float health = 100f;
    // Damage the slime does
    [SerializeField] protected float damage = 25f;

    
}
