<?php
if (isset($_POST['submit'])) {
session_start();

$servername = "studmysql01.fhict.local";
$username = "dbi393800";
$password = "ralia12345";
$dbname = "dbi393800";

$user_id = $_SESSION['userID'];
$StartD = "2020-01-24";
$campid;
$Spot = 1;

try {

        $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
        // set the PDO error mode to exception
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

			$sql = "SELECT Type_Of_Ticket FROM ticket WHERE UserID=? AND Type_Of_Ticket='3D'";
			//$insert_data = array($_POST["fname"], $_POST["lname"]);
			$stmt = $conn->prepare($sql);
			if(!$stmt){
			header("Location: ../pages/camping/camping.php?error=sqlerror");
			exit();
			}
			else{
				$stmt->bindParam(1,$user_id);
				$stmt->execute();
				$resultCheck = $stmt->rowCount();
				if($resultCheck > 0){	
					
					$sql= "SELECT CampID FROM camping WHERE Status='0' AND BookedSpots='0'
					ORDER BY CampID ASC
					LIMIT 1";
					
					$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../pages/camping/camping.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->execute();
							if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$campid = $rows['CampID'];}
						}
						
					$sql = "UPDATE camping SET BookedSpots=? WHERE CampID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$Spot);
												$stmt->bindParam(2,$campid);
												$stmt->execute();
											}
					
					$sql= "INSERT INTO assigncamping (CampID, UserID, StartDate)
					VALUES (?,?,?)";
					
					$conn->prepare($sql);
					$stmt = $conn->prepare($sql);
					if(!$stmt){
						header("Location: ../pages/camping/camping.php?thereIsAnError");
						exit();
					}
					else{
						$stmt->bindParam(1,$campid);
						$stmt->bindParam(2,$user_id);
						$stmt->bindParam(3,$StartD);
						$stmt->execute();
						header("Location: ../pages/camping/camping.php?purchase=succes");
						exit();
					}					
				}
				else{
					header("Location: ../pages/camping/camping.php?pleaseBuyAWeekendTicket");
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
	header("Location: ../pages/camping/camping.php?submitPurchaseFail");
	exit();
}

