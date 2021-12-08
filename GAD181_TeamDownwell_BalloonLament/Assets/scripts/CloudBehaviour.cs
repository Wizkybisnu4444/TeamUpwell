using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehaviour : MonoBehaviour
{
    public int health = 0;
    public GameObject player;

    //private ScoreKeeper myScore;

    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        player = GameObject.Find("PlayerSpriteGreen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.name.Contains("FlameBall")||collision.gameObject.name.Contains("TripleBall"))
        {
            --health;
            if (health < 1)
            {
                player.GetComponent<healthScript>().cloudhit = true;
                player.GetComponent<ScoreKeeper>().cloud = true;
                Destroy(gameObject);
                //myScore = GetComponent<ScoreKeeper>();
                //myScore.AddToScore;
            }
        }
    }
}
