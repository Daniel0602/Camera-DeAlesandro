using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Zombie Data", menuName = "Crear ZombieData")]
public class ZombieData : ScriptableObject
{
    [Header("Stats Del Zombie")]
    [Tooltip("Daño Del Zombie")] public int ZDamage = 1;
    [Tooltip("Vida Del Zombie")] public int life = 10;
    [Tooltip("Velocidad Del Zombie")] public float Speed = 1f;
    [Tooltip("Rango Del Zombie")] public float Range = 10f;
}
