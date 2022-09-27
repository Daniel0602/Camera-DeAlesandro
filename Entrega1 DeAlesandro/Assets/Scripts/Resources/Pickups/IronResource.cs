using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronResource : MonoBehaviour
{
    float IronAmount;

    void Start()
    {
        IronAmount = Random.Range(1 * PlayerStats.resourceMultiplier, 3 * PlayerStats.resourceMultiplier);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Inventory.Iron += IronAmount;

            Destroy(gameObject);
        }
    }
}
