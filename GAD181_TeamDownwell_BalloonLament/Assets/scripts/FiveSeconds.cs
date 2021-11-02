using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiveSeconds : MonoBehaviour
{
    GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        gameObject.transform.parent = canvas.transform;
    }

    // Update is called once per frame

    void OnCollisionEnter2D (Collision2D collision)
    {
        Destroy(gameObject);
    }
}
