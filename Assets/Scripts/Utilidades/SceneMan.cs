// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour {

	public static void Escena_index()
	{
		SceneManager.LoadSceneAsync ("Index");
	}

	public static void Escena_menu()
	{
		SceneManager.LoadSceneAsync ("Menu");
	}

	public void btn_index()
	{
		SceneManager.LoadSceneAsync ("Index");
	}
	public void Salir()	{
		Application.Quit ();
	}
}
