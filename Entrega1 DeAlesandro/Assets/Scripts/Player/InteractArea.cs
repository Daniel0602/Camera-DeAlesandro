using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractArea : MonoBehaviour
{
    [SerializeField]Rigidbody MyRigidbody;
    private void Start()
    {
        MyRigidbody.AddRelativeForce(Vector3.forward * 0.001f, ForceMode.Impulse);
        Destroy(gameObject, 0.1f);
    }
}
