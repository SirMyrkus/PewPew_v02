using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick_Controll : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField]
    FixedJoystick joystick;
    [SerializeField]
    float inputX, inputY, dir;
    [SerializeField] GameObject Player;
    void Start()
    {
        
    }

   
    void Update()
    {
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;
        

        if (!(inputX == 0 || inputY == 0))
        {
            float rotY = Mathf.Atan2(inputY, inputX) * Mathf.Rad2Deg + 90;
            Player.transform.rotation = Quaternion.Euler(0, -rotY, 0);
        }

        Player.GetComponent<Rigidbody>().AddRelativeForce(Player.transform.forward * inputY * speed);
        Player.GetComponent<Rigidbody>().AddRelativeForce(Player.transform.right * -inputX * speed);
        //Player.GetComponent<Rigidbody>().AddForce(transform.forward * inputY * speed);


        //Player.GetComponent<Rigidbody>().velocity = transform.forward * (inputX + inputY) * speed;




        //Player.GetComponent<Rigidbody>().velocity = transform.forward * inputY * speed;
    }
}

