<?php 
session_start();

	$servername = "studmysql01.fhict.local";
	$username = "dbi393800";
	$password = "ralia12345";
	$dbname = "dbi393800";
	
	try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	
						$user_id = $_SESSION['userID'];
					
						$sql = "SELECT * FROM ticket WHERE UserID=? AND Type_Of_Ticket='1D'";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$_SESSION['AmountTG'] = $rows['Amount'];	
							}
						}
						
						$sql = "SELECT * FROM ticket WHERE UserID=? AND Type_Of_Ticket='2D'";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$_SESSION['AmountTV'] = $rows['Amount'];	
							}
						}
						
						$sql = "SELECT * FROM ticket WHERE UserID=? AND Type_Of_Ticket='3D'";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$user_id);
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){
								$_SESSION['AmountTP'] = $rows['Amount'];	
							}
						}
	}
catch(PDOException $e)
    {
    echo $sql . "<br>" . $e->getMessage();
    }
$stmt = null;
$conn = null;	
header("Location: ../pages/tickets/Tickets.php");		
exit();
?>