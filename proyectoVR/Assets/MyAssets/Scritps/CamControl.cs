using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class CamControl : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	private Quaternion head;
    
    
    // Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;

		//head = InputTracking.GetLocalRotation(VRNode.Head);
        //transform.position = player.transform.position;
		transform.rotation = player.transform.rotation;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//head = InputTracking.GetLocalRotation(VRNode.Head);
        //transform.position = player.transform.position;
		//transform.rotation = head;
		transform.position = player.transform.position + offset;
		transform.rotation = player.transform.rotation;
	}
}
