<?php
  	$file = fopen("data.json", 'w+');
	$line = $_POST["data"];
	fwrite($file, $line);
	fclose($file);
?>
