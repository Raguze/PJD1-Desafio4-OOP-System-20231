using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public Joystick joystick;
    public PlayerController playerController;

    //public List<Player> players;

    private void Awake()
    {
        Joystick[] joysticks = FindObjectsOfType<Joystick>();
        playerController = FindObjectOfType<PlayerController>();

        //joystick = FindObjectOfType<Joystick>();
        //playerController = FindObjectOfType<PlayerController>();

        foreach (var joystick in joysticks)
        {
            if(joystick.name == "LeftJoystick")
            {
                playerController.LeftJoystick = joystick;
            }

            if(joystick.name.StartsWith("Right"))
            {
                playerController.RightJoystick = joystick;
            }
        }

        CameraController cameraController = Camera.main.GetComponent<CameraController>();
        cameraController.PlayerController = playerController;
    }

    private void Start()
    {
       


        


    }
}
