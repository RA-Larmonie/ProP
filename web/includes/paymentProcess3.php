<?php
if (isset($_POST['submit'])) {
session_start();

$servername = "studmysql01.fhict.local";
$username = "dbi393800";
$password = "ralia12345";
$dbname = "dbi393800";

$user_id = $_SESSION['userID'];

$price = 499;
$type = "3D";

$uid;
$zero = 0;


$amountOfTicket = $_POST['amountOfTicket'];

$email1 = $_POST['email1'];
$email2 = $_POST['email2'];
$email3 = $_POST['email3'];
$email4 = $_POST['email4'];

try {

        $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
        // set the PDO error mode to exception
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

        if(empty($amountOfTicket)){
            header("Location: ../pages/tickets/Tickets.php?emptyFieldInBuyTicketModal");
            exit();
        }
        else if (!($amountOfTicket > 0 && $amountOfTicket < 11)) {
            header("Location: ../pages/tickets/Tickets.php?incorrectAmountOfTicketChosen");
            exit();
        }
        /*else if (!preg_match("^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$", $creditCardNo)) {
            header("Location: index.php?incorrectTicketCreditCardNumber");
            exit();     //e.g. 5112223223323227 
        }*/
        /* else if (!preg_match("/^[0-9]{3}$/", $creditCardSecurityCode)) {
            header("Location: ../index.php?CreditCardSecurityCodeFieldIsIncorrect");
            exit();
        }
        else if (!($creditCartExpMonth > 0 && $creditCartExpMonth < 13)) {
            header("Location: ../index.php?incorrectFieldCreditExperationMonth");
            exit();
        }
        else if (!($creditCardExpYr > 2018 && $creditCardExpYr < 2050)) {
            header("Location: ../index.php?incorrectfieldInputInCredExpYr");
            exit();
        } */ 
        else {
			$sql = "SELECT Type_Of_Ticket FROM ticket WHERE UserID=? AND Type_Of_Ticket='$type'";
			//$insert_data = array($_POST["fname"], $_POST["lname"]);
			$stmt = $conn->prepare($sql);
			if(!$stmt){
			header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
			exit();
			}
			else{
				$stmt->bindParam(1,$user_id);
				$stmt->execute();
				$resultCheck = $stmt->rowCount();
				if($resultCheck > 0){
					
					header("Location: ../pages/tickets/Tickets.php?YouHaveAlreadyBoughtTicketsOnce");
					exit();							
					
				}
				else{
					
					if($amountOfTicket == 2){
							
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email1);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
									
					}
					
					if($amountOfTicket == 3){
							
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email1);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
										/* email 2*/
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email2);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}							
									
					}
					if($amountOfTicket == 4){
							
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email1);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
										/* email 2*/
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email2);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
							/* email 3*/
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email3);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
									
					}
					if($amountOfTicket == 5){
							
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email1);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
										/* email 2*/
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email2);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
							/* email 3*/
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email3);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
							/* email 4*/
							$sql = "SELECT UserID FROM visitor WHERE Email=?";
							
										$stmt = $conn->prepare($sql);
										if(!$stmt){
										header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
										exit();
										}
										else{
											$stmt->bindParam(1, $email4);
											$stmt->execute();
											if($rows = $stmt->fetch(PDO::FETCH_ASSOC)){$uid = $rows['UserID'];}
										}
									
							$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=?";					
										
										$stmt = $conn->prepare($sql);
											if(!$stmt){
												header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
												exit();
											}
											else{
												$stmt->bindParam(1,$paid);
												$stmt->bindParam(2,$uid);
												$stmt->execute();
											}
							$sql= "INSERT INTO ticket (UserID, Type_Of_Ticket, Amount, Price)
										VALUES (?, ?, ?, ?)";
										
										$conn->prepare($sql);
										$stmt = $conn->prepare($sql);
										if(!$stmt){
											header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
											exit();
										}
										else{
											
											$stmt->bindParam(1,$uid);
											$stmt->bindParam(2,$type);
											$stmt->bindParam(3,$zero);
											$stmt->bindParam(4,$price);
											$stmt->execute();
										}
									
					}
            
					$sql= "INSERT INTO ticket (UserID, Amount, Type_Of_Ticket, Price)
					VALUES ($user_id, ?, ?, ?)";
					
					$conn->prepare($sql);
					$stmt = $conn->prepare($sql);
					if(!$stmt){
						header("Location: ../pages/tickets/Tickets.php?thereIsAnError");
						exit();
					}
					else{
						
						$stmt->bindParam(1,$amountOfTicket);
						$stmt->bindParam(2,$type);
						$stmt->bindParam(3,$price);
						$stmt->execute();
					}
					
					$sql = "UPDATE visitor SET isPaid3=? WHERE UserID=$user_id";
						$stmt = $conn->prepare($sql);
						if(!$stmt){
							header("Location: ../pages/tickets/Tickets.php?error=sqlerror");
							exit();
						}
						else{
							$stmt->bindParam(1,$paid);
							$stmt->execute();
							header("Location: ../pages/tickets/Tickets.php?purchase=succes");
							exit();
						}
				}
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
	header("Location: ../pages/tickets/Tickets.php?submitPurchaseFail");
	exit();
}