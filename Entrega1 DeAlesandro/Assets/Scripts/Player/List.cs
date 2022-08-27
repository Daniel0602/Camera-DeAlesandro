using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField] ToolManager TM;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Tool"))
        {
            TM.ToolList1.Add(other.gameObject);
            other.gameObject.SetActive(false);

            TM.ToolDirectory1.Add(other.gameObject.name, other.gameObject);

            Debug.Log(TM.ToolDirectory1[other.gameObject.name]);
        }
    }
}
