using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class CamControl : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	private Quaternion head;
	private Vector3 velocity = Vector3.zero;

    
    // Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		transform.rotation = player.transform.rotation;
		transform.position = player.transform.position + offset;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, 0.7F);
		transform.rotation = player.transform.rotation;
	}
}
