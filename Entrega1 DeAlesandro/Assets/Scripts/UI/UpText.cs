using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpText : MonoBehaviour
{
    public TMP_Text upText;

    void Start()
    {
        Clean();
    }

    void Tienda()
    {
        upText.text = "Press F to open";
    }

    void Clean()
    {
        upText.text = " " ;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Tienda") || other.CompareTag("Chest"))
        {
            Tienda();
        }
    }

    void OnTriggerExit(Collider other)
    {
        Clean();
    }
}
