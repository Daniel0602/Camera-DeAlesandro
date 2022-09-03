using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodPickup : PickupRotation
{
    public int woodAmount = 1;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory.Wood += woodAmount;
            Destroy(gameObject);
        }
    }
}
