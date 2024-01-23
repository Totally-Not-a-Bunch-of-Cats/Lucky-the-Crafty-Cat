using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : Enemy
{
    // The player model
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject parentHive;

    // XYZ spread that the bee will hover around the beehive
    public float xSpread = 0.003f;
    public float yOffset;
    public float zSpread = 0.003f;

    // the point that the bees will hover around
    public Transform centerPoint;
    // Which way the bees will orbit
    public bool rotateClockwise;
    // Speed of Rotation
    public float rotSpeed = 1f;

    // Timer for rotating
    float timer = 0;

    // Is the Bee aggressive
    public bool isAngry = false;

    // Return the Bees to the hive when no longer angry
    public bool returnToStart = false;
    // Gets the bee current status
    public bool GetisAngry()
    {
        return isAngry;
    }
    // Sets the bee current status
    public void SetisAngry(bool Condition)
    {
        isAngry = Condition;
    }

    // Initializing Bee
    public Bee()
    {
        // Movement Speed of the Bee
        movementSpeed = 0.01f;
        // Health of the Bee
        health = 100f;
        // Damage the Bee does
        damage = 25f;
    }

    // Called On the Intialization of Script
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        parentHive = gameObject.transform.parent.transform.parent.gameObject;
        centerPoint = parentHive.transform;
    }


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * rotSpeed;
        if(isAngry)
        {
            moveTowardsPlayer(player, 1.5f);
        }
        else
        {
            if(returnToStart == true)
            {
                gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(parentHive.transform.position.x, parentHive.transform.position.y + 2, parentHive.transform.position.z), movementSpeed);
            }
            else
            {
                Rotate();
                transform.LookAt(centerPoint);
            }
        }
        if(gameObject.transform.position == new Vector3(parentHive.transform.position.x, parentHive.transform.position.y + 2, parentHive.transform.position.z))
        {
            returnToStart = false;
        }
    }

    void Rotate() 
    {
        if(rotateClockwise)
        {
            float x = -Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
        else
        {
            float x = Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
    }
}
