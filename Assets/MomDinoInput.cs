using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDinoInput : MonoBehaviour
{

    [SerializeField] CharacterMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    void GetPlayerInput(){
        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.A)) { input.x += -1; }

        if(Input.GetKey(KeyCode.D)) { input.x += 1; }

        movement.MoveMom(input);
    }
}
