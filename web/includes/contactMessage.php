<?php
if (isset($_POST['submit'])) {

	$servername = "studmysql01.fhict.local";
	$username = "dbi405359";
	$password = "R2,+johannes";
	$dbname = "dbi405359";

$email = $_POST['Email'];
$name = $_POST['Name'];
$msg = $_POST['Message'];

try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    // set the PDO error mode to exception
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    if(empty($email) || empty($name) || empty($msg)){
		header("Location: ../index.php?error=emtpyfields");
		exit();
    }
    else if (!(preg_match("/^[A-Za-z]{2,}$/", $name))) {
        header("Location: ../index.php?error=emtpyfieldsName");
		exit();
    }
    else if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        header("Location: ../index.php?emailIsIncorrect");
        exit();
    }
    else {
    $sql = "INSERT INTO contact_us (EMAIL, NAME, MESSAGE) 
    VALUES (?, ?, ?)";

    $conn->prepare($sql);
    $stmt = $conn->prepare($sql);
    if(!$stmt){
        header("Location: ../index.php?thereIsAnError");
        exit();
    }
    else{
                
        $stmt->bindParam(1,$email);
        $stmt->bindParam(2,$name);
        $stmt->bindParam(3,$msg);
        $stmt->execute();
        header("Location: ../index.php?sendMSG=succes");
        exit();}
    }
}
catch(PDOException $e){
    echo $sql . "<br>" . $e->getMessage();
}
$conn = null;
$stmt = null;
}
else {
    header("Location: ../index.php?failedToSendMessage");
	exit();
}
?>
