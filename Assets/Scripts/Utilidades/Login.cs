// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {
	
	//string getUser = "http://localhost/demo/getUser.php";
	string getUser = "https://demo-cettic.000webhostapp.com/demo/getUser.php";
	public InputField user;
	public InputField pass;

	public Text txtResultado;

	public void Login_user()
	{
		StartCoroutine(LoginUser(user.text, pass.text));
	}

	IEnumerator LoginUser (string user, string pass) {
		WWWForm login = new WWWForm ();
		login.AddField ("userPost", user);
		login.AddField ("passPost", pass);

		WWW www = new WWW (getUser, login);
		yield return www;

		txtResultado.text = www.text;
		print (www.text);
		if (www.text == "Login OK")
			SceneMan.Escena_index ();
	}

}
