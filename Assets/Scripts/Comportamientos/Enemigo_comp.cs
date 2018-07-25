// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_comp : MonoBehaviour {

	// Variables generales
	public Transform objetivo;

	// Vari9ables de movimiento
	public float velocidad;

	void Start () {
		velocidad = 0.4f;
	}

	void Update () {
		perseguir ();
	}

	void perseguir()
	{
		Vector3 direccion = objetivo.position - transform.position;
		direccion.y = 0.0f;
		direccion.x = 0.0f;
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation(direccion), 1.0f);
		transform.Translate (0.0f, 0.0f, velocidad);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player" || col.tag == "Destructor") {
			Destroy(gameObject);
		}
	}
}
