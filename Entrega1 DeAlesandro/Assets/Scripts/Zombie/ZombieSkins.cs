using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSkins : MonoBehaviour
{
    public enum Zombie {SkinA,SkinB}
    public Zombie ZombieSkin;

    public Material[] material;
    public static int Skin;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();

        switch (ZombieSkin)
        {
            case Zombie.SkinA:

                rend.sharedMaterial = material[0];

                break;
            case Zombie.SkinB:

                rend.sharedMaterial = material[1];

                break;
        }
    }
}
