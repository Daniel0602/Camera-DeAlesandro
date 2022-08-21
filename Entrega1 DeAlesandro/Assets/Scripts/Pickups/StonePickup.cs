using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonePickup : MonoBehaviour
{
    public int stoneP = 2;

    public void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("Player")){Inventory.Stone += stoneP;Destroy(gameObject);}
    }
}