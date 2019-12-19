using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitBullet : MonoBehaviour
{
    private int target_HP,target_DP;
    private string targetName;
    private GameObject Target;
    public static int bullet_PP;
    
    
    // Start is called before the first frame update
    void Start()
    {
        bullet_PP = int.Parse(weponDataBase.weapon[1, 3]);
    }

    

    private void OnTriggerEnter(Collider c)
    {
        //敵 or 障害
        if (c.CompareTag("Enemy") || c.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
