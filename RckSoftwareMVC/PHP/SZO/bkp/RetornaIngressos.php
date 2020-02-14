<?php
  include("db.php");
  $mysqli = getDb();

  $timestamp = $_GET["TimeStamp"];

  $query = "SELECT CTK_CODIGO, CTK_TIMESTAMP, CTK_MD5, CTK_DESCRICAO, CTK_VALOR, CTK_DOM, CTK_SEG, CTK_TER, CTK_QUA, CTK_QUI, CTK_SEX, CTK_SAB, CTK_INATIVO, CTK_SINCRONIZADO, CTK_ATALHO FROM SZO_CTK_CADASTRO_TICKETS WHERE CTK_TIMESTAMP > '".$timestamp."'";

  $json = "";
  if ($result = mysqli_query($mysqli, $query)) {

    while ($row = mysqli_fetch_row($result)) {
    	if(!empty($json)){
			$json .= ",";    		
    	}

        $json .= sprintf (
          "{\"CTK_CODIGO\":%s,".
          "\"CTK_TIMESTAMP\":\"%s\",".
          "\"CTK_MD5\":\"%s\",".
          "\"CTK_DESCRICAO\":\"%s\",".
          "\"CTK_VALOR\":%s,".
          "\"CTK_DOM\":%s,".
          "\"CTK_SEG\":%s,".
          "\"CTK_TER\":%s,".
          "\"CTK_QUA\":%s,".
          "\"CTK_QUI\":%s,".
          "\"CTK_SEX\":%s,".
          "\"CTK_SAB\":%s,".
          "\"CTK_INATIVO\":%s,".
          "\"CTK_SINCRONIZADO\":%s,".
          "\"CTK_ATALHO\":\"%s\"}",
        	$row[0],
          toDate($row[1]),
          $row[2],
          $row[3],
          $row[4],
          toBool($row[5]),
          toBool($row[6]),
          toBool($row[7]),
          toBool($row[8]),
          toBool($row[9]),
          toBool($row[10]),
          toBool($row[11]),
          toBool($row[12]),
          toBool($row[13]),
          $row[14]);
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