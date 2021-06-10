<?php
if (isset($_POST['submit'])) {
session_start();

$servername = "studmysql01.fhict.local";
$username = "dbi393800";
$password = "ralia12345";
$dbname = "dbi393800";

$user_id = $_SESSION['userID'];
$amount = $_POST['wallet'];

try {

        $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
        // set the PDO error mode to exception
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        if(empty($amount)){
            header("Location: ../pages/Amount/amount.php?emptyFieldInBuyTicketModal");
            exit();
        }
        else {				
					$sql = "SELECT * FROM visitor WHERE UserID=?";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../pages/Amount/amount.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$cAmount = $rows['Balance'];	
							}
						}
						
					$sql= "UPDATE visitor SET Balance=? WHERE UserID=$user_id";
					$conn->prepare($sql);
					$stmt = $conn->prepare($sql);
					if(!$stmt){
						header("Location: ../pages/Amount/amount.php?thereIsAnError");
						exit();
					}
					else{
						$amount = $amount + $cAmount;
						$stmt->bindParam(1,$amount);
						$stmt->execute();
						header("Location: ../pages/Amount/amount.php?purchase=succes");
						exit();
					}
					
				

			
        }
    }
	

    catch (PDOException $e) {
        echo $sql."<br>".$e->getMessage(); 
    }
    $stmt = null;
    $conn = null;
}
else{
	header("Location: ../pages/Amount/amount.php?submitPurchaseFail");
	exit();
}