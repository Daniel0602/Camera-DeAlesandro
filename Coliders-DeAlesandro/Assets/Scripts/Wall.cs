using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [Range(0, 10)] public float TimeTouched = 0f;

    private void OnCollisionStay(Collision other)
    {
        TimeTouched += 1 * Time.deltaTime;
        if(TimeTouched >= 2)
        {
            transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            transform.rotation = Random.rotation;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        TimeTouched = 0;
    }

    void Update()
    {
        Debug.Log(TimeTouched);
    }
}
