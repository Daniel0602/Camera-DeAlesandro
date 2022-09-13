using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Events : MonoBehaviour
{
    public TMP_Text Texto;
    public string[] States;

    public UnityEvent OnDamageU;
    public UnityEvent OnWinU;
    public UnityEvent OnLoseU;

    public void DamagedU()
    {
        OnDamageU?.Invoke();
    }
    public  void WiningU()
    {
        OnWinU?.Invoke();
    }
    public  void LosedU()
    {
        OnLoseU?.Invoke();
    }

    private void Update()
    {
        Debug.Log(Cube.CubeLife);
    }
}
