<?php
	include("db.php");
	$mysqli = getDb();


	$query = sprintf("select CTK_CODIGO from SZO_CTK_CADASTRO_TICKETS WHERE CTK_MD5 = '%s'", $_POST["CTK_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$CTK_CODIGO = 0;
		while ($row = mysqli_fetch_row($result)) {
			$CTK_CODIGO = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["CTK_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($CTK_CODIGO == 0){
		$query = 
		    sprintf("insert into SZO_CTK_CADASTRO_TICKETS(CTK_TIMESTAMP, CTK_MD5, CTK_DESCRICAO, CTK_VALOR, CTK_DOM, CTK_SEG, CTK_TER, CTK_QUA, CTK_QUI, CTK_SEX, CTK_SAB, CTK_INATIVO, CTK_SINCRONIZADO, CTK_ATALHO) values('%s', '%s', '%s', %s, %s, %s, %s, %s, %s, %s, %s, %s, %s, '%s')",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["CTK_DESCRICAO"],
				toDbDecimal($_POST["CTK_VALOR"]),
				$_POST["CTK_DOM"]?"1":"0",
				$_POST["CTK_SEG"]?"1":"0",
				$_POST["CTK_TER"]?"1":"0",
				$_POST["CTK_QUA"]?"1":"0",
				$_POST["CTK_QUI"]?"1":"0",
				$_POST["CTK_SEX"]?"1":"0",
				$_POST["CTK_SAB"]?"1":"0",
				$_POST["CTK_INATIVO"]?"1":"0",
				"1",
				$_POST["CTK_ATALHO"]);
		}else{
			$query = sprintf("update SZO_CTK_CADASTRO_TICKETS set CTK_TIMESTAMP='%s', CTK_MD5='%s', CTK_DESCRICAO='%s', CTK_VALOR=%s, CTK_DOM=%s, CTK_SEG=%s, CTK_TER=%s, CTK_QUA=%s, CTK_QUI=%s, CTK_SEX=%s, CTK_SAB=%s, CTK_INATIVO=%s, CTK_SINCRONIZADO=%s, CTK_ATALHO='%s' where CTK_CODIGO=%s",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["CTK_DESCRICAO"],
				toDbDecimal($_POST["CTK_VALOR"]),
				$_POST["CTK_DOM"]?"1":"0",
				$_POST["CTK_SEG"]?"1":"0",
				$_POST["CTK_TER"]?"1":"0",
				$_POST["CTK_QUA"]?"1":"0",
				$_POST["CTK_QUI"]?"1":"0",
				$_POST["CTK_SEX"]?"1":"0",
				$_POST["CTK_SAB"]?"1":"0",
				$_POST["CTK_INATIVO"]?"1":"0",
				"1",
				$_POST["CTK_ATALHO"],
			    $CTK_CODIGO
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