using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour
{
    Light Luz;
    void Start()
    {
        Luz = GetComponent<Light>();
    }
    void Update()
    {
        if(Day.day == true){Luz.enabled = false;}
        if(Day.day == false){Luz.enabled = true;}
    }
}
