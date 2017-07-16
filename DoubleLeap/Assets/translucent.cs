using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translucent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color actualColor = this.gameObject.GetComponent<MeshRenderer> ().material.color;
		this.GetComponent<MeshRenderer> ().material.color = new Color (actualColor.r, actualColor.g, actualColor.b, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}