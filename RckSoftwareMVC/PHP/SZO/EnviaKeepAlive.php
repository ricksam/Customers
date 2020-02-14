<?php
  include("db.php");
  $mysqli = getDb();

  $query = 
    sprintf("insert into SZO_KPA_KEEP_ALIVE(KPA_TIMESTAMP, KPA_IDENTIFICACAO, KPA_VERSAO) values('%s', '%s', '%s')",
      date("Y-m-d H:i:s"),
      $_POST["Id"],
      $_POST["Versao"]);

  if(mysqli_query($mysqli, $query)){
    echo "true";
  }else{
    printf("Error: %s\n query: %s\n", mysqli_error($mysqli), $query);
  }
  mysqli_close($mysqli);
?>