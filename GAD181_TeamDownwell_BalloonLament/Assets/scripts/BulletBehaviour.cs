using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject ammo = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
            ammo.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up*50000);


        }
    }
}