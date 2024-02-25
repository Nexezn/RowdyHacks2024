using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDino : MonoBehaviour
{

    [Header("Outside Objects")]
    [SerializeField] MomDinoSO momDinoSO;

    [Header("Stats")]

    [SerializeField] float walkSpeed = 5f;
    [SerializeField] float shootSpeed = 3f;

    [Header("Time for Status Affects")]

    [SerializeField] float powerupTime = 5f;
    [SerializeField] float debufTime = 5f;

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


    public float GetWalkSpeed() {return walkSpeed;}
    public float GetShootSpeed() {return shootSpeed;}
    public Rigidbody2D GetRigid() {return rigid;}

    public void SetWalkSpeed(float speed) {walkSpeed = speed;}
    public void SetShootSpeed(float speed) {shootSpeed = speed;}
}
