<?php

// Variables de conexión   
$server = "localhost";					//localhost
$user = "id6599299_yerkoandrei";		//root
$pass = "admin";						//
$db = "id6599299_demo_cettic";			//demo_cettic

// Conexión
$conn = new mysqli($server, $user, $pass, $db);
if(!$conn)
{
	die("Fallo conexiòn: ". mysqli_connect_error());
}

// Query
$query = "SELECT vel_pj, tempo_max, puntaje_item, vida, dano FROM variables WHERE id = 1";
$res = mysqli_query($conn, $query);

if(mysqli_num_rows($res) > 0)
{
	while ($fila = mysqli_fetch_assoc($res))
	{
		echo ";vel_pj:".$fila['vel_pj'].";tempo_max:".$fila['tempo_max'].";puntaje_item:".$fila['puntaje_item'].";vida:".$fila['vida'].";dano:".$fila['dano'];
	}
}

$conn->Close();
?>
