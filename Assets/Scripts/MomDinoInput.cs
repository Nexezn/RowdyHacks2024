using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDinoInput : MonoBehaviour
{

    [SerializeField] MomDino momDino;
    [SerializeField] CharacterMovement movement;
    ShootLaser shootLaser;

    // Start is called before the first frame update
    void Start()
    {
        shootLaser = momDino.GetComponent<ShootLaser>();
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    void GetPlayerInput(){
        Vector3 input = Vector3.zero;

        if (Input.GetMouseButtonDown(0)){
            shootLaser.Shoot(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }

        if(Input.GetKey(KeyCode.A)) { input.x += -1; }

        if(Input.GetKey(KeyCode.D)) { input.x += 1; }

        movement.MoveMom(input);
    }
}
