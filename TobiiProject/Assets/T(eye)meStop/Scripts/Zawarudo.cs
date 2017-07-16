using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.EyeTracking;

[RequireComponent(typeof(GazeAware))]
public class Zawarudo : MonoBehaviour {

	private AudioSource audioSource;
	private GazeAware _gazeAware;

	void Start()
	{
		audioSource = GetComponent<AudioSource> ();
		_gazeAware = GetComponent<GazeAware>();
		audioSource.playOnAwake = false;
	}

	void Update(){
		UserPresence userPrecense = EyeTracking.GetUserPresence();
		if (!userPrecense.IsUserPresent) {
			audioSource.Play ();
		}
	}
}
