<?php
if(isset($_POST['login-submit'])){
	$servername = "studmysql01.fhict.local";
	$username = "dbi393800";
	$password = "ralia12345";
	$dbname = "dbi393800";

	$emailUsers = $_POST['email'];
	$pwdUsers = $_POST['psw'];
	
	try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	if(empty($emailUsers) || empty($pwdUsers)){
		header("Location: ../pages/sign-in/sign_in.php?error=emtyfields");
		exit();
	}
	else{
		$sql = "SELECT * FROM visitor WHERE Email=?";
		//$insert_data = array($_POST["fname"], $_POST["lname"]);
		$stmt = $conn->prepare($sql);
		if(!$stmt){
		header("Location: ../pages/sign-in/sign_in.php?error=sqlerror");
		exit();
		}
		else{
			$stmt->bindParam(1,$emailUsers);
			$stmt->execute();
			if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
				$pwdCheck = password_verify($pwdUsers, $rows['PSW']);
				if($pwdCheck == false){
					header("Location: ../pages/sign-in/sign_in.php?error=wrongpwd");
					exit();
				}
				else if($pwdCheck == true){
					session_start();
					$_SESSION['userID'] = $rows['UserID'];
					$_SESSION['fname'] = $rows['UserFirstName'];
					$_SESSION['lname'] = $rows['UserLastName'];
					$_SESSION['userEmail'] = $rows['Email'];
						
						/*$user_id = $_SESSION['userID'];
					
						$sql = "SELECT * FROM purchases WHERE idUsers=? AND TYPE_ticket='GENERAL'";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../index.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$_SESSION['AmountTG'] = $rows['AMOUNT'];	
							}
						}
						
						$sql = "SELECT * FROM purchases WHERE idUsers=? AND TYPE_ticket='VIP'";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../index.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$_SESSION['AmountTV'] = $rows['AMOUNT'];	
							}
						}
						
						$sql = "SELECT * FROM purchases WHERE idUsers=? AND TYPE_ticket='PLATINUM'";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../index.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$_SESSION['AmountTP'] = $rows['AMOUNT'];	
							}
						}*/
						
					header("Location: ../index.php?login=succes");
					exit();
				}
				else{
					header("Location: ../pages/sign-in/sign_in.php?error=wrongpwd");
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
	header("Location: ../index.php");
	exit();
}
