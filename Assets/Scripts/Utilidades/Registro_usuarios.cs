// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registro_usuarios : MonoBehaviour {

	//string insertUser = "http://localhost/demo/insertUser.php";
	string insertUser = "https://demo-cettic.000webhostapp.com/demo/insertUser.php";
	public InputField user;
	public InputField pass;

	public Text txtResultado;

	public void Registro_user()
	{
		StartCoroutine(RegistroUser(user.text, pass.text));
	}

	IEnumerator RegistroUser (string user, string pass) {
		WWWForm insert = new WWWForm ();
		insert.AddField ("userPost", user);
		insert.AddField ("passPost", pass);

		WWW www = new WWW (insertUser, insert);
		yield return www;

		txtResultado.text = www.text;
		print (www.text);
	}
}
