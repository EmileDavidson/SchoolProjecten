
<?php

// get the q parameter from URL
$FirstName = $_REQUEST["firstname"];
$LastName = $_REQUEST["lastname"];
$Age = $_REQUEST["age"];

if ($FirstName !== "" && $LastName !== "" && $Age !== "") {
    echo "<br><ul><li>FirstName: $FirstName</li><li>LastName: $LastName</li><li>Age: $Age</li></ul><br><br>";

    echo "Recieved at: " . date("Y-m-d") . "<br>";
    echo "Time: " . date("h-i-s-a") . "<br>";
    return;
}
echo "INVALID INPUT";
return;
?>
