using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieB : MonoBehaviour
{
    /*public int ZDamage = 1;
    public int life = 10;
    public float Speed = 5f;
    public float Range = 10f;
    public bool frezed = false;
    public bool CanAtack = true;

    [SerializeField] Transform Target;
    [SerializeField] Animator ZombieAnimator;

    void Update()
    {
        Vector3 Distance = transform.position - Target.position;

        //-----DentroDelRango-----
        if (Distance.magnitude > 0.5f && Distance.magnitude < Range && !frezed)
        {
            //-----Movimiento-----
            transform.LookAt(Target);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }

        if (Distance <= 0.5f && CanAtack && !frezed)
        {
            CanAtack = false;
            Invoke("atack", 1f);
        }

        if (life <= 0)
        {
            frezed = true;
            Invoke(died,2f);
        }
    }

    void atack()
    {
        PlayerStats.life -= ZDamage;
        CanAtack = true;
    }

    void died()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("intarea"))
        { life -= PlayerStats.atackDamage; }
    }*/
}
