using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //-----Animations-----
    [SerializeField] Animator PlayerAnimatorS;

    //-----Stats-----
    public float Speed = 10f;
    public float jumpForce = 10f;

    public Transform SpawnPoint;
    //-----Movimiento-----
    Vector3 direction;

    //-----Jump-----
    public bool CanJump;
    private Rigidbody myRigidbody;
    void Start() { myRigidbody = GetComponent<Rigidbody>(); }

    void Update()
    {
        direction = Vector3.zero;

        if (Input.GetKey("w"))
        {direction += Vector3.forward;}
        if (Input.GetKey("s"))
        {direction += Vector3.back;}
        if (Input.GetKey("a"))
        {direction += Vector3.left;}
        if (Input.GetKey("d"))
        {direction += Vector3.right;}

        //-----Movimiento-----
        if (direction != Vector3.zero)
        { transform.Translate(direction * Speed * Time.deltaTime); }

        //-----Muerte-----
        if (PlayerStats.life <= 0)
        {
            transform.position = SpawnPoint.position;
            PlayerStats.life = PlayerStats.maxLife;
            PlayerStats.deads++;
        }

        //-----Animaciones-----
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        PlayerAnimatorS.SetFloat("Horizontal",x);
        PlayerAnimatorS.SetFloat("Vertical",z);
    }

    private void FixedUpdate()
    {
        //-----Jump-----
        if (Input.GetKeyDown("space") && CanJump)
        { myRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); }
    }
    //-----CanJump-----
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            CanJump = true;
            PlayerAnimatorS.SetTrigger("CanJump");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            CanJump = false;
            if(!IsAnimation("fall")) PlayerAnimatorS.SetTrigger("Jumping");
        }
    }

    bool IsAnimation(string anim)
    { return PlayerAnimatorS.GetCurrentAnimatorStateInfo(0).IsName(anim); }
}
