<?php
	include("db.php");
	$mysqli = getDb();


	$query = sprintf("select FPG_CODIGO from SZO_FPG_FORMA_PAGAMENTO WHERE FPG_MD5 = '%s'", $_POST["FPG_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$FPG_CODIGO = 0;
		while ($row = mysqli_fetch_row($result)) {
			$FPG_CODIGO = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["FPG_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($FPG_CODIGO == 0){
		$query = 
		    sprintf("insert into SZO_FPG_FORMA_PAGAMENTO(FPG_TIMESTAMP, FPG_MD5, FPG_DESCRICAO, FPG_INATIVO, FPG_SINCRONIZADO) values('%s', '%s', '%s', %s, %s)",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["FPG_DESCRICAO"],
				$_POST["FPG_INATIVO"]?"1":"0",
				"1");
		}else{
			$query = sprintf("update SZO_FPG_FORMA_PAGAMENTO set FPG_TIMESTAMP='%s', FPG_MD5='%s', FPG_DESCRICAO='%s', FPG_INATIVO=%s, FPG_SINCRONIZADO=%s where FPG_CODIGO = %s",
				date("Y-m-d H:i:s"),
			    $md5,
			    $_POST["FPG_DESCRICAO"],
			    $_POST["FPG_INATIVO"]?"1":"0",
			    "1",
			    $FPG_CODIGO);
			
		}

		if($result = mysqli_query($mysqli, $query)){
			echo $result;
		}
		else{
			printf("Error: %s\n query: %s\n", mysqli_error($mysqli), $query);
		}
	}


	mysqli_close($mysqli);
?>