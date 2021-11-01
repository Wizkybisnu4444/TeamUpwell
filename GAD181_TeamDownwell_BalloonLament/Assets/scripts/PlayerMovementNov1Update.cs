using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNov1Update : MonoBehaviour
{
    //RB is calling for Rigidbody2D
    public new Rigidbody2D RB;

    //Horizontal Position float Horizontal
    float horizontal;

    //Vertical Position float Vertical
    float vertical;

    //Limits the diagonal speeds
    float diagonalSpeedLimit = 1.0f;

    //The speed of floating the balloon left or right
    public float floatingSpeed = 20.0f;

    //The speed of the balloon in an upward direction when engaging engine
    public float engineSpeed = 100.0f;

    //The constant speed of the balloon as it decends down the screen
    public float balloonDescentSpeed = 10.0f;

    //Gets the Rigidbody2D
    private void Awake()
    {
        this.RB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame and detects whether the player is pressing a key
    void Update()
    {
        //Left control
        Input.GetKey(KeyCode.A);
        //Right control
        Input.GetKey(KeyCode.D);
        //Engine on (up control)
        Input.GetKey(KeyCode.Tab);
    }

    // Fixed Update gives forces for each movement if controls for engine, left and right from update are active
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) {
            this.rigidbody.AddForce(this.transform.left * this.floatingSpeed);
        }

        else if (Input.GetKey(KeyCode.D){
            this.rigidbody.AddForce(this.transform.right * this.floatingSpeed);
        } 

    }


    //Still need auto descend. . .
}
