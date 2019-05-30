using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour {

    [SerializeField]
    private GameObject PlayerCam;
    [SerializeField]
    private MonoBehaviour[] ScriptToIgnore;

    PhotonView photonview;
    
    // Use this for initialization
	void Start () {
        photonview = GetComponent<PhotonView>();
        
		
	}

    void initialize() {
        if (photonview.isMine)
        {
        }
        else
        {
            PlayerCam.SetActive(false);
            foreach (MonoBehaviour item in ScriptToIgnore)
            {
                //item.gameObject.SetActive(false);
                item.enabled = false;
            }
        }
    }
}
