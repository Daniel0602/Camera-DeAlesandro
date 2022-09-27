using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] GameObject Drop;
    Rigidbody MyRigidbody;
    public int life = 5;

    void Awake()
    {
        MyRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {
        MyRigidbody.AddForce(new Vector3(0f, 0001f, 0f));
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("intarea") && ToolManager.activeTool == 3)
        { life -= PlayerStats.resoruceDamage; }

        if (other.gameObject.CompareTag("Resource"))
        { Destroy(gameObject); }
    }

    void Update()
    {
        if (life <= 0)
        {
            Instantiate(Drop, transform.position, transform.rotation);
            Destroy(gameObject, 0.01f);
        }
    }
}
