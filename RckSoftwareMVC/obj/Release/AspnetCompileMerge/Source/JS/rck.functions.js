function createRequest()
{
  var http_request = false;
     
     if (window.XMLHttpRequest) { // Mozilla, Safari, ...
            http_request = new XMLHttpRequest();
            if (http_request.overrideMimeType) {
                http_request.overrideMimeType('text/xml');
                // See note below about this line
            }
        } else if (window.ActiveXObject) { // IE
            try {
                http_request = new ActiveXObject("Msxml2.XMLHTTP");
            } catch (e) {
                try {
                    http_request = new ActiveXObject("Microsoft.XMLHTTP");
                } catch (e) {}
            }
        }
        
        
        if (!http_request) {
            alert('Giving up :( Cannot create an XMLHTTP instance');
            return false;
        }
  return http_request;
}

function sendRequest(http_request, url, callback)
{
  http_request.onreadystatechange = callback;
  http_request.open('GET', url, true );
  http_request.send(null);
}

function makeRequest(url, callback) {
        var http_request = false;
     
     if (window.XMLHttpRequest) { // Mozilla, Safari, ...
            http_request = new XMLHttpRequest();
            if (http_request.overrideMimeType) {
                http_request.overrideMimeType('text/xml');
                // See note below about this line
            }
        } else if (window.ActiveXObject) { // IE
            try {
                http_request = new ActiveXObject("Msxml2.XMLHTTP");
            } catch (e) {
                try {
                    http_request = new ActiveXObject("Microsoft.XMLHTTP");
                } catch (e) {}
            }
        }
        
        
        if (!http_request) {
            alert('Giving up :( Cannot create an XMLHTTP instance');
            return false;
        }
        
        //var url = 'http://api.aatag.com/OAuth/Access.aspx?token=18116224449161803510624918483146354210725523982129193&method=AddPhone&args={"IsUnique":false,"DDI":"55","DDD":"15","Number":"22222222","ActivationCode":""}';
                
        //http_request.onreadystatechange = function() { alertContents(http_request); };
        http_request.onreadystatechange = callback;
        http_request.open('GET', url, true );
        http_request.send(null);
    }
    
function alertContents(http_request) {
       //Considera-se concluido quando http_request.readyState = 4
       //alert(http_request.readyState);
        //document.getElementById('spid').innerHTML = http_request.status ;
        //if (http_request.readyState == 4) {
          //  if (http_request.status == 200) {
            //  document.getElementById('spid').innerHTML = http_request.responseText ;
            //} else {
              //  alert('There was a problem with the request.');
            //}
        //}

    }
    
function showObject(objectName) {    
document.getElementById(objectName).style.display = 'block';
}

function hideObject(objectName) {    
document.getElementById(objectName).style.display = 'none';
}

function setHTML(objectId, val){
  document.getElementById(objectId).innerHTML = val;
}

function getHTML(objectId){
  return document.getElementById(objectId).innerHTML;
}

function setValue(objectId, val){
  document.getElementById(objectId).value = val;
}

function getValue(objectId){
  return document.getElementById(objectId).value;
}

function msgInfo(msg)
{
  return "<div class='info'>" + msg + "</div>";
}

function msgErro(msg)
{
  return "<div class='erro'>" + msg + "</div>";
}