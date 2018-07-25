// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text txt_vida;
	public Text txt_puntaje;
	public Text tiempo;

	public static float tempo;
	public static float puntaje_total;

	void Start(){		
		tempo = Variables_globales.tempo_max;
		puntaje_total = 0.0f;
	}

	void Update () {
		txt_vida.text = Variables_globales.vida.ToString ();
		txt_puntaje.text = puntaje_total.ToString ();

		tempo -= Time.deltaTime;

		string seg = Mathf.Floor (tempo % 60).ToString ("00");
		string min = Mathf.Floor (tempo / 60).ToString ("00");
		tiempo.text = min + ":" + seg;
	}
}
