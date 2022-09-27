using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    public GameObject tienda;

    void OnTriggerStay(Collider other)
    {
        if(other.transform.CompareTag("Player") && Input.GetKeyDown("f"))
        {
            Debug.Log("a");
            tienda.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        tienda.SetActive(false);
    }
}
