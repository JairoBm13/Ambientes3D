using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap;


public class player : MonoBehaviour {
	LeapProvider provider;
	private Vector3 initial;

	// Use this for initialization
	void Start () {
		provider = FindObjectOfType<LeapProvider>() as LeapProvider;
		initial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Frame frame = provider.CurrentFrame;
		foreach (Hand hand in frame.Hands)
		{
			if (hand.IsLeft)
			{
				transform.position = transform.position + Vector3.forward; 
				//hand.PalmPosition.ToVector3() +
					//hand.PalmNormal.ToVector3() *
					//(transform.localScale.y * .5f + .02f);
				//transform.rotation = hand.Basis.CalculateRotation ();
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Oli");
		if (other.gameObject.CompareTag ("Reset")) {
			transform.position = initial;
			//Vector3 position = shamu.position;
			//transform.Translate (new Vector3(position.x, position.y, 0f));
		}
	}
}
