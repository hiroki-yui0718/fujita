using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // photonサーバに接続
    void Start()
    {
        // Photon接続
        PhotonNetwork.ConnectUsingSettings();
    }


    //マスターサーバに接続
    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster");

        // ロビーに入る
        JoinLobby();
    }

    // ロビーに入る
    private void JoinLobby()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    // ロビーに入った時
    public override void OnJoinedLobby()
    {
        Debug.Log("OnJoinedLobby");
        PhotonNetwork.JoinRandomRoom();
    }

    //なかった場合room作る
    public  override void OnJoinRandomFailed(short returnCode, string message)
    {
        //最大人数１０人
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 10;
        PhotonNetwork.CreateRoom(null, roomOptions);
        Debug.Log("ルーム入室に失敗したのでルームを作成します");
    }


    //部屋に入った時の処理
    public override void OnJoinedRoom()
    {
        Debug.Log("入室成功");

        switch (PhotonNetwork.LocalPlayer.ActorNumber)
        {
            case 1:
                PhotonNetwork.Instantiate("PS-G01", new Vector3(49, 0, 18), Quaternion.identity);
                break;
            case 2:
                PhotonNetwork.Instantiate("PS-G01", new Vector3(46, 0, 78), Quaternion.identity);
                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 9:

                break;
            case 10:

                break;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
