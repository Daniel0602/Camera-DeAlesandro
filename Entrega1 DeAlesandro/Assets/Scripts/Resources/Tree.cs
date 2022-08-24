using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] GameObject Drop;
    public int life = 5;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("intarea"))
        { life -= PlayerStats.resoruceDamage; }
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
