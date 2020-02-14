<!DOCTYPE html>
<html lang="en">
    <?php include '_head.php'; ?>
    <body>
        <?php include '_nav.php'; ?>    



<!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('Template/img/contact-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="page-heading">
                        <h1>Contate-nos</h1>
                        <hr class="small">
                        <span class="subheading">Tem alguma dúvida? Precisa de ajuda com os estudos?</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
              @if (!string.IsNullOrEmpty(ViewBag.success))
              {
              <div class="alert alert-success" role="alert"> <strong>Sucesso!</strong> Mensagem enviada com sucesso! </div>
              }
                <p>Quer entrar em contato conosco? Preencha o formulário abaixo para enviar-nos uma mensagem!</p>
                <!-- Contact Form - Enter your email address on line 19 of the mail/contact_me.php file to make this form work. -->
                <!-- WARNING: Some web hosts do not allow emails to be sent through forms to common mail hosts like Gmail or Yahoo. It's recommended that you use a private domain email address! -->
                <!-- NOTE: To use the contact form, your site must be on a live web host with PHP! The form will not work locally! -->
                <form action="/CCB/contato"  method="post">
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Nome</label>
                            <input type="text" class="form-control" placeholder="Nome" id="nome" name="nome" required data-validation-required-message="Por favor informe o seu nome.">
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Comum (CCB) / Cidade - Estado</label>
                            <input type="text" class="form-control" placeholder="Comum (CCB) / Cidade - Estado" id="comum" name="comum" required data-validation-required-message="Por favor informe o sua comum congregação.">
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Email</label>
                            <input type="email" class="form-control" placeholder="Email" id="email" name="email" required data-validation-required-message="Por favor informe o seu email.">
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Fone</label>
                            <input type="tel" class="form-control" placeholder="Fone" id="fone" name="fone" required data-validation-required-message="Por favor informe o seu telefone para contato.">
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Mensagem</label>
                            <textarea rows="5" class="form-control" placeholder="Mensagem" id="message" name="mensagem" required data-validation-required-message="Por favor informe a mensagem."></textarea>
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <br>
                    <div id="success"></div>
                    <div class="row">
                        <div class="form-group col-xs-12">
                            <button type="submit" class="btn btn-default">Enviar</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>

        
        <?php include '_footer.php'; ?>    
        <?php include '_scripts.php'; ?>
    </body>
</html>
