using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform Player;

    void Update()
    {
        Vector3 PlayerXZ = new Vector3(Player.position.x,0,Player.position.z);

        transform.position = PlayerXZ;
    }
}
