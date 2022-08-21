using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    //-----dash-----
    public int dashsMax = 3;
    public int dashs = 3;
    public int dashsDelay = 10;
    public float dashSpeed = 15;
    public bool CanDash = true;

    //-----Timer-----
    [SerializeField]float seconds;

    private Rigidbody myRigidbody;
    void Start(){myRigidbody = GetComponent<Rigidbody>();}

    void FixedUpdate()
    {
        if(Input.GetKeyDown("left shift") && dashs > 0 && CanDash)
        {myRigidbody.AddRelativeForce(Vector3.forward * dashSpeed, ForceMode.Impulse);dashs--;}
    }

    void Update()
    {//-----Timer-----
        if(dashs < dashsMax){seconds += 1 * Time.deltaTime;}
        if(seconds >= dashsDelay && dashs < dashsMax){dashs++;seconds=0f;}
    }

    private void OnCollisionEnter(Collision other)
    {if(other.gameObject.CompareTag("Floor")){CanDash = true;}}

    private void OnCollisionExit(Collision other)
    {if(other.gameObject.CompareTag("Floor")){CanDash = false;}}
}
