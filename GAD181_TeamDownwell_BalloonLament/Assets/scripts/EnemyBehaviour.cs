using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("/Canvas/PlayerSpriteGreen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.name.Contains("bullet01"))
        {
            player.GetComponent<healthScript>().kills++;
            Destroy(gameObject);
        }
    }
}