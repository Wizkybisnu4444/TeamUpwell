using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscrolling_script : MonoBehaviour
{
    public float speed = 50f;
    private Vector3 StartPosition;


    // Start is called before the first frame update
    void Start()
    {

        StartPosition = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < -539.4224f)
        {
            transform.position = StartPosition;
        }

    }
}
