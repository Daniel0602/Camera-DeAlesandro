using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] float Sensivility = 5f;
    [SerializeField] float CameraAxisX = 0f;

    private void FixedUpdate()
    {
        CameraAxisX += Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0,CameraAxisX * Sensivility,0);
    }
}
