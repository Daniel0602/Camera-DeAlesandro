using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        MoveAxis();
    }

    private void MoveAxis()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Vector3 Direction = new Vector3(H, 0, V);
        transform.Translate(Direction * Speed * Time.deltaTime);
    }
}
