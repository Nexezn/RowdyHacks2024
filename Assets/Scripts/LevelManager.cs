using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dinoCounterText;
    [SerializeField] private GameObject leftBranch;
    [SerializeField] private GameObject rightBranch;
    [SerializeField] private int max = 100;
    [SerializeField] private float waitTime = 3.0f;
    public int numDinos = 8;
    private int decision;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BranchSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        if (numDinos <= 0){
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ReduceDino(){
        dinoCounterText.text = numDinos.ToString();
        numDinos--;
    }

    IEnumerator BranchSpawner(){
        while (true){
            yield return new WaitForSeconds(waitTime);
            if (leftBranch.activeSelf == false){
                decision = Random.Range(0, max);
                if (decision == 0){
                    leftBranch.SetActive(true);
                }
            }
            if (rightBranch.activeSelf == false){
                decision = Random.Range(0, max);
                if (decision == 0){
                    rightBranch.SetActive(true);
                }
            }
        }
        yield return new WaitForSeconds(waitTime);
    }
}
