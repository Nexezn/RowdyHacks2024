using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float timeToLive = 3.0f;
    void Start()
    {
        StartCoroutine(Protecc());
    }

    IEnumerator Protecc(){
        yield return new WaitForSeconds(timeToLive);
        gameObject.SetActive(false);
    }
}
