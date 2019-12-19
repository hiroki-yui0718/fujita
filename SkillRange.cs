using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillRange : MonoBehaviour
{
    public int num;

    // Start is called before the first frame update
    void Start()
    {

    }

    //cubeで攻撃
    private void OnDrawGizmos()
    {
        //Ray ray = new Ray(transform.position, transform.forward);

        Gizmos.DrawRay(transform.position, (transform.forward + (transform.right * 0.6f)) * 8f);
        Gizmos.DrawRay(transform.position, transform.forward + new Vector3(0.25f, 0, 1) * 10f);
        Gizmos.DrawRay(transform.position, transform.forward * 11f);
        Gizmos.DrawRay(transform.position, transform.forward + new Vector3(-0.25f, 0, 1) * 10f);
        Gizmos.DrawRay(transform.position, transform.forward + new Vector3(-0.6f, 0, 1) * 8f);

        Gizmos.DrawWireCube
            (transform.position + new Vector3(0.6f, 0, 1) * 8f, Vector3.one * 3);
        Gizmos.DrawWireCube
            (transform.position + new Vector3(0.25f, 0, 1) * 9.5f, Vector3.one * 3);
        Gizmos.DrawWireCube
            (transform.position + transform.forward * 10f, Vector3.one * 3);
        Gizmos.DrawWireCube
            (transform.position + new Vector3(-0.25f, 0, 1) * 9.5f, Vector3.one * 3);
        Gizmos.DrawWireCube
            (transform.position + new Vector3(-0.6f, 0, 1) * 8f, Vector3.one * 3);

    }
    // Update is called once per frame
    void Update()
    {
        if (Physics.BoxCast(transform.position, Vector3.one * 1.5f, transform.forward, new Quaternion(0, 0, 0, 0), 10f))
        {
                Debug.Log("当たるお");
                
        }
        
        if (Physics.BoxCast(transform.position, Vector3.one * 3f, transform.forward, new Quaternion(0, 0, 0, 0), 30f))
        {
                //Debug.Log("当たるおおおおおおおおおおおお");
        }
    }

    /*public void Range(int number)
    {


    }*/
}
