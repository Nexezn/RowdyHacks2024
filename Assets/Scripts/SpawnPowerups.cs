using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerups : MonoBehaviour
{
    [SerializeField] GameObject powerup;
    [SerializeField] float spawnRangeX = 7;
    [SerializeField] float spawnHeight = -3;
    [SerializeField] float lifetime = 10;
    [SerializeField] float waitTime = 5;


    // Start is called before the first frame update
    void Start()
    {
        SpawnAllPowerups();
    }

    void SpawnAllPowerups() {
        StartCoroutine(SpawnPowerupsRoutine());
        IEnumerator SpawnPowerupsRoutine() {
            while (true)
            {
                yield return new WaitForSeconds(waitTime);
                SpawnAt();
            }
        }
    }

    void SpawnAt() {
        float randomXlocation = Random.Range(-spawnRangeX,spawnRangeX);

        GameObject newpowerup = Instantiate(powerup,new Vector3(randomXlocation,spawnHeight,0),Quaternion.identity);
        Destroy(newpowerup,lifetime);
    }
}
