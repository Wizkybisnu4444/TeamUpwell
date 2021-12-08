using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int health = 0;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        health = 2;
        player = GameObject.Find("PlayerSpriteGreen");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("FlameBall")||collision.gameObject.name.Contains("TripleBall"))
        {
            --health;
            if (health < 1)
            {
                player.GetComponent<healthScript>().ghosthit = true;
                player.GetComponent<ScoreKeeper>().ghost = true;
                Destroy(gameObject);
            }
        }
    }
}
