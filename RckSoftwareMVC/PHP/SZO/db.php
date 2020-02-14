<?php
	function getDb(){
	  $mysqli = mysqli_connect("187.45.196.220", "rcksoftware", "RCK6px2erjr", "rcksoftware", 3306);
	  
	  /* check connection */
	  if (mysqli_connect_errno()) {
	      printf("Connect failed: %s\n", mysqli_connect_error());
	      exit();
	  }
	  return $mysqli; 
	}

	function toDate($db_date){
		return sprintf("\/Date(%s)\/", (strtotime($db_date)*1000) + 7200000);
	}

	function toBool($db_bool){
		return $db_bool == "1" ? "true" : "false";
	}

	function toDbBool($bool){
		return $bool?"1":"0";
	}

	function toDbDecimal($decimal){
		return str_replace(",",".",$decimal);	
	}

	function getDbValue($mysqli, $query){
		if ($result = mysqli_query($mysqli, $query)) {
			$result = null;
			while ($row = mysqli_fetch_row($result)) {
				$result = $row[0];
			}
			mysqli_free_result($result);
			return $result;
		}
		return null;
	}

	function Quoted($s){
		return "'".str_replace("'","''",$s)."'";
	}
?>