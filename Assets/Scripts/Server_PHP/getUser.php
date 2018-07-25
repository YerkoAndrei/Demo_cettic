<?php

// Variables de conexión
$server = "localhost";
$user = "id6599299_yerkoandrei";
$pass = "admin";
$db = "id6599299_demo_cettic";

// Variables del login
$userPost = $_POST["userPost"];
$passPost = $_POST["passPost"];

// Conexión
$conn = new mysqli($server, $user, $pass, $db);
if(!$conn)
{
	die("Fallo conexiòn: ". mysqli_connect_error());
}

// Query
$query = "SELECT id FROM usuarios WHERE user = '".$userPost."' AND pass ='".$passPost."'";
$res = mysqli_query($conn, $query);

if(mysqli_num_rows($res) > 0)
{
	if (mysqli_fetch_assoc($res)["id"] != null)
		echo "Login OK";
}
else
	echo "Error en el ingreso";

$conn->Close();
?>
