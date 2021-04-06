<?php
if (isset($_POST['InputStr'])) $sysname=$_POST['InputStr']; else $sysname="";
//if(strlen($sysname)>1 && strlen($prjname)>1 && strlen($localip)>1)
{
  $myfile = fopen("./test.txt", "a") or die("Unable to open file!");
  $data=$sysname.",".$_SERVER["REMOTE_ADDR"].",".date("Y/m/d H:i:s");
  fwrite($myfile, $data.PHP_EOL);
  fclose($myfile);
} 
?>