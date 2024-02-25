using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDino : MonoBehaviour
{

    [Header("Stats")]

    [SerializeField] float walkSpeed = 5f;
    [SerializeField] float shootSpeed = 3f;

    public float modSpeed;

    [Header("References")]
    [SerializeField] List<GameObject> livingHealth;

    private GameObject[] foundBabyObjects;

    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        modSpeed = walkSpeed;
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<GrabBranch>() != null){
            ProtectDinoAll();
            other.gameObject.SetActive(false);
        }
        if(other.GetComponent<Meteor>() != null){
            Debug.Log("Changing speed");
            StartCoroutine(ChangeSpeed());
            Destroy(other.gameObject);
        }
        
    }

    private void ProtectDinoAll(){
        foreach (GameObject i in livingHealth){
            if (i != null){
                i.GetComponent<BabyDino>().ProtectDino();
            }
        }
    }

    IEnumerator ChangeSpeed(){
        UpdateSpeed(walkSpeed/2);
        yield return new WaitForSeconds(3.0f);
        UpdateSpeed(walkSpeed);
    }

    public void UpdateSpeed(float speed){
        modSpeed = speed;
    }

    public void ImproveSpeed(float speed){}

    public float GetWalkSpeed() {return modSpeed;}
    public float GetShootSpeed() {return this.shootSpeed;}
    public Rigidbody2D GetRigid() {return this.rigid;}

    public void SetWalkSpeed(float speed) {this.walkSpeed = speed;}
    public void SetShootSpeed(float speed) {this.shootSpeed = speed;}
}
