// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_variables : MonoBehaviour {

	//string alterVariables = "http://localhost/demo/alterVariables.php";
	string alterVariables = "https://demo-cettic.000webhostapp.com/demo/alterVariables.php";
	public InputField vel_pj;
	public InputField tempo_max;
	public InputField puntaje_item;
	public InputField vida;
	public InputField daño;

	public Text txtResultado;

	public void Modificar_variables()
	{
		StartCoroutine(ModificarVariables(vel_pj.text, tempo_max.text, puntaje_item.text, vida.text, daño.text));
	}

	IEnumerator ModificarVariables (string vel_pj, string tempo_max, string puntaje_item, string vida, string daño) {
		WWWForm alter = new WWWForm ();
		alter.AddField ("velPjPost", vel_pj);
		alter.AddField ("tempoMaxPost", tempo_max);
		alter.AddField ("puntajeItemPost", puntaje_item);
		alter.AddField ("vidaPost", vida);
		alter.AddField ("danoPost", daño);

		WWW www = new WWW (alterVariables, alter);
		yield return www;

		txtResultado.text = www.text;
		print (www.text);
	}
}
