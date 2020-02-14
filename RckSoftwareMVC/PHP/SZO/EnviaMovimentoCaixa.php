<?php
	include("db.php");
	$mysqli = getDb();

	$query = sprintf("select MCX_CODIGO from SZO_MCX_MOVIMENTO_CAIXA where MCX_MD5 = '%s'", $_POST["MCX_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$PGT_CODIGO = 0;
		while ($row = mysqli_fetch_row($result)) {
			$MCX_CODIGO = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["MCX_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($MCX_CODIGO == 0){
		$query = 
		    sprintf("insert into SZO_MCX_MOVIMENTO_CAIXA(MCX_TIMESTAMP, MCX_MD5, MCX_IDENTIFICACAO, MCX_DATA, MCX_MOVIMENTO, MCX_TIPO, MCX_VALOR, MCX_SINCRONIZADO) 
				values('%s', '%s', '%s', '%s', '%s', '%s', %s, %s)",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["MCX_IDENTIFICACAO"],
				$_POST["MCX_DATA"],
				$_POST["MCX_MOVIMENTO"],
				$_POST["MCX_TIPO"],
				toDbDecimal($_POST["MCX_VALOR"]),
				"1");
		}else{
			$query = sprintf("update SZO_MCX_MOVIMENTO_CAIXA 
				set MCX_TIMESTAMP='%s', MCX_MD5='%s', MCX_IDENTIFICACAO='%s', MCX_DATA='%s', MCX_MOVIMENTO='%s', MCX_TIPO='%s', MCX_VALOR=%s, MCX_SINCRONIZADO=%s 
				where MCX_CODIGO=%s",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["MCX_IDENTIFICACAO"],
				$_POST["MCX_DATA"],
				$_POST["MCX_MOVIMENTO"],
				$_POST["MCX_TIPO"],
				toDbDecimal($_POST["MCX_VALOR"]),
				"1",
			    $MCX_CODIGO
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