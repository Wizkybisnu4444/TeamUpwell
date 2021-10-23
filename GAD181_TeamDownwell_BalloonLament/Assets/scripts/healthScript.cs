using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    public GameObject healthI;
    public GameObject healthII;
    public GameObject healthIII;
    public int healthN = 0;
    // Start is called before the first frame update
    void Start()
    {
        healthN = 3;
        healthI.gameObject.SetActive(true);
        healthII.gameObject.SetActive(true);
        healthIII.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthN > 0)
        {
            if (Input.GetKeyDown("z"))
            {
                if (healthN > 0)
                {
                    --healthN;
                    if (healthN == 2)
                    {
                        healthIII.gameObject.SetActive(false);
                        healthI.gameObject.SetActive(true);
                        healthII.gameObject.SetActive(true);
                    }
                    if (healthN == 1)
                    {
                        healthIII.gameObject.SetActive(false);
                        healthII.gameObject.SetActive(false);
                        healthI.gameObject.SetActive(true);
                    }
                    if (healthN == 0)
                    {

                        healthI.gameObject.SetActive(false);
                        healthII.gameObject.SetActive(false);
                        healthIII.gameObject.SetActive(false);
                    }
                }
            }
            if (Input.GetKeyDown("x"))
            {
                if (healthN < 3)
                {
                    ++healthN;
                    if (healthN == 2)
                    {
                        healthIII.gameObject.SetActive(false);
                        healthI.gameObject.SetActive(true);
                        healthII.gameObject.SetActive(true);
                    }
                    if (healthN == 3)
                    {
                        healthI.gameObject.SetActive(true);
                        healthII.gameObject.SetActive(true);
                        healthIII.gameObject.SetActive(true);
                    }
                }
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("whiteGhost"))
        {
            --healthN;
            if (healthN == 2)
            {
                healthIII.gameObject.SetActive(false);
                healthI.gameObject.SetActive(true);
                healthII.gameObject.SetActive(true);
            }
            if (healthN == 1)
            {
                healthIII.gameObject.SetActive(false);
                healthII.gameObject.SetActive(false);
                healthI.gameObject.SetActive(true);
            }
            if (healthN == 0)
            {

                healthI.gameObject.SetActive(false);
                healthII.gameObject.SetActive(false);
                healthIII.gameObject.SetActive(false);
            }
        }
        if (collision.gameObject.name.Contains("redGhost"))
        {
            healthN = 0;
            healthI.gameObject.SetActive(false);
            healthII.gameObject.SetActive(false);
            healthIII.gameObject.SetActive(false);
        }
    }
}