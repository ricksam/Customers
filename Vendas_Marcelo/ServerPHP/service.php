<?php     
  /*$method = $_GET["method"];
  $id = $_GET["id"];
  $empresa = $_GET["empresa"];
  $emissao = $_GET["emissao"];
  $operador = $_GET["operador"];  
  $total = $_GET["total"];*/
  
  /*
  EXEMPLOS DE COMANDOS:
  POST  : http://localhost:90/marcelo_vendas/service.php?method=post&empresa=RCKSOFWTARE&emissao=2011-01-01&operador=RICARDO&total=100.00
  GET   : http://localhost:90/marcelo_vendas/service.php?method=get
  DELETE: http://localhost:90/marcelo_vendas/service.php?method=delete&id=1
  */
  
  $method = $_GET["method"];
  $id = $_POST["id"];
  $empresa = $_POST["empresa"];
  $emissao = $_POST["emissao"];
  $operador = $_POST["operador"];  
  $total = $_POST["total"];
  
  if(empty($method))
  {
    echo "Informe um dos methods: post, get, delete";
    exit;
  }
  
  if($method == "post" && (empty($empresa)||empty($emissao)||empty($operador)||empty($total)))
  {
    echo "Informe os parâmetros: empresa, emissao, operador, total";
    exit;
  }
  
  if($method == "delete" && empty($id))
  {
    echo "Para deletar informe o id";
    exit;
  }
  
  include "db.php";
  $cnn = db_open();
  
  if(!$cnn)
  {
    echo '<br />Não pode conectar ao banco de dados'; 
    exit;
  }
  
  if($method == "post")
  {
    $sql = sprintf(
      "INSERT INTO VENDAS (EMPRESA, EMISSAO, OPERADOR, TOTAL) VALUES('%s', '%s', '%s', %s)", 
      $empresa, $emissao, $operador, $total
    );
    
    if (!db_query($sql))
    { echo"Error:".db_error(); }
    else
    { echo "sucessfully"; }
  }
  else if($method == "get")
  {
    $sql = "SELECT * FROM VENDAS";
    $result = db_query($sql);
    
    if(!$result)
    { 
      echo '<br />Erro na consulta';
      exit;
    }
    
    $current_row = 0;
    $rows = db_num_rows($result);
    $rows_json = "";
    
    while ($row = db_fetch_assoc($result)) 
    {
      $current_row += 1;
      $row_json = sprintf(
        '{id:%s, empresa:"%s", emissao:"%s", operador:"%s", total:%s}', 
        $row['ID'], $row['EMPRESA'], $row['EMISSAO'], $row['OPERADOR'], $row['TOTAL']
      );
      
      $virg = "";
      if($current_row!=$rows)
      { $virg = ","; }      
      $rows_json = $rows_json.$row_json.$virg;
    }
    echo sprintf("[%s]", $rows_json);    
  }
  else if($method == "delete")
  {
    $sql = sprintf("DELETE FROM VENDAS WHERE ID = %s", $id);
    
    if (!db_query($sql))
    { echo"Error:".db_error(); }
    else
    { echo "sucessfully"; }
  }
  db_close();
?>