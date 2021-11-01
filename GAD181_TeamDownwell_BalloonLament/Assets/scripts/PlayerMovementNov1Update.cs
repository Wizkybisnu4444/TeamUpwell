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

    //Is the player floating left?
    public bool floatLeft;

    //Is the player floating right?
    public bool floatRight;

    //Is the player igniting the engine?
    public bool engineIgnition;

    //Gets the Rigidbody2D
    private void Awake()
    {
        this.RB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame and detects whether the player is pressing a key
    void Update()
    {
        //Left control
        if Input.GetKey(KeyCode.A){
            floatLeft = true; }
        else
            floatLeft = false;
        //Right control
        Input.GetKey(KeyCode.D);
        if Input.GetKey(KeyCode.A){
            floatRight = true;
        }
        else
            floatRight = false;
        //Engine on (up control)
        if Input.GetKey(KeyCode.Tab){
            engineIgnition = true;
        }
        else
            engineIgnition = false;
        }
    }

    // Fixed Update gives forces for each movement if controls for engine, left and right from update are active
    private void FixedUpdate()
    {
        if floatLeft = true; {
        this.rigidbody.AddForce(this.transform.left * this.floatingSpeed);
        }
        if (Input.GetKey(KeyCode.D){
        this.rigidbody.AddForce(this.transform.right * this.floatingSpeed);
        }
        if
        engineIgnition = true;
        {
        this.rigidbody.AddForce(this.transform.up * this.engineSpeed);
        }
        else
        {
        this.rigidbody.AddForce(this.transform.down * this.balloonDescentSpeed);
        }
    }

}
