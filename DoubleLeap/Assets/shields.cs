using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;
using Leap;

public class shields : MonoBehaviour {

	LeapProvider provider;
	Vector3 initial;
	public int lefty;

	// Use this for initialization
	void Start () {
		provider = FindObjectOfType<LeapProvider>() as LeapProvider;
		initial = transform.position;
	
	}
	
	void Update () {
		Frame frame = provider.CurrentFrame;
		foreach (Hand hand in frame.Hands)
		{
			if (hand.IsLeft && lefty == 1) {
				transform.position = new Vector3 (hand.PalmPosition.x, hand.PalmPosition.y, hand.PalmPosition.z);

				//hand.PalmPosition.ToVector3() +
				//hand.PalmNormal.ToVector3() *
				//(transform.localScale.y * .5f + .02f);
				//transform.rotation = hand.Basis.CalculateRotation ();
			} else if (hand.IsRight && lefty == 0){
				//transform.position = new Vector3 (hand.PalmPosition.x, hand.PalmPosition.y, hand.PalmPosition.z);
			}

		}
	}
}
