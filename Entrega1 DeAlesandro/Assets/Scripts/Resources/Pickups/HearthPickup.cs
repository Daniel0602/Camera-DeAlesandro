using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HearthPickup : PickupRotation
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(PlayerStats.life < PlayerStats.maxLife + 1)
            {
                PlayerStats.life += Random.Range(1, PlayerStats.maxLife - PlayerStats.life);
                Destroy(gameObject);
            }
        }
    }
}
