<?php
	include("db.php");
	$mysqli = getDb();

	$query = sprintf("select PGT_CODIGO from SZO_PGT_PAGAMENTO where PGT_MD5 = '%s'", $_POST["PGT_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$PGT_CODIGO = 0;
		while ($row = mysqli_fetch_row($result)) {
			$PGT_CODIGO = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["PGT_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($PGT_CODIGO == 0){
		$query = 
		    sprintf("insert into SZO_PGT_PAGAMENTO(PGT_TIMESTAMP, PGT_MD5, PGT_IDENTIFICACAO, PGT_VDA_MD5, PGT_OPR_MD5, PGT_FPG_MD5, PGT_MOVIMENTO, PGT_DESCRICAO, PGT_VALOR, PGT_SINCRONIZADO) 
				values('%s', '%s', '%s', '%s', '%s', '%s', '%s', '%s', %s, %s)",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["PGT_IDENTIFICACAO"],
				$_POST["PGT_VDA_MD5"],
				$_POST["PGT_OPR_MD5"],
				$_POST["PGT_FPG_MD5"],
				$_POST["PGT_MOVIMENTO"],
				$_POST["PGT_DESCRICAO"],
				toDbDecimal($_POST["PGT_VALOR"]),
				"1");
		}else{
			$query = sprintf("update SZO_PGT_PAGAMENTO 
				set PGT_TIMESTAMP='%s', PGT_MD5='%s', PGT_IDENTIFICACAO='%s', PGT_VDA_MD5='%s', PGT_OPR_MD5='%s', PGT_FPG_MD5='%s', PGT_MOVIMENTO='%s', PGT_DESCRICAO='%s', PGT_VALOR=%s, PGT_SINCRONIZADO=%s 
				where PGT_CODIGO=@PGT_CODIGO",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["PGT_IDENTIFICACAO"],
				$_POST["PGT_VDA_MD5"],
				$_POST["PGT_OPR_MD5"],
				$_POST["PGT_FPG_MD5"],
				$_POST["PGT_MOVIMENTO"],
				$_POST["PGT_DESCRICAO"],
				toDbDecimal($_POST["PGT_VALOR"]),
				"1",
			    $PGT_CODIGO
		    );	
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