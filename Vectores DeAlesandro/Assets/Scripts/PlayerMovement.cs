using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    [SerializeField] float CameraAxisX = 0f;
    public float sensitivity = 2f;

    void Update()
    {
        RotatePlayer();
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 Direction = new Vector3(Horizontal,0,Vertical);
        transform.Translate(Direction * Speed * Time.deltaTime);
    }

    public void RotatePlayer()
    {
        CameraAxisX += Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0,CameraAxisX * sensitivity,0);
    }
}