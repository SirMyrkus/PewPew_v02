using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick_Controll : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField]
    FixedJoystick joystick;
    [SerializeField]
    float inputX, inputY;
    [SerializeField] GameObject Player;
    void Start()
    {
        
    }

   
    void Update()
    {
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;

        //Player.GetComponent<Rigidbody>().AddForce(transform.right * inputX * speed);
        //Player.GetComponent<Rigidbody>().AddForce(transform.forward * inputY * speed);


        Player.GetComponent<Rigidbody>().velocity = transform.right * inputX * speed;
        Player.GetComponent<Rigidbody>().velocity = transform.forward * inputY * speed;
    }
}

