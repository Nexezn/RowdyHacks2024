using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("Moveable Character")]
    [SerializeField] MomDino momDino;
    [SerializeField] List<BabyDinoAnimationStateChanger> animationStateChanger;
    //[SerializeField] BabyDino babyDino;

    [Header("Boundery")]
    [SerializeField] float boundery = 5f;
    [SerializeField] float height = -5f;

    [Header("Movement Time")]
    [SerializeField] float pause = 2f;
    [SerializeField] float move = 4f;

    private Vector3 endpoints;


    public void MoveMom(Vector3 direction) {
        Rigidbody2D rigid = momDino.GetRigid();

        float speed = momDino.GetWalkSpeed();

        rigid.velocity = direction * speed;

        if(direction.x != 0) {
            foreach (BabyDinoAnimationStateChanger state in animationStateChanger)
            {
                state.ChangeAnimationState("Walk");
            }
        }
        else
        {
             foreach (BabyDinoAnimationStateChanger state in animationStateChanger)
            {
                state.ChangeAnimationState("Idle");
            }
        }

        
    }

    /*
    public void MoveBaby(BabyDino babyDino) {

        StartCoroutine(MoveRoutine());
        IEnumerator MoveRoutine() {
            while(true){
                yield return new WaitForSeconds(pause);

                Vector3 currentPos = babyDino.transform.position;

                float timer = 0f;
                endpoints.Set(Random.Range(-boundery, boundery), height, 0);
                while(timer < move){
                    
                    timer+=Time.deltaTime * (1f / babyDino.GetWalkSpeed());
                    babyDino.transform.localPosition = Vector3.Lerp(currentPos,endpoints,timer);
                    yield return null;
                }

                babyDino.transform.localPosition = endpoints;
                
            }

        }
        
    }
    */
}
