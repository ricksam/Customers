<?php
	include("db.php");
	$mysqli = getDb();

	$query = "SELECT KPA_IDENTIFICACAO, KPA_VERSAO, SEC_TO_TIME(TIME_TO_SEC(MAX(KPA_TIMESTAMP))+60*60*-3) AS HORA FROM SZO_KPA_KEEP_ALIVE 
          WHERE CAST(KPA_TIMESTAMP AS DATE) = CAST(NOW() AS DATE)
          GROUP BY KPA_IDENTIFICACAO, KPA_VERSAO
          ORDER BY KPA_CODIGO DESC";

	if ($result = mysqli_query($mysqli, $query)) {
		$response = "";
		while ($row = mysqli_fetch_row($result)) {
			$response += (empty($response)?"":"|").sprintf("{0} ({1}) {2}",
				$row[0],
				$row[1],
				date_format(strtotime($row[2]),"Y/m/d H:i:s"));
		}
		mysqli_free_result($result);
	}

	mysqli_close($mysqli);
?>