using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCube : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            State.Loseing();
        }
    }
}
