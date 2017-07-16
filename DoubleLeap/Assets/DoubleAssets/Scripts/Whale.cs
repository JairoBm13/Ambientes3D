using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour {

	public Transform shamu;
	public float velocity;
	private Rigidbody cuerpoDeFoca;
	private Vector3 initialShamu;

	// Use this for initialization
	void Start () {
		cuerpoDeFoca = GetComponent<Rigidbody>();
		initialShamu = shamu.position;
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 newPosition = Vector3.forward;
		//this.cuerpoDeFoca.AddForce(newPosition*500);
	}

	void Update() {
		Vector3 position = transform.position;
		float z = position.z;
		float newZeta = z + z / 2;
		Vector3 newPosition = Vector3.back;
		Debug.Log ("Shamu initial :" + initialShamu.ToString ());
		transform.Translate (newPosition*velocity);
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Oli");
		if (other.gameObject.CompareTag ("Reset")) {
			transform.position = initialShamu;
			//Vector3 position = shamu.position;
			//transform.Translate (new Vector3(position.x, position.y, 0f));
		}
	}
}
