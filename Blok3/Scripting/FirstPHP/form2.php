<?php
$string1 = "";
$string2 = "";
$string3 = "";
$string4 = "";
$validmail = false;
$valid = "good";
	if (isset($_GET['submit']))  // heeft HTML gegevens verzonden?
	{
		$string1 = $_GET['input1'];
		$string2 = $_GET['input2'];
		$string3 = $string1;
		$string3 .= $string2;
		$string4 = $_GET['input3'];
}
?>

<!DOCTYPE html>
<html lang="nl">
	 <head>
		<meta charset="utf-8">
		<meta name="description" content="Scripting MD1A MD1B">
		<meta name="author" content="Ma">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<link href="https://fonts.googleapis.com/css?family=Source+Code+Pro" rel="stylesheet">
		<link rel="stylesheet" type="text/css" href="style.css">
		<title>PHP String handler opdracht</title>
	</head>
	 <body>
		<img src ="https://www.ma-web.nl/static/vector/Logo_blok.svg"  alt = "logo" width = "30">
		<div class="wrapper">
			<form method="GET" action="form2.php">
				<fieldset>
				 <legend>Stringhandler basis [PHP SITE]</legend>
				 <input type = "text" name = "input1"  placeholder = <?php echo $string1 ?>><br>
				 <input type = "text" name = "input2"   placeholder = <?php echo $string2 ?>>
				 <input type = "text" name = "input3" placeholder = <?php echo $string4 ?>>
				 <input type = "submit"  id = "submit" name = "submit" value = "submit">
			 </fieldset>
			</form>
			<hr>
		<ul>
					<li class="showSpaces">Ingevoerde string 1:<strong><span style="color:red"><?php echo $string1 ?></span></strong></li>
					<li class="showSpaces">Ingevoerde string 2:<strong><span style="color:red"><?php echo $string2 ?></span></strong></li>
					<li class="showSpaces">Ingevoerde string 3:<strong><span style="color:red"><?php echo $string4 ?></span></strong></li>
					<li>String 1 getrimd trim(): <strong><span style="color:red"><?php echo trim($string1)?></span></strong> </li>
					<li>String 2 getrimd trim(): <strong><span style="color:red"><?php echo trim($string2)?></span></strong>   </li>
					<li>String 3 is de concatenation van string 1 en string 2: <strong><span style="color:red"><?php echo $string3 ?></span></strong> </li>
					<li>De lengte van string 3 is: <strong><span style="color:red"><?php echo strlen($string3);?></span></strong> characters</li>
					<!-- je kan ook lopen en alle spaces vinden maar dat is voor een andere keer :D -->
					<li>Zoeken naar spaties. Er zit een spatie op positie <strong><span style="color:red">[<?php echo strpos($string1, " ")?>]</span></strong> in string 1</li>
					<li>Zoeken naar spaties. Er zit een spatie op positie <strong><span style="color:red">[<?php echo strpos($string2, " ")?>]</span></strong> in string 2</li>
					<li>Zoeken naar @. Er zit een @ op positie <strong><span style="color:red">[<?php echo strpos($string1, "@");?>]</span></strong> in string 1</li>
					<li>Zoeken naar @. Er zit een @ op positie <strong><span style="color:red">[<?php echo strpos($string2, "@");?>]</span></strong> in string 2</li>
					<li>Zoeken naar "." . Er zit een  "."  op positie <strong><span style="color:red">[<?php echo strpos($string1, ".")?>]</span></strong> in string 1</li>
					<li>Zoeken naar "." . Er zit een  "."  op positie <strong><span style="color:red">[<?php echo strpos($string2, ".")?>]</span></strong> in string 2</li>
					<li>Zoek naar substring <strong>"PHP"</strong> vervang dit door <strong>"NodeJS"</strong> strings: <strong><span style="color:red"><?php echo str_replace("PHP","NodeJS",$string3); ?></span></strong> </li>
					<li>Wijzig de eerste letter van string 3 naar hoofdletter: <strong><span style="color:red"><?php echo ucfirst($string3);?></span></strong></li>
					<li>Alles in hoofdletters: <strong><span style="color:red"><?php echo strtoupper($string3);?></span></strong>  </li>
					<li>Mail valid: <strong><span style="color:red"><?php
					if (filter_var($string4, FILTER_VALIDATE_EMAIL)) {
			  			echo("$string4 is a valid email address");
						} else {
			  		echo("$string4 is not a valid email address");
					}
					 ?></span></strong></li>
			</ul>
			<hr>
			<li>Opdracht:<br> Stringhandler. Maak de PHP code voor <a href="http://schw.hosts.ma-cloud.nl/stringhandler/stringhandler.php">Stringhander<a>
			<li>Hoe moet jij inleveren?: <br>
					1) Link naar de werkende code in jouw portfoliomap bij Ma-cloud<br>
					2) Link naar jouw code bij GITHUB</li>
			<li>Bonus opdracht: maak PHP code waarmee jij controleert of een input een geldig e-mail adres zou kunnen zijn. Met JS controleren is niet toegestaan.</li>
			<li>Bonus opdracht: na submitten form, schrijf de eerder ingevoerde strings terug met PHP in de formulier invoer velden</li>
			</ol>
		</div>
	 </body>
</html>
