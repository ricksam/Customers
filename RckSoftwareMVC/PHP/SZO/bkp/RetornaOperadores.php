<?php
  include("db.php");
  $mysqli = getDb();

  $timestamp = $_GET["TimeStamp"];

  $query = 
    "SELECT OPR_CODIGO, OPR_TIMESTAMP, OPR_MD5, OPR_NOME, OPR_SENHA, OPR_GERENCIA, OPR_CANCELAR_ITEM, ".
    "OPR_CANCELAR_CUPOM, OPR_INATIVO, OPR_SINCRONIZADO ".
    "FROM SZO_OPR_OPERADORES WHERE OPR_TIMESTAMP > '".$timestamp."'";

  $json = "";
  if ($result = mysqli_query($mysqli, $query)) {

    while ($row = mysqli_fetch_row($result)) {
    	if(!empty($json)){
			$json .= ",";    		
    	}

        $json .= sprintf (
          "{\"OPR_CODIGO\":%s,".
          "\"OPR_TIMESTAMP\":\"%s\",".
          "\"OPR_MD5\":\"%s\",".
          "\"OPR_NOME\":\"%s\",".
          "\"OPR_SENHA\":\"%s\",".
          "\"OPR_GERENCIA\":%s,".
          "\"OPR_CANCELAR_ITEM\":%s,".
          "\"OPR_CANCELAR_CUPOM\":%s,".
          "\"OPR_INATIVO\":%s,".
          "\"OPR_SINCRONIZADO\":%s}",
        	$row[0],
          toDate($row[1]),
          $row[2],
          $row[3],
          $row[4],
          toBool($row[5]),
          toBool($row[6]),
          toBool($row[7]),
          toBool($row[8]),
          toBool($row[9]));
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