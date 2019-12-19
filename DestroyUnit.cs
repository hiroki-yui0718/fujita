using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class DestroyUnit : MonoBehaviourPunCallbacks
{
    private string Name;
    //private int HP;
    private int DP;

    private new PhotonView photonView;

    [SerializeField] int HP;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();

        if (photonView.name.Equals("PS-P01(Clone)")) //中量型
        {
            Name = BattleUnitData.unitName[0];
            HP   = BattleUnitData.unitData[0, 0];
            DP   = BattleUnitData.unitData[0, 1];
            
        }
        else if (photonView.name.Equals("PS-W01(Clone)")) //軽量型
        {
            Name = BattleUnitData.unitName[1];
            HP   = BattleUnitData.unitData[1, 0];
            DP   = BattleUnitData.unitData[1, 1];
        }
        else if (photonView.name.Equals("PS-G01(Clone)"))　//重量型
        {
            Name = BattleUnitData.unitName[2];
            HP   = BattleUnitData.unitData[2, 0];
            DP   = BattleUnitData.unitData[2, 1];
        }
        
    }

    //弾くらった時の処理
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            //HP =  HP - HitBullet.bullet_PP;
            //0Debug.Log(Name +":"+ HP);
            if(photonView.IsMine == false) { return; }
            photonView.RPC("HPdamage", RpcTarget.All, HitBullet.bullet_PP);

            if (HP <= 0)
            {
                Debug.Log("Destroy:" + Name);
                if (photonView.IsMine == false) { return; }
                PhotonNetwork.Destroy(this.gameObject);
            }
        }
    }

    //bup 相手の攻撃力
    [PunRPC]
    public void HPdamage(int bup)
    {
        HP -= bup;
        Debug.Log(Name + ":" + HP);
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
