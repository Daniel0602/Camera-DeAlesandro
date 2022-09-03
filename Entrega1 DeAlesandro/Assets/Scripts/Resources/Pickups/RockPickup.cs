using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPickup : PickupRotation
{
    public int rockAmount = 2;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory.Rock += rockAmount;
            Destroy(gameObject);
        }
    }
}