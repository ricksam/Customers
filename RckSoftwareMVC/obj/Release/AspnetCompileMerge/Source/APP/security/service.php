<?php
           
  $method = $_POST["method"];//method=send_image, list_image, list_date 
  $count = $_POST["count"];
  $lastdate = $_POST["lastdate"];
  $date = $_POST["date"];
  $count = $_POST["count"];
  $code = $_POST["code"];
  $authenticate = $_POST["authenticate"];
  $camera = $_POST["camera"];
      
  if(empty($method))
  {
    echo "Informe um dos methods: send_image, list_image, list_date, delete_image, list_cameras";
    exit;
  }
  
  if($method == "send_image" && empty($count))
  {
    echo "Informe o parâmetro: count";
    exit;
  }
  
  if($method == "list_date" && empty($count))
  {
    echo "Informe o parâmetro: count";
    exit;
  }
  
  if($method == "list_image" && empty($lastdate) && empty($count))
  {
    echo "Informe o parâmetro: lastdate, count";
    exit;
  }
  
  include "db.php";
  $cnn = db_open();
  
  if(!$cnn)
  {
    echo '<br />Não pode conectar ao banco de dados'; 
    exit;
  }
  
  if($method == "send_image")
  {
    $image = "";
    for($i = 0; $i < $count; $i++)
	{
	  $field = sprintf("image%s",$i);
	  $image = $image.$_POST[$field]; 
	}
	
    $sql = sprintf(
      "INSERT INTO REG_REGISTRO(REG_DATA, REG_IMAGEM, REG_AUTENTICACAO, REG_CAMERA) VALUES (now(),'%s','%s','%s');", 
      $image, $authenticate, $camera
    );
    
    if (!db_query($sql))
    { echo"Error:".db_error(); }
    else
    { echo "sucessfully"; }
  }
  else if($method == "list_date")
  {
    $sql = sprintf("SELECT DISTINCT CAST(REG_DATA AS DATE) AS REG_DATA FROM REG_REGISTRO WHERE REG_AUTENTICACAO = '%s' ORDER BY REG_DATA", $authenticate);
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
        '"%s"', 
        $row['REG_DATA']
      );
      
      $virg = "";
      if($current_row!=$rows)
      { $virg = ","; }      
      $rows_json = $rows_json.$row_json.$virg;
    }
    echo sprintf("[%s]", $rows_json);    
  }
  else if($method == "last_image")
  {
    $sql = sprintf("
            SELECT * FROM REG_REGISTRO 
            WHERE REG_AUTENTICACAO = '%s'
            ORDER BY REG_CODIGO DESC LIMIT 1", $authenticate);
    $result = db_query($sql);
    
    if(!$result)
    { 
      echo '<br />Erro na consulta';
      exit;
    }
    
    if($row = db_fetch_assoc($result))
    {
      $strImage = $row['REG_IMAGEM'];
      $strImage = str_replace(" ", "+", $strImage);
      echo sprintf("<img src='data:image/jpg;base64,%s' align='left' />", $strImage); 
    }
    else
    { echo "Imagem não encontrada"; }    
  }
  else if($method == "list_image")
  {
    $cond_camera ="";
    
    if(!empty($camera))
    { $cond_camera = sprintf(" AND REG_CAMERA = '%s' ", $camera); }
        
    $sql = sprintf("
            SELECT * FROM REG_REGISTRO 
            INNER JOIN USA_USUARIO_ATIVO ON USA_AUTENTICACAO = REG_AUTENTICACAO
            WHERE REG_CODIGO > %s and CAST(REG_DATA AS DATE) = '%s' AND REG_AUTENTICACAO = '%s'
            %s
            ORDER BY REG_CODIGO LIMIT %s", $code, $lastdate, $authenticate, $cond_camera, $count);
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
        '{id:%s,image:"%s"}', 
        $row['REG_CODIGO'],
        $row['REG_IMAGEM']
      );
      
      $virg = "";
      if($current_row!=$rows)
      { $virg = ","; }      
      $rows_json = $rows_json.$row_json.$virg;
    }
    echo sprintf("[%s]", $rows_json);    
  }
  else if($method == "delete_image")
  {
    if(!empty($code))
    {
      $sql = sprintf("DELETE FROM REG_REGISTRO WHERE REG_CODIGO = %s AND REG_AUTENTICACAO = '%s'", $code, $authenticate);
      $result = db_query($sql);
    }    
    else if(!empty($date))
    {
      $sql = sprintf("DELETE FROM REG_REGISTRO WHERE CAST(REG_DATA AS DATE) = '%s' AND REG_AUTENTICACAO = '%s'", $date, $authenticate);
      $result = db_query($sql);
    }
    else 
    {
      $sql = sprintf("DELETE FROM REG_REGISTRO WHERE REG_AUTENTICACAO = '%s'", $authenticate);
      $result = db_query($sql);
    }
  }
  else if($method == "list_cameras")
  {
    $sql = sprintf("SELECT CAM_DESCRICAO FROM CAM_CAMERAS WHERE CAM_AUTENTICACAO = '%s'", $authenticate);
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
        '"%s"', 
        $row['CAM_DESCRICAO']
      );
      
      $virg = "";
      if($current_row!=$rows)
      { $virg = ","; }      
      $rows_json = $rows_json.$row_json.$virg;
    }
    echo sprintf("[%s]", $rows_json);
  }
  else if($method == "count_frames")
  {
    $sql = sprintf(
      "SELECT COUNT(REG_CODIGO) as QTDE FROM REG_REGISTRO WHERE REG_AUTENTICACAO = '%s' AND REG_CAMERA = '%s'", 
      $authenticate, $camera);
    $result = db_query($sql);
    
    if(!$result)
    { 
      echo '<br />Erro na consulta';
      exit;
    }
    
    $row = db_fetch_assoc($result);
    echo $row['QTDE'];
  }
  
  db_close();
?>