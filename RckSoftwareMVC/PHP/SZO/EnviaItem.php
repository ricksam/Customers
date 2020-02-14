<?php
	include("db.php");
	$mysqli = getDb();

	$query = sprintf("select VTK_CODIGO from SZO_VTK_VENDA_TICKETS where VTK_MD5 = '%s'", $_POST["VTK_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$VTK_CODIGO = 0;
		while ($row = mysqli_fetch_row($result)) {
			$VTK_CODIGO = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["VTK_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($VTK_CODIGO == 0){
		$query = 
		    sprintf("insert into SZO_VTK_VENDA_TICKETS(VTK_TIMESTAMP, VTK_MD5, VTK_IDENTIFICACAO, VTK_VDA_MD5, VTK_OPR_MD5, VTK_CTK_MD5, VDA_MOVIMENTO, VTK_DATA, VTK_DESCRICAO, VTK_VALOR, VTK_SINCRONIZADO) 
				values('%s', '%s', '%s', '%s', '%s', '%s', '%s', '%s', '%s', %s, %s)",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["VTK_MD5"],
				$_POST["VTK_IDENTIFICACAO"],
				$_POST["VTK_VDA_MD5"],
				$_POST["VTK_OPR_MD5"],
				$_POST["VTK_CTK_MD5"],
				$_POST["VDA_MOVIMENTO"],
				$_POST["VTK_DATA"],
				$_POST["VTK_DESCRICAO"],
				toDbDecimal($_POST["VTK_VALOR"]),
				"1");
		}else{
			$query = sprintf("update SZO_VTK_VENDA_TICKETS 
				set VTK_TIMESTAMP='%s', VTK_MD5='%s', VTK_IDENTIFICACAO='%s', VTK_VDA_MD5='%s', VTK_OPR_MD5='%s', VTK_CTK_MD5='%s', VDA_MOVIMENTO='%s', VTK_DATA='%s', VTK_DESCRICAO='%s', VTK_VALOR=%s, VTK_SINCRONIZADO=%s 
				where VTK_CODIGO=@VTK_CODIGO",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["VTK_MD5"],
				$_POST["VTK_IDENTIFICACAO"],
				$_POST["VTK_VDA_MD5"],
				$_POST["VTK_OPR_MD5"],
				$_POST["VTK_CTK_MD5"],
				$_POST["VDA_MOVIMENTO"],
				$_POST["VTK_DATA"],
				$_POST["VTK_DESCRICAO"],
				toDbDecimal($_POST["VTK_VALOR"]),
				"1",
			    $VTK_CODIGO
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