using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portall : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.localScale == Vector3.one)
        {
            other.transform.localScale = other.transform.localScale / 2;
        }
        else
        {
            other.transform.localScale = other.transform.localScale * 2;
        }
    }
}
