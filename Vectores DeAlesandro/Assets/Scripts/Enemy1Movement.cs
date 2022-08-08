using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
    Vector3 RelativePosition;
    Quaternion targetRotation;

    Transform target;
    float speed;

    void Update()
    {
        RelativePosition = target.position - transform.position;
        targetRotation = Quaternion.LookRotation(RelativePosition);
        transform.rotation = Quaternion.Lerp(transform.rotation,targetRotation,speed * Time.deltaTime);
    }
}
