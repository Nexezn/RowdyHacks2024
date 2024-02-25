using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDino : MonoBehaviour
{

    //[SerializeField] CharacterMovement movement;

    [Header("Stats")]

    [SerializeField] float walkSpeed = 5f;

    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
         rigid = GetComponent<Rigidbody2D>();
        //movement.MoveBaby(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ProtectDino(){
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    public float GetWalkSpeed() {return this.walkSpeed;}
    public Rigidbody2D GetRigid() {return this.rigid;}
}
