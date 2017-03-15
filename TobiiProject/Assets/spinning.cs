using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;

[RequireComponent(typeof(GazeAware))]
public class spinning : MonoBehaviour {

	private GazeAware _gazeAware;
	private Rigidbody flyingObject;
	private int direction = 1;

	void Start()
	{
		flyingObject = GetComponent<Rigidbody> ();
		_gazeAware = GetComponent<GazeAware>();
	}

	void Update()
	{
		
	}

	void FixedUpdate(){
		if (_gazeAware.HasGazeFocus)
		{
			flyingObject.AddForce (Vector3.right * direction * 50);
		}
	
	}

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.CompareTag("player")){
			collider.gameObject.SetActive (false);
		}
		else if (collider.gameObject.CompareTag("Wall")) {
			direction = direction * -1;
		}
	}
}
