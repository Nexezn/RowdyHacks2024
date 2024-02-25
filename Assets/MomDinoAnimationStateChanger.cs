using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDinoAnimationStateChanger : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] string currentState = "Idle";


    public void ChangeAnimationState(string newState){
        if(currentState == newState){
            return;
        }

        currentState = newState;
        animator.Play(currentState);
    }
}
