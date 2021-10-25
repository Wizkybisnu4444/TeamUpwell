using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour

{
    public GameObject BulletPreFab;
    public Transform playerPos;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){

            shoot();

        }

        void shoot()
        {
          Instantiate(BulletPreFab, playerPos.position, Quaternion.identity);
        
        }
    }
}
