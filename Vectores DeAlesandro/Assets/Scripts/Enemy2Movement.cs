using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Movement : MonoBehaviour
{
    [SerializeField] Transform Target;
    float Speed = 1f;

    void Update()
    {
        Vector3 Direction = transform.position - Target.position;
        if(Direction.magnitude > 2)
        {
            transform.Translate(Direction * Speed * Time.deltaTime);
        }
        transform.LookAt(Target);
    }
}
