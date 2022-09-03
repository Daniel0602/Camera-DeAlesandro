using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotation : MonoBehaviour
{
    public float RotationSpeed = 0.5f;
    float PickRot = 0f;
    void Update()
    {
        PickRot += RotationSpeed;
        transform.rotation = Quaternion.Euler(0,PickRot,0);
    }
}
