<?php 
  function db_open()
  {
    $cnn = mysql_connect('187.45.196.220', 'rcksoftware', 'RCK6px2erjr');
    mysql_select_db("rcksoftware", $cnn);
    return $cnn;
  }
  
  function db_query($sql)
  {
    return mysql_query($sql);
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