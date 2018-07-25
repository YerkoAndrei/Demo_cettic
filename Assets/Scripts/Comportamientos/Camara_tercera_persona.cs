// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_tercera_persona : MonoBehaviour {

	// Variables generales
	public Transform prota;
	public Vector3 offset;
	private float raton_y;
	private float raton_x;

	// Variables de velocidad de la cámara
	public float vel_y;
	public float vel_x;

	// Variables restrictivas
	public float angulo_sup_y;
	public float angulo_inf_y;

	// Variables de posicionamiento de la cámara
	private Vector3 lerp;
	private Quaternion rotacion;

	void Start () {
		prota = GameObject.FindGameObjectWithTag ("Player").transform;
		offset = new Vector3(0.0f, 2.0f, -5.0f);
		raton_y = 0.0f;
		raton_x = 0.0f;

		vel_y = 200.0f;
		vel_x = 400.0f;

		angulo_sup_y = -45.0f;
		angulo_inf_y = 20.0f;
	}

	void LateUpdate () {
		// Movimiento del ratón
		raton_y += Mathf.Clamp(Input.GetAxis("Mouse Y"), -1.0f, 1.0f) * Time.deltaTime * vel_y;
		raton_x += Mathf.Clamp(Input.GetAxis("Mouse X"), -1.0f, 1.0f) * Time.deltaTime * vel_x;

		// Límite vertical de la cámara
		raton_y = Mathf.Clamp(raton_y, angulo_sup_y, angulo_inf_y);

		// Variables de posicionamiento de la cámara
		lerp = Vector3.Lerp(offset, offset, Time.deltaTime);
		rotacion = Quaternion.Euler(-raton_y, raton_x, 0.0f);

		// Posicionamiento de la cámara
		transform.position = prota.position + Quaternion.identity * offset;
		transform.position = prota.position + rotacion * lerp;
		transform.rotation = rotacion;
	}
}