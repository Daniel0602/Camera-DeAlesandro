using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{
    public static int CubeLife = 10;
    
    void Update()
    {
        if(CubeLife <= 0)
        {
            State.Dieing();
        }
    }

}
