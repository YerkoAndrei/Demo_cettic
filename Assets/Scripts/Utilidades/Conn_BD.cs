// Por: Yerko Andrei Orellana Abello. Postulación a Cettic.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Conn_BD : MonoBehaviour {

	string[] variables;


	IEnumerator Start () {
		//WWW index = new WWW ("http://localhost/demo/index.php");
		WWW index = new WWW ("https://demo-cettic.000webhostapp.com/demo/index.php");
		yield return index;

		string res = index.text;
		variables = res.Split (';');

		//Orden:
		//vel_pj  		-> [1]
		//tempo_max		-> [2]
		//puntaje_item	-> [3]
		//vida			-> [4]
		//dano			-> [5]

		Variables_globales.vel_pj = 		float.Parse(variables[1].Split (':')[1]);
		Variables_globales.tempo_max = 		float.Parse(variables[2].Split (':')[1]);
		Variables_globales.puntaje_item = 	float.Parse(variables[3].Split (':')[1]);
		Variables_globales.vida = 			float.Parse(variables[4].Split (':')[1]);
		Variables_globales.daño = 			float.Parse(variables[5].Split (':')[1]);
	}
}
