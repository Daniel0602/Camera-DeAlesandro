using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{//-----Animations-----
    [SerializeField] Animator PlayerAnimatorS;
//-----Stats-----
    public float Speed = 10f;
    public float jumpForce = 10f;
//-----Movimiento-----
    Vector3 direction;
//-----Jump-----
    public bool CanJump;
    private Rigidbody myRigidbody;
    void Start(){myRigidbody = GetComponent<Rigidbody>();}

    void Update()
    {
        direction = Vector3.zero;
        if (Input.GetKey("w")) { direction += Vector3.forward; PlayerAnimatorS.SetTrigger("forward"); }
        if (Input.GetKey("s")) { direction += Vector3.back; PlayerAnimatorS.SetTrigger("back"); }
        if (Input.GetKey("a")) { direction += Vector3.left; PlayerAnimatorS.SetTrigger("left"); }
        if (Input.GetKey("d")) { direction += Vector3.right; PlayerAnimatorS.SetTrigger("right"); }
        if(!CanJump){PlayerAnimatorS.SetTrigger("jump");}

        if(direction == Vector3.zero)
        {PlayerAnimatorS.SetTrigger("idle");}
    }

    private void FixedUpdate()
    {
        if(direction != Vector3.zero)
        {transform.Translate(direction * Speed * Time.deltaTime);}

        if(Input.GetKeyDown("space") && CanJump)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {if(other.gameObject.CompareTag("Floor")){CanJump = true;}}

    private void OnCollisionExit(Collision other)
    {if(other.gameObject.CompareTag("Floor")){CanJump = false;}}
}
