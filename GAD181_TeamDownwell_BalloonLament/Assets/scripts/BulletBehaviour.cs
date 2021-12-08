using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public GameObject tripleshot;
    public int bulletN = 0;
    public bool reload = false;
    public GameObject i;
    public GameObject ii;
    public GameObject iii;
    public GameObject iv;
    public GameObject v;
    public GameObject max;
    public AudioClip pew;
    public bool auto = false;
    public bool triple = false;
    public bool triplepower = false;

    // Start is called before the first frame update
    void Start()
    {
        bulletN = 5;
        i.SetActive(true);
        ii.SetActive(true);
        iii.SetActive(true);
        iv.SetActive(true);
        v.SetActive(true);
        max.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletN > 0)
        {
            if (Input.GetKeyDown("space"))
            {
                bulletN--;
                GetComponent<AudioSource>().PlayOneShot(pew);
                if (triplepower == true)
                {
                    GameObject ammo = Instantiate(tripleshot, gameObject.transform.position, gameObject.transform.rotation);
                    ammo.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 50000);
                }
                else
                {
                    GameObject ammo = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
                    ammo.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 50000);
                }
                if (bulletN == 4)
                {
                    max.SetActive(false);
                    v.SetActive(false);
                    i.SetActive(true);
                    ii.SetActive(true);
                    iii.SetActive(true);
                    iv.SetActive(true);
                    if (auto == false)
                    {
                        auto = true;
                        StartCoroutine(AutoReload());
                    }
                }
                else if (bulletN == 3)
                {
                    max.SetActive(false);
                    v.SetActive(false);
                    iv.SetActive(false);
                    i.SetActive(true);
                    ii.SetActive(true);
                    iii.SetActive(true);
                    if (auto == false)
                    {
                        auto = true;
                        StartCoroutine(AutoReload());
                    }

                }
                else if (bulletN == 2)
                {
                    max.SetActive(false);
                    v.SetActive(false);
                    iv.SetActive(false);
                    iii.SetActive(false);
                    i.SetActive(true);
                    ii.SetActive(true);
                    if (auto == false)
                    {
                        auto = true;
                        StartCoroutine(AutoReload());
                    }

                }
                else
                {
                    max.SetActive(false);
                    v.SetActive(false);
                    iv.SetActive(false);
                    iii.SetActive(false);
                    ii.SetActive(false);
                    i.SetActive(true);
                    if (auto == false)
                    {
                        auto = true;
                        StartCoroutine(AutoReload());
                    }
                }
            }
        }
        if (bulletN < 1 && reload == false)
        {
            auto = false;
            reload = true;
            max.SetActive(false);
            v.SetActive(false);
            iv.SetActive(false);
            iii.SetActive(false);
            ii.SetActive(false);
            i.SetActive(false);
            StartCoroutine(Reload());
        }
        if (triple == true)
        {
            triple = false;
            triplepower = true;
            StartCoroutine(TripleLimit());
        }
    }
    IEnumerator Reload()
    {
        this.GetComponent<ScoreKeeper>().reload = true;
        yield return new WaitForSeconds(2f);
        bulletN = 5;
        i.SetActive(true);
        ii.SetActive(true);
        iii.SetActive(true);
        iv.SetActive(true);
        v.SetActive(true);
        max.SetActive(true);
        reload = false;
    }
    IEnumerator AutoReload()
    {
        yield return new WaitForSeconds(5f);
            if (auto == true)
            {
                auto = false;
                StartCoroutine(Reload());
            }

    }
    IEnumerator TripleLimit()
    {
        yield return new WaitForSeconds(10f);
        triplepower = false;
    }
}