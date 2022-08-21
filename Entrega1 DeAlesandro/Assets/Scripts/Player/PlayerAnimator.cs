using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] Animator PlayerAnimatorS;

    void Update()
    {
        if(Input.GetKeyDown("w")){PlayerAnimatorS.SetTrigger("forward");}
        if(Input.GetKeyDown("s")){PlayerAnimatorS.SetTrigger("back");}
        if(Input.GetKeyDown("d")){PlayerAnimatorS.SetTrigger("right");}
        if(Input.GetKeyDown("a")){PlayerAnimatorS.SetTrigger("left");}
    }
}
