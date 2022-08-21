using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour
{   //-----Time-----
    public float timeMultiplier = 1f;

    [Range(0f,60f)]public float seconds;
    [Range(0,60)]public int minutes;
    [Range(0,24)]public int hours;
    public int days;
//-----Luz-----
    public static bool day;
    public int dayHours;
    Light sun;
    void Start(){sun = GetComponent<Light>();}

    void Update()
    {
        seconds += timeMultiplier * Time.deltaTime;

        if(seconds >= 60){seconds-=60;minutes++;}
        if(minutes >= 60){minutes-=60;hours++;}
        if(hours >= 24){hours-=24;days++;}

        if(hours <= 12){day=true;}
        if(hours >= 13){day=false;}

        if(day==true){sun.intensity = 1;}
        if(day==false){sun.intensity = 0;}
    }
}
