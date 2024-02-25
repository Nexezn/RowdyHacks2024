using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float meteorSpeed = 5f;
    [SerializeField] private float rotationSpeed= 1f;
    [SerializeField] private float boundary = 8.0f;
    private Vector2 target;
    //[SerializeField] private int meteorDamage = 1;
    // Start is called before the first frame update
    void Start()
    {
        target.Set(Random.Range( -boundary, boundary), -5.0f);
        
    }

    private void FixedUpdate(){

        //Vector2 direction = (target.position - transform.position).normalized;

        rb.velocity = target * meteorSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<BabyDino>() != null){
            other.GetComponent<BabyDino>().LoseDino();
        }
        Destroy(this.gameObject);
    }
}
