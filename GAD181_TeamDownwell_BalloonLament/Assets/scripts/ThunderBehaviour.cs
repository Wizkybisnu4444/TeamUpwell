using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderBehaviour : MonoBehaviour
{
    public int health = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        player = GameObject.Find("PlayerSpriteGreen");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("bullet01"))
        {
            --health;
            if (health < 1)
            {
                player.GetComponent<healthScript>().thunderhit = true;
                player.GetComponent<ScoreKeeper>().thunder = true;
                Destroy(gameObject);
            }
        }
    }
}
