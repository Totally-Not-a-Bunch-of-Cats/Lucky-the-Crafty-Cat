using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehive : MonoBehaviour
{
    // List of Bees that hover around the beehive
    [SerializeField] private GameObject[] bees;
    // Size of Zone of  Control of the Beehive
    [SerializeField] private float zoneOfControl = 16.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider>().size = new Vector3(zoneOfControl, 4, zoneOfControl);
    }
    
    // When the Player Enters its zone of control make the bees angry
    private void OnTriggerEnter(Collider other) {
        for(int i = 0; i <= bees.Length - 1; i++)
        {
            if(other == GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>())
            {
                bees[i].GetComponent<Bee>().SetisAngry(true);
            }
        }
    }

    // When the Player Exits its zone of control makes the bees docile
    private void OnTriggerExit(Collider other) {
        for(int i = 0; i <= bees.Length - 1; i++)
        {
            if(other == GameObject.FindGameObjectWithTag("Player").GetComponent<CapsuleCollider>())
            {
                bees[i].GetComponent<Bee>().SetisAngry(false);
                bees[i].GetComponent<Bee>().returnToStart = true;
            }
        }
    }
}
