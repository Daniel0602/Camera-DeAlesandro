using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProces : MonoBehaviour
{
    public PostProcessVolume NightVision;

    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            if (NightVision.enabled)
            {
                NightVision.enabled = false;
            }
            else
            {
                NightVision.enabled = true;
            }
        }
    }
}
