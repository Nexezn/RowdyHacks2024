using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float timeToLive = 3.0f;
    void Start()
    {
    }

    void OnEnable(){
        StartCoroutine(Protecc());
    }

    public void Protecc2(){
        new WaitForSeconds(timeToLive);
        gameObject.SetActive(false);
    }

    IEnumerator Protecc(){
        while(true){
           yield return new WaitForSeconds(timeToLive);
            gameObject.SetActive(false); 
        }
    }
}
