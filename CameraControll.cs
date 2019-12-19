using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraControll : MonoBehaviour
{

    public GameObject mainCamera;              //メインカメラ格納用
    //private GameObject playerObject;            //回転の中心となるプレイヤー格納用
    private PhotonView photonView;
    public float rotateSpeed = 2.0f;            //回転の速さ

    //呼び出し時に実行される関数
    void Start()
    {

        photonView = GetComponent<PhotonView>();

        //メインカメラとユニティちゃんをそれぞれ取得
        //mainCamera = Camera.main.gameObject;
        //playerObject = GameObject.Find("unitychan");
    }


    //単位時間ごとに実行される関数
    void Update()
    {
        /*        if (photonView.IsMine == false) { return; }
                if (mainCamera == false)
                {
                    Camera.main.gameObject.SetActive(false);
                    mainCamera.SetActive(true);
                }*/
                Vector3 v = transform.position;
                v.z -= 5;
                v.y += 6;
                Camera.main.transform.position = v;

        /*        float angle = Input.GetAxis("Horizontal") * rotateSpeed;

                //プレイヤー位置情報
                Vector3 playerPos = photonView.transform.position;

                //カメラを回転させる
                transform.RotateAround(playerPos, Vector3.up, angle);

                //rotateCameraの呼び出し
                rotateCamera();*/
    }


    //カメラを回転させる関数
    private void rotateCamera()
    {
/*        if (Input.GetMouseButton(0))
        {
            //Vector3でX,Y方向の回転の度合いを定義
            Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, *//*Input.GetAxis("Mouse Y") * rotateSpeed*//*0, 0);

            //transform.RotateAround()をしようしてメインカメラを回転させる
            mainCamera.transform.RotateAround(photonView.transform.position, Vector3.up, angle.x);
            mainCamera.transform.RotateAround(photonView.transform.position, transform.right, angle.y);
        }
        */
    }
    
}