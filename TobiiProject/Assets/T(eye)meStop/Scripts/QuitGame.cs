using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Tobii.EyeTracking;

public class QuitGame : MonoBehaviour 
{
	private GazeAware _gazeAware;

	// Use this for initialization
	void Start () {
		_gazeAware = GetComponent<GazeAware>();
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
