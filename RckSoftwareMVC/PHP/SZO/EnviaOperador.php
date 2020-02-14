<?php
	include("db.php");
	$mysqli = getDb();


	$query = sprintf("select OPR_CODIGO from SZO_OPR_OPERADORES WHERE OPR_MD5 = '%s'", $_POST["OPR_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$OPR_MD5 = 0;
		while ($row = mysqli_fetch_row($result)) {
			$OPR_MD5 = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["OPR_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($OPR_MD5 == 0){
		$query = 
		    sprintf("insert into SZO_OPR_OPERADORES(OPR_TIMESTAMP, OPR_MD5, OPR_NOME, OPR_SENHA, OPR_GERENCIA, OPR_CANCELAR_ITEM, OPR_CANCELAR_CUPOM, OPR_INATIVO, OPR_SINCRONIZADO) values('%s', '%s', '%s', '%s', %s, %s, %s, %s, %s)",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["OPR_NOME"],
				$_POST["OPR_SENHA"],
				$_POST["OPR_GERENCIA"]?"1":"0",
				$_POST["OPR_CANCELAR_ITEM"]?"1":"0",
				$_POST["OPR_CANCELAR_CUPOM"]?"1":"0",
				$_POST["OPR_INATIVO"]?"1":"0",
				"1");
		}else{
			$query = sprintf("update SZO_OPR_OPERADORES set OPR_TIMESTAMP='%s', OPR_MD5='%s', OPR_NOME='%s', OPR_SENHA='%s', OPR_GERENCIA=%s, OPR_CANCELAR_ITEM=%s, OPR_CANCELAR_CUPOM=%s, OPR_INATIVO=%s, OPR_SINCRONIZADO=%s where OPR_CODIGO=%s",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["OPR_NOME"],
				$_POST["OPR_SENHA"],
				$_POST["OPR_GERENCIA"]?"1":"0",
				$_POST["OPR_CANCELAR_ITEM"]?"1":"0",
				$_POST["OPR_CANCELAR_CUPOM"]?"1":"0",
				$_POST["OPR_INATIVO"]?"1":"0",
				"1",
				$_POST["OPR_CODIGO"]);
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