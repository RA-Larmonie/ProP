<!-- Ticket Modal -->
	 <div class="im-modal" id="ticketModal" style="z-index:450" >
	  <form action="../../includes/paymentProcess1.php" method="POST">

    <div class="im-modal-content im-animate-top im-card-4">
      		<header style="background-color: pink" class="im-container im-center im-padding-32"> 
        		<span style="background-color: pink" class="im-button im-xlarge im-display-topright" onclick="document.getElementById('ticketModal').style.display='none'">×</span>
        		<h2 class="im-wide"><i class="fa fa-shopping-cart im-margin-right"></i>Tickets</h2>
      		</header>
      	<div class="im-container">
			<?php
		if(isset($_SESSION['userID'])){
			echo '<p style="color: black"><label><i class="fa fa-plus-square"></i> Amount</label></p>
        		<input name="amountOfTicket" class="im-input im-border" type="number" min="1" max="5" placeholder="Choose NO. of tickets" id="amount" oninput="return add()">
				<div id="all">
				<div style="display: none;" id="here1">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email1" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here2">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email2" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here3">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email3" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here4">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email4" class="im-input im-border" type="email" placeholder="email">
				</div>
				</div>
        		<button type="submit" name="submit" style="background-color: pink" class="im-button im-block im-padding-16 im-section im-right" onclick="return Validate()">
				<span class="style3">PAY</span></button>
        		<div class="im-section">
        		<br>
        		<br>
				</div>';
		}
		else{
			echo '<p style="color: black" class="im-center"><label><b>Please login to purchase ticket.</b></label></p>';
		}
		?>	
      	</div>
    </div>
	</form>
	</div>


  <div class="im-modal" id="ticketModal2" style="z-index:450">
  <form action="../../includes/paymentProcess2.php" method="POST" >
    	<div class="im-modal-content im-animate-top im-card-4">
      		<header style="background-color: red" class="im-container im-center im-padding-32"> 
        		<span style="background-color: red" class="im-button im-xlarge im-display-topright" onclick="document.getElementById('ticketModal2').style.display='none'">×</span>
        		<h2 class="im-wide"><i class="fa fa-shopping-cart im-margin-right"></i>Tickets</h2>
      		</header>
      		<div class="im-container">
      			<?php
		if(isset($_SESSION['userID'])){
			echo '<p style="color: black"><label><i class="fa fa-plus-square"></i> Amount</label></p>
        		<input name="amountOfTicket" class="im-input im-border" type="number" min="1" max="5" placeholder="Choose NO. of tickets" id="amount2" oninput="return add2()">
		  		<div id="all2">
				<div style="display: none;" id="here5">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email1" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here6">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email2" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here7">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email3" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here8">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email4" class="im-input im-border" type="email" placeholder="email">
				</div>
				</div>
				<button type="submit" name="submit" style="background-color: pink" class="im-button im-block im-padding-16 im-section im-right" onclick="return Validate()">
				<span class="style3">PAY</span></button>
        		<div class="im-section">
        		<br>
        		<br>
				</div>';
		}
		else{
			echo '<p style="color: black" class="im-center"><label><b>Please login to purchase ticket.</b></label></p>';
		}
		?>
      	</div>
    </div>
	</form>
  </div>
 


  <div class="im-modal" id="ticketModal3" style="z-index:450">
  <form action="../../includes/paymentProcess3.php" method="POST">
    	<div class="im-modal-content im-animate-top im-card-4">
      		<header style="background-color: purple" class="im-container im-center im-padding-32"> 
        		<span style="background-color: purple" class="im-button im-xlarge im-display-topright" onclick="document.getElementById('ticketModal3').style.display='none'">×</span>
        		<h2 class="im-wide"><i class="fa fa-shopping-cart im-margin-right"></i>Tickets</h2>
      		</header>
      		<div class="im-container">
      			<?php
		if(isset($_SESSION['userID'])){
			echo '<p style="color: black"><label><i class="fa fa-plus-square"></i> Amount</label></p>
        		<input name="amountOfTicket" class="im-input im-border" type="number" min="1" max="5" placeholder="Choose NO. of tickets" id="amount3" oninput="return add3()">
				<div id="all3">
				<div style="display: none;" id="here9">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email1" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here10">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email2" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here11">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email3" class="im-input im-border" type="email" placeholder="email">
				</div>
				<div style="display: none;" id="here12">
				<p style="color: black"><label><i class="fa fa-envelope"></i> Email</label></p> 
				<input name="email4" class="im-input im-border" type="email" placeholder="email">
				</div>
				</div>
        		<button type="submit" name="submit" style="background-color: pink" class="im-button im-block im-padding-16 im-section im-right" onclick="return Validate()">
				<span class="style3">PAY</span></button>
        		<div class="im-section">
        		<br>
        		<br>
				</div>';
		}
		else{
			echo '<p style="color: black" class="im-center"><label><b>Please login to purchase ticket.</b></label></p>';
		}
		?>
      	</div>
    </div>
	</form>
  </div>
  