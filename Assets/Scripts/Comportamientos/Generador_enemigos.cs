// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_enemigos : MonoBehaviour {

	public GameObject enemigo;
	public Transform generador;

	private float tempo;
	private float tempo_re;

	void Start () {
		tempo = 0.0f;
		tempo_re = 1.0f;
	}

	void Update () {
		tempo -= Time.deltaTime;

		if (tempo <= 0.0f) {
			float aleatorio = Random.Range (-8.0f,8.0f);
			GameObject.Instantiate (enemigo, new Vector3(aleatorio, 0.0f, generador.position.z), generador.rotation);
			tempo = tempo_re;
		}
	}
}
