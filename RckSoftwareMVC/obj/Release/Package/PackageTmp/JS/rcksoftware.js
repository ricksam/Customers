function ClearContato()
{
  setValue('contato_nome', '');
  setValue('contato_email', '');
  setValue('contato_message', '');
  setHTML('lblMessage', '');
}

function ExibeDiv(div)
{
  if(div == 'Home'){ showObject('dvHome'); }else{ hideObject('dvHome'); }
  if(div == 'Servicos'){ showObject('dvServicos'); }else{ hideObject('dvServicos'); }
  if(div == 'Download'){ showObject('dvDownload'); }else{ hideObject('dvDownload'); }
  if(div == 'Contato')
  { 
    showObject('dvContato'); 
    showObject('contato_campos');
    ClearContato();
  }
  else
  { hideObject('dvContato'); }
  
}

function EnviarEmail()
{
  var nome = getValue('contato_nome');
  var email = getValue('contato_email');
  var message = getValue('contato_message');
  
  var msg_erro = "";
  
  if(nome.length == 0)
  { msg_erro += 'Informe seu nome<br />'; }
  
  if(email.length == 0)
  { msg_erro += 'Informe seu email<br />'; }
  
  if(message.length == 0)
  { msg_erro += 'Informe sua mensagem<br />'; }
  
  if(msg_erro.length != 0)
  {
    setHTML('lblMessage',msgErro(msg_erro));
    return;
  }
  
  message = 
  '<p>'+
  'Nome:'+nome+'<br/>'+
  'Email:'+email+'<br/>'+
  'Mensagem:'+message+'<br/>'+
  '</p>';
  
  var link = 'http://www.rcksoftware.com.br/service/mail.php';
  var args = '?to=jricksam@gmail.com&subject=Mensagem RCK Software&message='+ message;
  
  var cmd = link + args;
  
  hideObject('contato_campos');
  //makeRequest(cmd, alertContents);
  
  setHTML('lblMessage',msgInfo('enviando ...'));
  req = createRequest();
  sendRequest(req, cmd, function(){ alertContents(req) });
    
}

function alertContents(http_request) 
{
  if(http_request.readyState == 4)
  {
    setHTML('lblMessage', msgInfo('Email enviado com sucesso!'));
  }
}