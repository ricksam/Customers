<?php
	include("db.php");
	$mysqli = getDb();

	$query = sprintf("select VDA_CODIGO from SZO_VDA_VENDA where VDA_MD5 = '%s'", $_POST["VDA_MD5"]);

	if ($result = mysqli_query($mysqli, $query)) {
		$VDA_CODIGO = 0;
		while ($row = mysqli_fetch_row($result)) {
			$VDA_CODIGO = $row[0];
		}
		mysqli_free_result($result);

		$md5=$_POST["VDA_MD5"];

		if(empty($md5)){
			$md5=md5(com_create_guid());
		}

		if($VDA_CODIGO == 0){
		$query = 
		    sprintf("insert into SZO_VDA_VENDA(VDA_TIMESTAMP, VDA_MD5, VDA_IDENTIFICACAO, VDA_OPR_MD5, VDA_MOVIMENTO, VDA_TOTAL, VDA_TOTAL_PAGO, VDA_TROCO, VDA_SINCRONIZADO) 
				values('%s', '%s', '%s', '%s', '%s', %s, %s, %s, %s)",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["VDA_IDENTIFICACAO"],
				$_POST["VDA_OPR_MD5"],
				$_POST["VDA_MOVIMENTO"],
				toDbDecimal($_POST["VDA_TOTAL"]),
				toDbDecimal($_POST["VDA_TOTAL_PAGO"]),
				toDbDecimal($_POST["VDA_TROCO"]),
				"1");
		}else{
			$query = sprintf("update SZO_VDA_VENDA 
				set VDA_TIMESTAMP='%s', VDA_MD5='%s', VDA_IDENTIFICACAO='%s', VDA_OPR_MD5='%s', VDA_MOVIMENTO='%s', VDA_TOTAL=%s, VDA_TOTAL_PAGO=%s, VDA_TROCO=%s, VDA_SINCRONIZADO=%s 
				where VDA_CODIGO=%s",
				date("Y-m-d H:i:s"),
				$md5,
				$_POST["VDA_IDENTIFICACAO"],
				$_POST["VDA_OPR_MD5"],
				$_POST["VDA_MOVIMENTO"],
				toDbDecimal($_POST["VDA_TOTAL"]),
				toDbDecimal($_POST["VDA_TOTAL_PAGO"]),
				toDbDecimal($_POST["VDA_TROCO"]),
				"1",
			    $VDA_CODIGO
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