using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractArea : MonoBehaviour
{
    [SerializeField]Rigidbody MyRigidbody;
    private void Start()
    {
        transform.localScale = new Vector3(1 * PlayerStats.range,1,1 * PlayerStats.range);
        MyRigidbody.AddRelativeForce(Vector3.forward * 0.001f, ForceMode.Impulse);
        Destroy(gameObject, 0.05f);
    }
}
