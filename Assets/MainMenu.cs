using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject instructions;

    void Start(){
        ReturnToMainMenu();
    }

    public void StartGame() {
        SceneManager.LoadScene("level1");
    } 

    public void QuitGame() {
        Application.Quit();
    }

    public void CheckInstructions() {
        instructions.SetActive(true);
    }

    public void ReturnToMainMenu(){
        instructions.SetActive(false);
    }
}
