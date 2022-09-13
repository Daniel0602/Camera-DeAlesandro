using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCubeU : MonoBehaviour
{
    public Events EventScript;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EventScript.WiningU();
        }
    }
}
