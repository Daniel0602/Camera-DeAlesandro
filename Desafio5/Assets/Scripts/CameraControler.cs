using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public GameObject[] Cameras;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            Cameras[0].SetActive(false);
            Cameras[1].SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F2))
        {
            Cameras[0].SetActive(true);
            Cameras[1].SetActive(false);
        }
    }
}
