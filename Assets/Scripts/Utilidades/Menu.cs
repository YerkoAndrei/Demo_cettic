// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject menu;
	public float total_items;
	private bool pausado;

	void Start (){
		pausado = false;
		Time.timeScale = 1.0f;
		menu.SetActive (false);
		total_items = GameObject.FindGameObjectsWithTag ("Item").Length * Variables_globales.puntaje_item;
	}

	void Update() {
		if (Variables_globales.vida <= 0.0f || HUD.tempo <= 0.1f || HUD.puntaje_total == total_items) {
			Pausar ();
		}

		// Pausar
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pausado) {
				DesPausar ();
				pausado = false;
			} else {
				Pausar ();
				pausado = true;
			}
		}
	}

	public void Pausar() {
		Time.timeScale = 0.0f;
		menu.SetActive (true);
	}

	public void DesPausar() {
		Time.timeScale = 1.0f;
		menu.SetActive (false);
	}

	public void Abrir_Menu () {
		SceneMan.Escena_menu();
	}

	public void Reiniciar () {
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().name);
	}

	public void Salir()	{
		Application.Quit ();
	}
}
