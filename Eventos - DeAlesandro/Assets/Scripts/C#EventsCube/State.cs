using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class State : MonoBehaviour
{
    public TMP_Text Texto;
    public string[] States;

    public static event Action OnDie;
    public static event Action OnWin;
    public static event Action OnLose;

    void Awake()
    {
        OnWin  += Win;
        OnDie += Die;
        OnLose += Lose;
    }

    public void Win()
    {
        Texto.text = States[0];
    }
    void Lose()
    {
        Texto.text = States[1];
    }
    void Die()
    {
        Texto.text = States[2];
        Cube.CubeLife = 10;
    }



    public static void Wining()
    {
        OnWin.Invoke();
    }
    public static void Loseing()
    {
        OnLose.Invoke();
    }
    public static void Dieing()
    {
        OnDie.Invoke();
    }
}
