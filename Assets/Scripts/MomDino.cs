using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDino : MonoBehaviour
{

    [Header("Stats")]

    [SerializeField] float walkSpeed = 5f;
    [SerializeField] float shootSpeed = 3f;

    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetWalkSpeed() {return this.walkSpeed;}
    public float GetShootSpeed() {return this.shootSpeed;}
    public Rigidbody2D GetRigid() {return this.rigid;}

    public void SetWalkSpeed(float speed) {this.walkSpeed = speed;}
    public void SetShootSpeed(float speed) {this.shootSpeed = speed;}
}
