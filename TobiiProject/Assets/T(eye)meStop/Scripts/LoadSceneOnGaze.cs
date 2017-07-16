using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Tobii.EyeTracking;

[RequireComponent(typeof(GazeAware))]
public class LoadSceneOnGaze : MonoBehaviour {

	public int sceneIndex;
	private GazeAware _gazeAware;

	// Use this for initialization
	void Start () {
		_gazeAware = GetComponent<GazeAware>();
	}

	// Update is called once per frame
	void Update () {
		if (_gazeAware.HasGazeFocus /*&& Input.GetButtonDown (KeyCode.Space.ToString())*/) {
			SceneManager.LoadScene (sceneIndex);
		}

	}
}
