// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_tercera_persona : MonoBehaviour {

	// Variables generales
	private Vector3 cam_rig;
	private Vector3 cam_for;
	private Vector3 movimiento;
	private float vertical;
	private float horizontal;

	// Variables de movimiento
	public float mult_correr;
	public float rotacion_mira;
	public float rotacion_norm;

	void Start () {
		rotacion_mira = 0.2f;
		rotacion_norm = 500.0f;
	}

	void Update () {		
		// Variables de movimiento
		vertical = Input.GetAxis ("Vertical") * Time.deltaTime;
		horizontal = Input.GetAxis ("Horizontal") * Time.deltaTime;
		cam_rig = Camera.main.transform.right;
		cam_for = Camera.main.transform.forward;
		cam_for.y = 0.0f;

		// Movimiento normal según cámara
		movimiento = vertical * Variables_globales.vel_pj * Vector3.Scale(cam_for, new Vector3(1.0f, 0.0f, 1.0f)).normalized + horizontal * Variables_globales.vel_pj * cam_rig;
		movimiento = transform.InverseTransformDirection(movimiento);
		transform.Rotate(0.0f, Mathf.Atan2(movimiento.x, movimiento.z) * rotacion_norm * Time.deltaTime, 0.0f);
		transform.Translate (movimiento);
	}
}
