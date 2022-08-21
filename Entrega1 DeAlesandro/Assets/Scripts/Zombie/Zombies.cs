using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    [SerializeField] Transform Target;

    float Speed = 1f;

    void Update()
    {
        Vector3 Dir = transform.position - Target.position;
        transform.LookAt(Target);
        if (Dir.magnitude > 0)
        { transform.Translate(Dir * Speed * Time.deltaTime); }

    }
}
