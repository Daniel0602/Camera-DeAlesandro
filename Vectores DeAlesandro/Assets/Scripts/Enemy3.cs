using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    [SerializeField][Range(0, 1)] int EnemyType;
    [SerializeField] Transform Target;
    float Speed = 1f;

    Vector3 RelativePosition;
    Quaternion targetRotation;

    public float speedRotation;

    void Start()
    {

    }

    void Update()
    {
        switch(EnemyType)
        {
            case 0:
            
            RelativePosition = Target.position - transform.position;
            targetRotation = Quaternion.LookRotation(RelativePosition);
            transform.rotation = Quaternion.Lerp(transform.rotation,targetRotation,speedRotation * Time.deltaTime);

            break;


            case 1:

            Vector3 Direction = transform.position - Target.position;
            transform.LookAt(Target);
            if(Direction.magnitude > 2)
            {
                transform.Translate(Direction * Speed * Time.deltaTime);
            }

            break;
        }
    }
}
