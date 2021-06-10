<?php
if(isset($_POST['submit'])){
$servername = "studmysql01.fhict.local";
$username = "dbi393800";
$password = "ralia12345";
$dbname = "dbi393800";

$fname = $_POST['fname'];
$emailUsers = $_POST['email'];
$phone = $_POST['phone'];
$mssg = $_POST['mssg'];

try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	if(empty($fname) || empty($emailUsers) || empty($phone) || empty($mssg)){
		header("Location: ../pages/info-final/info.php?error=emtyfields&fname=".$fname."&email=".$emailUsers);
		exit();
	}
	else if(!filter_var($emailUsers, FILTER_VALIDATE_EMAIL)){
		header("Location: ../info-final/info.php?error=invalidmail&fname=".$fname);
		exit();
	}
	else{
		
				$sql = "INSERT INTO mails (Name, Email, PhoneNumber, Message) VALUES(?,?,?,?)";
				$stmt = $conn->prepare($sql);
				if(!$stmt){
					header("Location: ../pages/info-final/info.php?error=sqlerror");
					exit();
				}
				else{
					$hashedPwd = password_hash($pwdUsers, PASSWORD_DEFAULT);
					$stmt->bindParam(1,$fname);
					$stmt->bindParam(2,$emailUsers);
					$stmt->bindParam(3,$phone);
					$stmt->bindParam(4,$mssg);
					$stmt->execute();
					header("Location: ../pages/info-final/info.php?send=succes");
					exit();
				}
			
	}	
    }
catch(PDOException $e)
    {
    echo $sql . "<br>" . $e->getMessage();
    }
$stmt = null;
$conn = null;
}
else{
	header("../index.php");
	exit();
}

