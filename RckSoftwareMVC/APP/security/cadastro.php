<?php 
  $erro_email = "erro no email";
  $erro_senha = "erro na senha";
?>

<html>
  <head>
  </head>
  
  <body>
    <div class="register">
      <form action="" method="post">
        <label>Email</label><span class="erro"><?php echo $erro_email;?></span><br />
        <input type="text" name="Email" /><br />
        <label>Senha</label><span class="erro"><?php echo $erro_senha;?></span><br />
        <input type="password" name="Senha" /><br />
        <input type="submit" /><br />
      </form>
    </div>
  </body>
</html>