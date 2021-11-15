using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    public bool moveLeft = false;
    public bool moveRight = false;
    public bool facingRight = false;
    public float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 2) == 0)
        {
            moveRight = true;
        }
        else
        {
            moveLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight == true)
        {
            if (facingRight == false)
            {
                facingRight = true;
                transform.Rotate(new Vector3(0, 180, 0));
            }
            transform.position += transform.right * -1 * -speed * Time.deltaTime;
        }
        if (moveLeft == true)
        {
            if (facingRight == true)
            {
                facingRight = false;
                transform.Rotate(new Vector3(0, 180, 0));
            }
            transform.position += transform.right * -1 * -speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (moveRight == true)
        {
            moveRight = false;
            moveLeft = true;
        }
        else
        {
            moveLeft = false;
            moveRight = true;
        }
    }
}
