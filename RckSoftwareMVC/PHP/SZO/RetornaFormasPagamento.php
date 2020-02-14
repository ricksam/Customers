<?php
  include("db.php");
  $mysqli = getDb();

  $timestamp = $_GET["TimeStamp"];

  $query = "SELECT FPG_CODIGO, FPG_TIMESTAMP, FPG_MD5, FPG_DESCRICAO, FPG_INATIVO, FPG_SINCRONIZADO ".
  	"FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_TIMESTAMP > '".$timestamp."'";

  $json = "";
  if ($result = mysqli_query($mysqli, $query)) {

    while ($row = mysqli_fetch_row($result)) {
    	if(!empty($json)){
			$json .= ",";    		
    	}

        $json .= sprintf (
        	"{\"FPG_CODIGO\":%s,".
        	"\"FPG_TIMESTAMP\":\"%s\",".
        	"\"FPG_MD5\":\"%s\",".
        	"\"FPG_DESCRICAO\":\"%s\",".
        	"\"FPG_INATIVO\":%s,".
        	"\"FPG_SINCRONIZADO\":%s}",
        	$row[0],
        	toDate($row[1]),
        	$row[2],
        	$row[3],
        	toBool($row[4]),
        	toBool($row[5]));
    }

  	mysqli_free_result($result);
  }
  else{
  	printf("Error: %s\n query: %s\n", mysqli_error($mysqli), $query);
  }

  if(!empty($json)){
  	echo "[".$json."]";
  }
  else{
  	echo "[]";	
  }
  
  mysqli_close($mysqli);
?>