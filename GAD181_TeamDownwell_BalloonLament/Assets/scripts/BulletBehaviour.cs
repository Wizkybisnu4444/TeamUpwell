using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public int bulletN = 0;
    public bool reload = false;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject i;
    public GameObject ii;
    public GameObject iii;
    public GameObject iv;
    public GameObject v;
    public GameObject max;
    public AudioClip pew;
=======
=======
>>>>>>> parent of 63e033ce (stuff clashing, trying to fix)
=======
>>>>>>> parent of 63e033ce (stuff clashing, trying to fix)

>>>>>>> parent of 63e033ce (stuff clashing, trying to fix)
    // Start is called before the first frame update
    void Start()
    {
        bulletN = 5;
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
                GameObject ammo = Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
                ammo.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 50000);
            }
        }
        if (bulletN < 1 && reload == false)
        {
            reload = true;
            StartCoroutine(Reload());
        }
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1f);
        bulletN = 5;
        reload = false;
    }
}