<?php
session_start(); //delete if mail() function works
if(isset($_POST['reset-request-submit'])){ 
	
	
	
	$selecter = bin2hex(openssl_random_pseudo_bytes(8));	
	$token = openssl_random_pseudo_bytes(32); 
	$token2 = bin2hex(openssl_random_pseudo_bytes(32));//delete if mail() function works
	
	$_SESSION['selecter'] = $selecter; 	//delete if mail() function works
	$_SESSION['validator'] = $token2;	//delete if mail() function works
	
	$url = "http://i405359.hera.fhict.nl/reset_password.php?selecter=".$selecter."&validator=".bin2hex($token);
	
	$expires = date("U") + 1800;
	
	$servername = "studmysql01.fhict.local";
	$username = "dbi405359";
	$password = "R2,+johannes";
	$dbname = "dbi405359";

	$emailUsers = $_POST['email'];

try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	$sql = "DELETE FROM pwdReset WHERE pwdResetEmail=?";
	$stmt = $conn->prepare($sql);
		if(!$stmt){
			echo "There was an error!";
			exit();
		}
		else{
			$stmt->bindParam(1,$emailUsers);
			$stmt->execute();
		}
		
		$sql = "INSERT INTO pwdReset(pwdResetEmail, pwdResetSelecter, pwdResetToken, pwdResetExpires) VALUES(?,?,?,?)";
		$stmt = $conn->prepare($sql);
		if(!$stmt){
			echo "There was an error!";
			exit();
		}
		else{
			$hashedToken = password_hash($token, PASSWORD_DEFAULT);
			$stmt->bindParam(1,$emailUsers);
			$stmt->bindParam(2,$selecter);
			$stmt->bindParam(3,$hashedToken);
			$stmt->bindParam(4,$expires);
			$stmt->execute();
		}	
		
	}
catch(PDOException $e)
    {
    echo $sql . "<br>" . $e->getMessage();
    }
	$stmt = null;
	$conn = null;
	
		$to = $emailUsers;
		$subject = 'Reset your password for impulse';
		$message = '<p>We received a password reset request. The link to reset your password is below. If you did not make this request, you can ignore this email</p>';
		$message .= '<p>Here is your password reset link: </br>';
		$message .= '<a href="' .$url. '">' .$url. '</a></p>';
		
		$headers= "From: impulse<reno.picus1@gmail.com>\r\n";
		$headers .= "Reply-To: reno.picus1@gmail.com\r\n";
		$headers .= "Content-type: text/html\r\n";
		
		mail($to, $subject, $message, $headers);	
		
		header("Location: ../forgot_password.php?reset=succes");
		
}
else{ 
	header("Location: ../index.php"); 
	exit();
}