using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotation : MonoBehaviour
{
    float CameraAxisX = 0f;
    void Update(){CameraAxisX += 0.5f;transform.rotation = Quaternion.Euler(0,CameraAxisX,0);}
}
