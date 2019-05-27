using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonManager : Photon.MonoBehaviour {

    public GameObject player;
    [SerializeField]
    private GameObject LobbyCamera;

    // Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("1.0");
	}
	
	void OnJoinedLobby () {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions() { maxPlayers = 2 }, TypedLobby.Default);
	}

    void OnJoinedRoom() {
        PhotonNetwork.Instantiate("mc1", player.transform.position, Quaternion.identity, 0);
        LobbyCamera.SetActive(false);
    }
}
