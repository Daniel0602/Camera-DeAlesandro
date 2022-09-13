using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodPickup : PickupRotation
{
    public float woodAmount;

    void Start()
    {
        woodAmount = Random.Range(1 * PlayerStats.resourceMultiplier,3 * PlayerStats.resourceMultiplier);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory.Wood += woodAmount;

            Destroy(gameObject);
        }
    }
}
