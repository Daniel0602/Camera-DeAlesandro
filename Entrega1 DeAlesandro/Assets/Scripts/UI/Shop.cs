using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public GameObject tienda;

    public void UpgradeDamageResource()
    {
        if(Inventory.Rock >= 10)
        {
            Inventory.Rock -= 10;
            PlayerStats.resoruceDamage++;
        }
    }
    public void UpgradeDamage()
    {
        if(Inventory.Wood >= 5)
        {
            Inventory.Wood -= 5;
            PlayerStats.atackDamage++;
        }
    }
    public void UpgradeResourceMultiplier()
    {
        if(Inventory.Iron >= 5)
        {
            Inventory.Iron -= 5;
            PlayerStats.resourceMultiplier++;
        }
    }
    public void UpgradeMaxLife()
    {
        if(Inventory.Wood >= 3)
        {
            Inventory.Wood -= 3;
            PlayerStats.maxLife += 10;
        }
    }
    public void UpgradeRange()
    {
        if(Inventory.Sand >= 20)
        {
            Inventory.Sand -= 20;
            PlayerStats.range++;
        }
    }
}
