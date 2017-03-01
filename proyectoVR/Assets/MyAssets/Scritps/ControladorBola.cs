using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class ControladorBola : MonoBehaviour {

    private Rigidbody cuerpoRigido;

    public float speed;

    void FixedUpdate()
    {
		//if(Input.GetKeyDown(KeyCode.Space)){
		var vector = transform.rotation.eulerAngles;

		// Set the rotation to be the same as the user's in the y axis.
			var head = InputTracking.GetLocalRotation(VRNode.Head);
		     vector.y = 0;
			

        float moveHorizontal = Input.GetAxis("izqX");
        float moveVertical = Input.GetAxis("downY");


		Vector3 movimiento = new Vector3(moveHorizontal, vector.y, moveVertical);


		cuerpoRigido.AddForce(movimiento/***Vector3.forward*/*(
			speed));
		//}
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



}
