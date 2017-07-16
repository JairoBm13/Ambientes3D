using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	private Rigidbody cuerpoRigido;
	// Use this for initialization
	void Start () {
		cuerpoRigido = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movimiento = new Vector3(moveHorizontal, 0f, moveVertical);
		transform.Translate (movimiento * Time.deltaTime*50);
	}

	void FixedUpdate()
	{
		

	
	}
}
