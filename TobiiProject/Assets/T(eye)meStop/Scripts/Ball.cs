using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	private Rigidbody flyingObject;
	private int direction = 1;
	private AudioSource audioSource;
	private GazeAware _gazeAware;

	void Start()
	{
		flyingObject = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
		_gazeAware = GetComponent<GazeAware>();
		audioSource.playOnAwake = false;
		int itera = (int) Random.value*3;
		for (int i = itera; i < itera; i++ ){
			direction *= -1;
		}
	}

	void FixedUpdate(){
		//UserPresence userPrecense = EyeTracking.GetUserPresence();
		//if (userPrecense.IsUserPresent) {
			flyingObject.AddForce (Vector3.right * direction * 50);
		/**} else {
			flyingObject.isKinematic = false;
			flyingObject.velocity = Vector3.zero;
			flyingObject.angularVelocity = Vector3.zero;
		}*/
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