using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePoint : MonoBehaviour
{
    public GameObject Resource;
    public float MaxRange;

    [Range(0f,10f)] public float Secs;

    void Update()
    {
        Secs += 1 * Time.deltaTime;

        if(Secs >= 10f)
        {
            Secs -= 10f;

            Instantiate(Resource, transform.position + new Vector3(Random.Range(0 - MaxRange,MaxRange),0,Random.Range(0 - MaxRange,MaxRange)),transform.rotation );
        }
    }
}
