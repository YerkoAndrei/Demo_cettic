<?php

// Variables de conexión
$server = "localhost";
$user = "id6599299_yerkoandrei";
$pass = "admin";
$db = "id6599299_demo_cettic";

// Variables de modificación
$velPjPost = $_POST["velPjPost"];
$tempoMaxPost = $_POST["tempoMaxPost"];
$puntajeItemPost = $_POST["puntajeItemPost"];
$vidaPost = $_POST["vidaPost"];
$danoPost = $_POST["danoPost"];

// Conexión
$conn = new mysqli($server, $user, $pass, $db);
if(!$conn)
{
	die("Fallo conexiòn: ". mysqli_connect_error());
}

// Query
$query = "UPDATE variables SET vel_pj='".$velPjPost."', tempo_max='".$tempoMaxPost."', puntaje_item='".$puntajeItemPost."', vida='".$vidaPost."', dano='".$danoPost."' WHERE id=1";
$res = mysqli_query($conn, $query);

if(!$res)
	echo "Error al modificar variables";
else
	echo "Modificación OK";

$conn->Close();
?>
