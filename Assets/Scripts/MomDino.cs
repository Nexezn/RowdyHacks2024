using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDino : MonoBehaviour
{

    [Header("Stats")]

    [SerializeField] float walkSpeed = 5f;
    [SerializeField] float shootSpeed = 3f;

    private BabyDino[] foundBabyObjects;

    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        foundBabyObjects = FindObjectsOfType<BabyDino>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Protecc");
        if(other.gameObject.GetComponent<Branch>() != null){
            ProtectDino();
            other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Branch>() != null){
            ProtectDino();
        }
        other.gameObject.SetActive(false);
        
    }

    private void ProtectDino(){
        for (var i = 0; i < foundBabyObjects.Length; i++){
            if (foundBabyObjects[i] != null){
                foundBabyObjects[i].GetComponent<BabyDino>().ProtectDino();
            }
        }
    }

    public float GetWalkSpeed() {return this.walkSpeed;}
    public float GetShootSpeed() {return this.shootSpeed;}
    public Rigidbody2D GetRigid() {return this.rigid;}

    public void SetWalkSpeed(float speed) {this.walkSpeed = speed;}
    public void SetShootSpeed(float speed) {this.shootSpeed = speed;}
}
