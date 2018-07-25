// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_comp : MonoBehaviour {

	public GameObject modelo;
	public AudioSource fuente;
	public AudioClip enemigos_son;
	public AudioClip items_son;

	void Update () {
		if (Variables_globales.vida <= 0.0f)
			Morir();
	}

	void OnTriggerEnter(Collider col)
	{
		switch (col.tag) {
		case "Enemigo":
			Variables_globales.vida -= Variables_globales.daño;
			fuente.PlayOneShot (enemigos_son);
			break;
		case "Item":
			HUD.puntaje_total += Variables_globales.puntaje_item;
			fuente.PlayOneShot (items_son);
			Destroy (col.gameObject);
			break;
		}
	}

	void Morir()	{
		Destroy (modelo);
	}
}
