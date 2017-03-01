using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;


public class ControladorBola : MonoBehaviour {

    private Rigidbody cuerpoRigido;

    public float speed;

	private bool tipo;
	private float speedModifier; 

    void FixedUpdate()
    {
		float moveHorizontal = Input.GetAxis("izqX");
		float moveVertical = Input.GetAxis("downY");
		if (!tipo) {
			var head = InputTracking.GetLocalRotation(VRNode.Head);
			Vector3 movimiento = new Vector3(moveHorizontal, 0f, moveVertical);
			cuerpoRigido.AddForce(head*movimiento*(speed));
		} else {
			Vector3 movimiento = new Vector3(moveHorizontal, 0f, moveVertical);
			cuerpoRigido.AddForce(movimiento*(speed)*speedModifier);
		}
    }

    private void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }

	private void Update(){
		print (OVRInput.GetActiveController());
		if (OVRInput.Get (OVRInput.RawButton.A)) {
			tipo = false;
		} else {
			tipo = false;
		}
		speedModifier = OVRInput.Get (OVRInput.Axis1D.PrimaryHandTrigger);
	}
}
