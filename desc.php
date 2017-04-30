<?php
$var1 = $_GET['q'];
$myfile = fopen("desc.txt", "w");
fwrite($myfile, $var1);
fclose($myfile);
?>