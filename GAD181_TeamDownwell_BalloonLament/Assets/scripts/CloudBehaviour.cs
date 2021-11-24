using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBehaviour : MonoBehaviour
{
    public int health = 2;

    private ScoreKeeper myScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.name.Contains("bullet01"))
        {
            --health;
            if (health < 1)
            {
                Destroy(gameObject);

                myScore = GetComponent<ScoreKeeper>();

                myScore.AddToScore;

            }
        }
    }
}
