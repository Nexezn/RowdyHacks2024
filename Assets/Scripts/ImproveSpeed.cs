using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImproveSpeed : MonoBehaviour
{
    [Header("Increase")]
    [SerializeField] float increase = 2f;

    void OnTriggerEnter2D(Collider2D obj){
        if(obj.gameObject.tag == "Player") {
            obj.GetComponent<MomDino>().ImproveSpeed(increase);
            Destroy(this.gameObject);
        }
    }
}
