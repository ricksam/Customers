<?php
 	include("db.php");
	$mysqli = getDb();

	$data = $_POST["id"];
	$format = "%Y-%c-%e";

	$Interira = getDbValue($mysqli, sprintf(
				"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '%s') = %s 
                AND VTK_DESCRICAO = 'INTEIRA'", $format, Quoted($data)));

	$Meia = getDbValue($mysqli, sprintf(
				"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '%s') = %s 
                AND VTK_DESCRICAO = 'MEIA'", $format, Quoted($data)));

	$Isento = getDbValue($mysqli, sprintf(
				"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '%s') = %s 
                AND VTK_DESCRICAO = 'ISENTO'", $format, Quoted($data)));

	$Vendas = getDbValue($mysqli, sprintf(
				"SELECT SUM(VTK_VALOR) AS TOTAL
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '%s') = %s ", $format, Quoted($data)));

	$Suprimento = getDbValue($mysqli, sprintf(
				"SELECT SUM(MCX_VALOR) FROM SZO_MCX_MOVIMENTO_CAIXA  
              WHERE MCX_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
              AND DATE_FORMAT(MCX_DATA, '%s') = %s 
              AND MCX_TIPO = 'SUPRIMENTO'", $format, Quoted($data)));

	$Sangria = getDbValue($mysqli, sprintf(
				"SELECT SUM(MCX_VALOR) FROM SZO_MCX_MOVIMENTO_CAIXA  
              WHERE MCX_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
              AND DATE_FORMAT(MCX_DATA, '%s') = %s 
              AND MCX_TIPO = 'SANGRIA'", $format, Quoted($data)));

	$Caixa = $Vendas+$Suprimento-$Sangria;

	echo sprintf("%s|%s|%s|%s|%s|%s|%s", 
			$Interira, 
			$Meia, 
			$Isento,
			$Vendas,
			$Suprimento,
			$Sangria,
			$Caixa);

	mysqli_close($mysqli);
?>