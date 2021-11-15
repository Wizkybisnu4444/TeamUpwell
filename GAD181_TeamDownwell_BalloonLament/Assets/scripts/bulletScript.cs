using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public Rigidbody2D rb2D;
    private GameObject BulletSpawn;
    public float speed;



    void Awake()
    {
       // rb2D = gameObject.AddComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        BulletSpawn = GameObject.FindWithTag("emitter");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb2D.AddForce(Player.transform.up * speed);
        

        rb2D.AddForce(transform.up * speed, ForceMode2D.Impulse);

    }
}
