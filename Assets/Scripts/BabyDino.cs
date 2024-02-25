using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDino : MonoBehaviour
{

    [SerializeField] CharacterMovement movement;
    [SerializeField] BabyDinoAnimationStateChanger animationStateChanger;
    [SerializeField] LevelManager levelManager;

    [Header("Stats")]

    [SerializeField] float walkSpeed = 5f;

    Rigidbody2D rigid;

    [Header("Boundery")]
    [SerializeField] float boundery = 5f;
    [SerializeField] float height = -5f;

    [Header("Movement Time")]
    [SerializeField] float pause = 2f;
    [SerializeField] float move = 4f;

    private Vector3 endpoints;

    // Start is called before the first frame update
    void Start()
    {
         rigid = GetComponent<Rigidbody2D>();
        MoveBaby();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveBaby() {

        StartCoroutine(MoveRoutine());
        IEnumerator MoveRoutine() {
            while(true){
                yield return new WaitForSeconds(pause);

                Vector3 currentPos = this.transform.position;

                float timer = 0f;
                endpoints.Set(Random.Range(-boundery, boundery), height, 0);
                while(timer < move){
                    
                    timer+=Time.deltaTime * (1f / this.GetWalkSpeed());
                    this.transform.localPosition = Vector3.Lerp(currentPos,endpoints,timer);
                    animationStateChanger.ChangeAnimationState("Walk");
                    yield return null;
                }

                this.transform.localPosition = endpoints;
                animationStateChanger.ChangeAnimationState("Idle");
                
            }

        }
        
    }

    public void ProtectDino(){
        this.transform.GetChild(0).gameObject.SetActive(true);
        //this.transform.GetChild(0).GetComponent<Branch>().Protecc2();
    }

    public void LoseDino(){
        levelManager.ReduceDino();
        Destroy(this.gameObject);
    }

    public float GetWalkSpeed() {return this.walkSpeed;}
    public Rigidbody2D GetRigid() {return this.rigid;}
}
