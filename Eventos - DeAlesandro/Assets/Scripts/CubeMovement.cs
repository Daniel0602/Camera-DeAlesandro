using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float Speed = 7f;

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 Dir = new Vector3(Horizontal,0,Vertical);
        transform.position += Dir * Speed * Time.deltaTime;
    }
}
