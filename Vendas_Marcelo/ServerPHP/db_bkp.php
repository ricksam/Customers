<?php 
  function db_open()
  {
    $cnn = mysql_connect('localhost', 'ricksam_root', '6px2erjr');
    mysql_select_db("ricksam_marcelovendas", $cnn);
    return $cnn;
  }
      
  function db_query($sql,$cnn)
  {
    return mysql_query($sql,$cnn);
  }
  
  function db_insert_id($cnn)
  {
    return mysql_insert_id($cnn);
  }
  
  function db_num_rows($query)
  {
    return mysql_num_rows($query);
  }
  
  function db_fetch_assoc($query)
  {
    return mysql_fetch_assoc($query);
  }
  
  function db_error()
  {
    return mysql_error();
  }
  
  function db_close()
  {
    mysql_close();
  }
?>