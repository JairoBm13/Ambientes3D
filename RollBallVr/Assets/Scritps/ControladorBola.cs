using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBola : MonoBehaviour {

    private Rigidbody cuerpoRigido;

    public float speed;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moveHorizontal, 0.0f, moveVertical);


        cuerpoRigido.AddForce(movimiento*speed);
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
