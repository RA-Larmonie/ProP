<?php
if(isset($_POST['signup-submit'])){
$servername = "studmysql01.fhict.local";
$username = "dbi393800";
$password = "ralia12345";
$dbname = "dbi393800";

$fname = $_POST['fname'];
$lname = $_POST['lname'];
$emailUsers = $_POST['email'];
$DateOfBirth = $_POST['dob'];
$pwdUsers = $_POST['psw'];
$pwdRepeat = $_POST['psw-repeat'];
/* $rfid = "28007be14d"; */
$amount = $_POST['amount'];

if($amount > 0){
	$amount = $amount;	
}
else{
	$amount = 0;
}

try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	if(empty($fname) || empty($lname) || empty($emailUsers) || empty($DateOfBirth) || empty($pwdUsers) || empty($pwdRepeat)){
		header("Location: ../pages/sign-up/sign_up.php?error=emtyfields&fname=".$fname."&email=".$emailUsers);
		exit();
	}
	else if(!filter_var($emailUsers, FILTER_VALIDATE_EMAIL)){
		header("Location: ../pages/sign-up/sign_up.php?error=invalidmail&fname=".$fname);
		exit();
	}
	else if(!preg_match("/^[A-Za-z]{2,}$/", $fname)){
		header("Location: ../pages/sign-up/sign_up.php?error=invalidfname&email=".$emailUsers);
		exit();
	}
	else if(!preg_match("/^[A-Za-z]{2,}$/", $lname)){
		header("Location: ../pages/sign-up/sign_up.php?error=invalidlname&email=".$emailUsers);
		exit();
	}
	/*else if(!preg_match("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-,+()]).{8,}$", $pwdUsers)){
		header("Location: ../sign_up.php?error=invalidPasw&email=".$emailUsers);
		exit();
	}*/
	else if($pwdUsers !== $pwdRepeat){
		header("Location: ../pages/sign-up/sign_up.php?error=passwordcheck&fname=".$fname."&email=".$emailUsers);
		exit();
	}
	else{
		$sql = "SELECT UserFirstName FROM visitor WHERE Email=?";
		//$insert_data = array($_POST["fname"], $_POST["lname"]);
		$stmt = $conn->prepare($sql);
		if(!$stmt){
		header("Location: ../pages/sign-up/sign_up.php?error=sqlerror");
		exit();
		}
		else{
			$stmt->bindParam(1,$emailUsers);
			$stmt->execute();
			$resultCheck = $stmt->rowCount();
			if($resultCheck > 0){
				header("Location: ../pages/sign-up/sign_up.php?error=usertaken&email=".$emailUsers);
				exit();
			}
			else{
				$sql = "INSERT INTO visitor (UserFirstName, UserLastName, Email, DateOfBirth, PSW, Balance) VALUES(?,?,?,?,?,?)";
				$stmt = $conn->prepare($sql);
				if(!$stmt){
					header("Location: ../pages/sign-up/sign_up.php?error=sqlerror");
					exit();
				}
				else{
					$hashedPwd = password_hash($pwdUsers, PASSWORD_DEFAULT);
/* 					$stmt->bindParam(1,$rfid); */
					$stmt->bindParam(1,$fname);
					$stmt->bindParam(2,$lname);
					$stmt->bindParam(3,$emailUsers);
					$stmt->bindParam(4,$DateOfBirth);
					$stmt->bindParam(5,$hashedPwd);
					$stmt->bindParam(6,$amount);
					$stmt->execute();
					header("Location: ../pages/More/more.php?signup=succes");
					exit();
				}
			}
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

