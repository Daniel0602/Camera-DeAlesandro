using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPickup : PickupRotation
{
    public float rockAmount;

    void Start()
    {
        rockAmount = Random.Range(2 * PlayerStats.resourceMultiplier,4 * PlayerStats.resourceMultiplier);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory.Rock += rockAmount;

            Destroy(gameObject);
        }
    }
}