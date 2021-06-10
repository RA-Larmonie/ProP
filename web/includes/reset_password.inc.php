<?php
session_start(); //delete if mail() function works
if(isset($_POST['reset-password-submit'])){
	
	$servername = "studmysql01.fhict.local";
	$username = "dbi405359";
	$password = "R2,+johannes";
	$dbname = "dbi405359";
	
	//$selecter = $_POST["selecter"]; include if mail() funtion works
	//$validator = $_POST["validator"]; include if mail() funtion works
	
	$selecter = $_SESSION['selecter'];
	$validator = $_SESSION['validator'];
	
	$passwordU = $_POST["pwd"];
	$passwordRepeat = $_POST["pwd-repeat"];
	
	$currentDate = date("U");
	
try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
	if(empty($passwordU) || empty($passwordRepeat)){
		header("Location: ../reset_password.php?newpwd=empty");
		exit();
	}
	else if($passwordU != $passwordRepeat){
		header("Location: ../reset_password.php?newpwd=pwdnotsame");
		exit();
	}
	
	$sql = "SELECT * FROM pwdReset WHERE pwdResetSelecter=? AND  pwdResetExpires >= ?";
	$stmt = $conn->prepare($sql);
		if(!$stmt){
			echo "There was an error!";
			exit();
		}
		else{
				$stmt->bindParam(1,$selecter);
				$stmt->bindParam(2,$currentDate);
				$stmt->execute();
			
				if(!$rows = $stmt->fetch(PDO::FETCH_ASSOC)){
					echo "You need to re-submit your reset request 1.";
					exit();
				}
				else{
					
					$tokenBin = hex2Bin($validator);
					$tokenCheck = password_verify($tokenBin, $rows["pwdresetToken"]);
					
					if($tokenCheck == false){
						echo "You need to re-submit your reset request 2.";
						exit();
					}
					else if($tokenCheck == true){
						$tokenEmail = $rows['pwdResetEmail'];
						
						$sql = "SELECT * FROM users WHERE emailUsers=?;";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							echo "There was an error!";
							exit();
						}
						else{
							$stmt->bindParam(1,$tokenEmail);
							$stmt->execute();
							if(!$rows = $stmt->fetch(PDO::FETCH_ASSOC)){
							echo "There was an error.";
							exit();
							}
							else{	
								$sql = "UPDATE users SET pwdusers=? WHERE emailUsers=?";
								$stmt = $conn->prepare($sql);
								if(!$stmt){
									echo "There was an error!";
									exit();
								}
								else{
									$newPwdHash = password_hash($passwordU, PASSWORD_DEFAULT);
									$stmt->bindParam(1,$newPwdHash);
									$stmt->bindParam(2,$tokenEmail);
									$stmt->execute();
									
									$sql = "DELETE FROM pwdReset WHERE pwdResetEmail=?";
									$stmt = $conn->prepare($sql);
									if(!$stmt){
										echo "There was an error!";
										exit();
									}
									else{
										$stmt->bindParam(1,$tokenEmail);
										$stmt->execute();
										header("Location: ../signup.php?newpwd=passwordupdated");
									}
								}
							}
						}
					}					
				}
			}
	
	}
catch(PDOException $e)
    {
    echo $sql . "<br>" . $e->getMessage();
    }
	
}
else{
	header("Location: ../index.php");
	exit();
}
