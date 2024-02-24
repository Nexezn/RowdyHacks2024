using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawer : MonoBehaviour
{
    
    [SerializeField] private GameObject meteorPrefab;
    [SerializeField] private GameObject PowerUpPrefab;
    [SerializeField] private int spawnRange;
    [SerializeField] private bool stopSpawning;
    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnDelay;
    // Start is called before the first frame update
   void Start()
    {
        InvokeRepeating("SpawnItemRandom", spawnTime, spawnDelay);
    }

    void SpawnItemRandom(){
        Instantiate(meteorPrefab, transform.position, transform.rotation);

        if(stopSpawning){
            CancelInvoke("SpawnItemRandom");
        }
    }
}
