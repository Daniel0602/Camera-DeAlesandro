using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public AudioSource TeleportSound;

    public GameObject Player;
    public Transform FinalPoint;

    void OnCollisionEnter(Collision other)
    {
        if(other.transform.CompareTag("Player"))
        {
            TeleportSound.Play();
            Player.transform.position = FinalPoint.position;
        }
    }
}
