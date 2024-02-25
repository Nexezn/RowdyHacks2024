using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    [SerializeField] GameObject laser;
    [SerializeField] MomDino momDino;

    public void Shoot(Vector3 aim){
        GameObject newlaser = Instantiate(laser,transform.position,Quaternion.identity);
        newlaser.transform.rotation = Quaternion.LookRotation(transform.forward,aim - transform.position);
        newlaser.GetComponent<Rigidbody2D>().velocity = newlaser.transform.up * momDino.GetShootSpeed();
        Destroy(newlaser,10);
    }
}
