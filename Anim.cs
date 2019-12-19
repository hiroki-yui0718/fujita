using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(PhotonTransformView))]


public class Anim : MonoBehaviour
{
    public static bool Look;
    private Vector3 LookEnemy;
    private Vector3 Target; 
    private Animator anim;
    public LayerMask Layer;
    float speed = 1f;
    private RaycastHit hit;
    private PhotonView photonView;

    public GameObject T;   
    public int Ts;

 
    // Start is called before the first frame update
    void Start()
    {
        Look = false;
        anim = GetComponent<Animator>();
        photonView = GetComponent<PhotonView>();
        
        Debug.Log(anim);
    }

    public static float x;
    public static float z;

    // Update is called once per frame
    public void FixedUpdate()
    {
        //排他制御
        if (photonView.IsMine == false){return;}

        
        x = Input.GetAxis("Horizontal") * speed;
        z = Input.GetAxis("Vertical") * speed;
        anim.SetFloat("move X",Input.GetAxis("Horizontal"));
        anim.SetFloat("move Z", Input.GetAxis("Vertical"));
        
        //Zでアニメーション
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetTrigger("RSkillAttack");
        }

        transform.position += new Vector3(x, 0, z);

        //T:相手
        if (T != null)
        {
             Target = T.transform.position - this.transform.position;
             if (!Physics.Raycast(this.transform.position, Target, 10f, Layer))
             {
                 Debug.Log("LookOn");
                //近接判定
                Look = true;
             }
             else
             {
                 Look = false;
             }
        }
        //アニメーション
        if (Look)
        {
            if (x == 0 && z == 0)
            {
                if (!Physics.Raycast(this.transform.position, Target, 10f, Layer))
                {
                    Vector3 trunSpeed = Vector3.RotateTowards(transform.forward, Target, 5 * Time.deltaTime, 0f);
                    this.transform.rotation = Quaternion.LookRotation(trunSpeed);
                    anim.SetBool("Attack", true);
                }
            }
        }




    }
    private void OnTriggerStay(Collider other)
    {
        //敵だったら
        if ((gameObject.tag == "red" && other.tag == "blue") || (gameObject.tag == "blue" && other.tag == "red"))
        {
            //
            if (T == null)
            {
                T = other.gameObject;
                anim.SetBool("Attack", true);

            }
            //離れる判定
            if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                || (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && Look == true)
            {
                Debug.Log("LookOut");
                Look = false;
                anim.SetBool("Attack", false);
            }
        } 
    }

    private void Update()
    {
        //カメラ
        /*if (photonView.IsMine == false) { return; }
        Vector3 v = transform.position;
        v.z -= 5;
        v.y += 6;
        Camera.main.transform.position = v; */
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("LookOut");
        anim.SetBool("Attack", false);
        Look = false;
        if(T == other.gameObject)
        {
            T = null;
        }
    }

    void SkillEnd()
    {
        anim.SetTrigger("SkillEnd");
    }

}
