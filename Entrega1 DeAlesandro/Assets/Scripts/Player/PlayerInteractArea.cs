using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractArea : MonoBehaviour
{
    [SerializeField] GameObject IntArea;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {Instantiate(IntArea, transform.position, transform.rotation);}
    }
}
