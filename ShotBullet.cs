using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour
{
    public GameObject bullet;
    public float shotSpeed;
    private int Intarval;
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Anim.Look == true && (Anim.x == 0 && Anim.z == 0))
        {
            Intarval += 5;
            if (Intarval % 60 == 0)
            {
                Debug.Log("shot");
                GameObject bullets = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                bullets.GetComponent<Rigidbody>().AddForce(transform.forward * shotSpeed);
                Destroy(bullets, 0.4f);
            }
        }
    }

    public void Shot()
    {

    }
}
