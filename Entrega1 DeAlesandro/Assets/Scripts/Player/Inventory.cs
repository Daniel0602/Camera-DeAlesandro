using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject Inventario;
    public bool InventoryOn;
    int inv;

    public static float Wood, Rock, Sand, Iron;
    public TMP_Text WoodText, RockText, SandText, IronText;

    void Update()
    {
        if (Input.GetKeyDown("e")) inv++;

        if (inv == 0) Inventario.SetActive(false);
        if (inv == 1) Inventario.SetActive(true);

        if (inv >= 2) inv = 0;

        WoodText.text = "Wood " + Wood.ToString("F1");
        RockText.text = "Rock " + Rock.ToString("F1");
        SandText.text = "Sand " + Sand.ToString("F1");
        IronText.text = "Iron " + Iron.ToString("F1");
    }
}
