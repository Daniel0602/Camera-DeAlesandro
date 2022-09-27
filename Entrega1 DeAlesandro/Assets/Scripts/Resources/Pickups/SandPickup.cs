using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandPickup : MonoBehaviour
{
     float SandAmount;

    void Start()
    {
        SandAmount = Random.Range(7 * PlayerStats.resourceMultiplier,20 * PlayerStats.resourceMultiplier);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory.Sand += SandAmount;

            Destroy(gameObject);
        }
    }
}
