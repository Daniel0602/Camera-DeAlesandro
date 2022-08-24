using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    [SerializeField] Animator ZombieAnimator;

    [SerializeField] Transform Target;

    public int ZDamage = 1;
    public int life = 10;
    public float Speed = 1f;
    public float Range = 10f;
    public bool frezed;
    public bool CanAtack = true;

    void Update()
    {
        Debug.Log("Vida Del Jugador " + PlayerStats.life);
        transform.LookAt(Target);

        Vector3 Dir = transform.position - Target.position;
        if (Dir.magnitude > 0.5 && Dir.magnitude < Range && !frezed)
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            if (!IsAnimation("walk")) ZombieAnimator.SetTrigger("walk");
        }
        else
        {
            if (!IsAnimation("idle")) ZombieAnimator.SetTrigger("idle");
        }

        if (Dir.magnitude <= 0.5 && CanAtack && !frezed)
        {
            Invoke("atack", 1f);
            if (!IsAnimation("atack")) ZombieAnimator.SetTrigger("atack");
            CanAtack = false;
        }
        if (life <= 0) { if (!IsAnimation("die")) ZombieAnimator.SetBool("die", true); Invoke("died",3f); frezed = true; }
    }

    bool IsAnimation(string anim)
    { return ZombieAnimator.GetCurrentAnimatorStateInfo(0).IsName(anim); }

    void atack() { PlayerStats.life -= ZDamage; CanAtack = true; }

    void died() { Destroy(gameObject); }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("intarea"))
        { life -= PlayerStats.atackDamage; }
    }
}