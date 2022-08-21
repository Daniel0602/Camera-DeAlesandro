using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
    Transform target;

    float speed;
    public float speedRotation;

    void Update()
    {
        Vector3 Direction = transform.position - Target.position;
        transform.LookAt(Target);
        if (Direction.magnitude > 2)
        {
            transform.Translate(Direction * Speed * Time.deltaTime);
        }
    }
}
