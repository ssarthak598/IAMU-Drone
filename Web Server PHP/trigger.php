<?php
$var1 = $_GET['q'];
$myfile = fopen("trigger.html", "w");
fwrite($myfile, $var1);
fclose($myfile);
?>