using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSkins : MonoBehaviour
{
    //public enum Zombie { SkinA, SkinB }
    //public Zombie ZombieSkin;

    public Material[] material;
    int skin;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        skin = Random.Range(0,material.Length);
        rend.sharedMaterial = material[skin];
    }

    /*void update()
    {
        switch (ZombieSkin)
        {
            case Zombie.SkinA:

                rend.sharedMaterial = material[0];

                break;
            case Zombie.SkinB:

                rend.sharedMaterial = material[1];

                break;
        }
    }*/
}
