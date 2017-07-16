using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(GazeAware))]
public class obstacle : MonoBehaviour {

	private GazeAware _gazeAware;
	private AudioSource audioSource;
	private Rigidbody flyingObject;
	private int direction = 1;
	public int speed;

	void Start()
	{
		flyingObject = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
		_gazeAware = GetComponent<GazeAware>();
		audioSource.playOnAwake = false;
		EyeTracking.Initialize ();
		int itera = (int) Random.value*3;
		for (int i = itera; i < itera; i++ ){
			direction *= -1;
		}
	}

	void FixedUpdate(){
		//UserPresence userPrecense = EyeTracking.GetUserPresence();
		//if (userPrecense.IsUserPresent) {
			flyingObject.AddForce (Vector3.right * direction * speed);
		if (flyingObject.velocity.magnitude > 80 ) {
			flyingObject.velocity = Vector3.zero;
			flyingObject.angularVelocity = Vector3.zero;
			flyingObject.AddForce (Vector3.right * direction * speed/2);
		}

		//} else {
		//	flyingObject.isKinematic = false;
		//	flyingObject.velocity = Vector3.zero;
		//	flyingObject.angularVelocity = Vector3.zero;
		//}
	}

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.CompareTag("Player")){
			SceneManager.LoadScene(1);
		}
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		audioSource.Play ();
	}
}
