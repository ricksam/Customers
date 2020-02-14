<?php
  include "db.php";
  $cnn = db_open();
  
  if(!$cnn)
  { echo '<br />Não pode conectar ao banco de dados'; }
  else
  { echo '<br />Sucesso na conexão'; }
  
  $method = $_GET["method"];
  $id = $_GET["id"];
  $cnpj = $_GET["cnpj"];
  $empresa = $_GET["empresa"];
  $emissao = $_GET["emissao"];
  $cod_operador = $_GET["cod_operador"];  
  $operador = $_GET["operador"];  
  $inicio = $_GET["inicio"];
  $cupons = $_GET["cupons"];
  $total = $_GET["total"];
  
  echo 'method:'.$method.'<br />';
  echo 'id:'.$id.'<br />';
  echo 'cnpj:'.$cnpj.'<br />';
  echo 'empresa:'.$empresa.'<br />';
  echo 'emissao:'.$emissao.'<br />';
  echo 'cod_operador:'.$cod_operador.'<br />';
  echo 'inicio:'.$inicio.'<br />';
  echo 'cupons:'.$cupons.'<br />';
  echo 'total:'.$total.'<br />';
  
  
?>