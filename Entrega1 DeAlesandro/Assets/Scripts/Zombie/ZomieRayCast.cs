using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomieRayCast : MonoBehaviour
{
    [SerializeField]
    private float rayDistance = 10f;

    [SerializeField] Color GizmoColor;

    private void FixedUpdate()
    {Raycast();}

    private void Raycast()
    {
        GizmoColor = Color.blue;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayDistance))
        {
            if (hit.transform.CompareTag("Player"))
            {GizmoColor = Color.red;}
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = GizmoColor;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * rayDistance;
        Gizmos.DrawRay(transform.position, direction);
    }
}
