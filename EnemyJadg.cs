using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJadg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Player")
        {
            if (other.tag == "Red")
            {
                gameObject.tag = "red";
            }
            else if (other.tag == "Blue")
            {
                gameObject.tag = "blue";
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
