using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody2D _rb;

    private bool _thrusting;

    public float _turnDirection;

    public int thrustSpeed;



    // Update is called once per frame
    void Update()
    {

        if (_rb != null)
        {
            ApplyInput();
        }

        _thrusting = Input.GetKey(KeyCode.Tab);

    }

    void FixedUpdate()
    {

        if (_thrusting)
        {
            _rb.AddForce(this.transform.up * this.thrustSpeed);
        }
    }


    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xForce = xInput * thrustSpeed * Time.deltaTime;

        Vector2 force = new Vector2(xForce, 0);

        _rb.AddForce(force);
    }

}
