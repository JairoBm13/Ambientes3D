using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Tobii.EyeTracking;

public class GameOver : MonoBehaviour 
{
	private GazeAware _gazeAware;
	public AudioClip audio;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		_gazeAware = GetComponent<GazeAware>();
		audioSource = GetComponent<AudioSource> ();
		audioSource.playOnAwake = false;
		audioSource.Play ();
	}

	// Update is called once per frame
	void Update () {
		if (_gazeAware.HasGazeFocus && Input.GetButtonDown (KeyCode.Space.ToString())) {
			StopApplication ();
		}

	}


	public void StopApplication()
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit(); 
		#endif
	}
}
