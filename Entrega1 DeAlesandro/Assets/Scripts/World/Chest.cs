using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public GameObject ChestDrop;
    public bool Open;
    public TMP_Text upText;

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("f") && !Open && other.transform.CompareTag("Player"))
        {
            upText.text = " " ;
            Open = true;
            Instantiate(ChestDrop, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
