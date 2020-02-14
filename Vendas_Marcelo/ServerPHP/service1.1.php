<?php         
  /*
  EXEMPLOS DE COMANDOS:
  POST      : http://localhost:90/marcelo_vendas/service1.1.php?method=post&empresa=RCKSOFWTARE&emissao=2011-01-01&operador=RICARDO&total=100.00
  GET       : http://localhost:90/marcelo_vendas/service1.1.php?method=get
  DELETE    : http://localhost:90/marcelo_vendas/service1.1.php?method=delete&id=1
  ADDREPORT : http://localhost:90/marcelo_vendas/service1.1.php?method=addreport&htmlcode=xxx
  */
  
  $method = $_GET["method"];
  $id = $_POST["id"];
  $cnpj = $_POST["cnpj"];
  $empresa = $_POST["empresa"];
  $emissao = $_POST["emissao"];
  $cod_operador = $_POST["cod_operador"];  
  $operador = $_POST["operador"];  
  $inicio = $_POST["inicio"];
  $cupons = $_POST["cupons"];
  $total = $_POST["total"];
  $htmlcode = $_POST["htmlcode"];
  $securitycode = $_POST["securitycode"];
  
  if(empty($method))
  {
    echo "Informe um dos methods: post, get, delete, addreport";
    exit;
  }
  
  if($method == "post" && (empty($cnpj) || empty($empresa) || empty($emissao) || empty($cod_operador) || empty($operador) || empty($inicio)|| empty($cupons) || empty($total)))
  {
    //echo "Informe os parâmetros: cnpj, empresa, emissao, cod_operador, operador, inicio, cupons, total";
    
    if(empty($cnpj))
    { echo "Informe o campo cnpj"; }
    
    if(empty($empresa))
    { echo "Informe o campo empresa"; }
    
    if(empty($emissao))
    { echo "Informe o campo emissao"; }
    
    if(empty($cod_operador))
    { echo "Informe o campo cod_operador"; }
    
    if(empty($operador))
    { echo "Informe o campo operador"; }
    
    if(empty($inicio))
    { echo "Informe o campo inicio"; }
    
    if(empty($cupons))
    { echo "Informe o campo cupons"; }
    
    if(empty($total))
    { echo "Informe o campo total"; }
    
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
      "INSERT INTO VENDAS (CNPJ, EMPRESA, EMISSAO, COD_OPERADOR, OPERADOR, INICIO, CUPONS, TOTAL) VALUES('%s', '%s', '%s', %s, '%s', '%s', %s, %s)", 
      $cnpj, $empresa, $emissao, $cod_operador, $operador, $inicio, $cupons, $total
    );
    
    if (!db_query($sql,$cnn))
    { echo"Error:".db_error(); }
    else
    { echo "sucessfully"; }
  }
  else if($method == "get")
  {
    $sql = "SELECT * FROM VENDAS";
    $result = db_query($sql,$cnn);
    
    if(!$result)
    { 
      echo '<br />Erro na consulta';
      exit;
    }
    
    $current_row = 0;
    $rows = db_num_rows($result);
    $rows_json = "";
    
    while ($row = mysql_fetch_assoc($result)) 
    {
      $current_row += 1;
      
      $inicio = $row['INICIO'];
      if(empty($inicio))
      { $inicio = "00:00:00"; }
      
      $cupons = $row['CUPONS'];
      if(empty($cupons))
      { $cupons = 0; }
      
      $cod_operador = $row['COD_OPERADOR'];
      if(empty($cod_operador))
      { $cod_operador = 0; }
      
      $row_json = sprintf(
        '{id:%s, cnpj:"%s", empresa:"%s", emissao:"%s", cod_operador:%s, operador:"%s", inicio:"%s", cupons:%s, total:%s}', 
        $row['ID'], $row['CNPJ'], $row['EMPRESA'], $row['EMISSAO'], $cod_operador, $row['OPERADOR'], $inicio, $cupons, $row['TOTAL']
      );
      
      $virg = "";
      if($current_row != $rows)
      { $virg = ","; }      
      $rows_json = $rows_json.$row_json.$virg;
    }
    echo sprintf("[%s]", $rows_json);    
  }
  else if($method == "delete")
  {
    $sql = sprintf("DELETE FROM VENDAS WHERE ID = %s", $id);
    
    if (!db_query($sql,$cnn))
    { echo"Error:".db_error(); }
    else
    { echo "sucessfully"; }
  }
  else if($method == "addreport")
  {
    $sql = sprintf("INSERT INTO RELATORIO(HTML_CODE,CHAVE_ACESSO) VALUES ('%s','%s')", $htmlcode, $securitycode);
    
    if (!db_query($sql,$cnn))
    { echo "Error:".db_error(); }
    else
    { echo db_insert_id($cnn); }    
  }
  else if($method == "report")
  {
    $id = $_GET["id"];
    $securitycode = $_GET["securitycode"];
    
    $sql = sprintf("SELECT HTML_CODE FROM RELATORIO where ID = %s and CHAVE_ACESSO = '%s'", $id, $securitycode);
    $result = db_query($sql,$cnn);
    
    if(!$result)
    { 
      echo '<br />Erro na consulta';
      exit;
    }
    
    $row = mysql_fetch_assoc($result);
    echo $row['HTML_CODE'];    
  }
  db_close();
?>