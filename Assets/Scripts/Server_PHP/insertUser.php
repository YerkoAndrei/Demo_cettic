<?php

// Variables de conexión
$server = "localhost";
$user = "id6599299_yerkoandrei";
$pass = "admin";
$db = "id6599299_demo_cettic";

// Variables de registro
$userPost = $_POST["userPost"];
$passPost = $_POST["passPost"];

// Conexión
$conn = new mysqli($server, $user, $pass, $db);
if(!$conn)
{
	die("Fallo conexiòn: ". mysqli_connect_error());
}

// Query
$query = "INSERT INTO usuarios (user, pass) VALUES ('".$userPost."', '".$passPost."')";
$res = mysqli_query($conn, $query);

if(!$res)
	echo "Error al registrar";
else
	echo "Registro Ok";

$conn->Close();
?>
