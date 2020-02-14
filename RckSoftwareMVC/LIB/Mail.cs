using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace lib.Class
{
  public class Mail
  {
    #region Constructors            
    public Mail() 
    {
      Initialize("", "", "", false, false, 0);
    }

    public Mail(string aSMTPClient, string aSMTPUser, string aSMTPPassword, bool aEnableSSL = false, bool aRequireAutentication = false, int aPort = 0)
    { Initialize(aSMTPClient, aSMTPUser, aSMTPPassword, aEnableSSL, aRequireAutentication, aPort); }
    #endregion

    #region Fields
    private MailMessage mail { get; set; }
    public string SMTPUser { get; set; }
    public string SMTPPassword{ get; set; }
    public string SMTPClient{ get; set; }
    public bool EnableSSL{ get; set; }
    public bool RequireAutentication { get; set; }
    public int Port { get; set; }
    public string ReplayTo { get; set; }
    #endregion

    #region Métodos
    #region private void Initialize(string aSMTPClient, string aSMTPUser, string aSMTPPassword, bool aEnableSSL, bool aRequireAutentication, int aPort)
    private void Initialize(string aSMTPClient, string aSMTPUser, string aSMTPPassword, bool aEnableSSL, bool aRequireAutentication, int aPort)
    {
      mail = new MailMessage();
      this.SMTPClient = aSMTPClient;
      this.SMTPUser = aSMTPUser;
      this.SMTPPassword = aSMTPPassword;
      this.EnableSSL = aEnableSSL;
      this.RequireAutentication = aRequireAutentication;
      this.Port = aPort;
    }
    #endregion

    #region public void SendMail(string StringMessage = null,bool IsBodyHtml, string To = null, string Subject = null, string[] Cc = null, string[] Bcc = null, List<string> AttachamentsFile = null)
    public void SendMail(string StringMessage, bool IsBodyHtml, string To, string Subject, string[] Cc = null, string[] Bcc = null, List<string> AttachamentFiles = null) {
        List<Attachment> list = new List<Attachment>();
        foreach (var item in AttachamentFiles)
        {
            list.Add(new Attachment(item));
        }

        SendMailA(StringMessage, IsBodyHtml, To, Subject, Cc, Bcc, list);
    }

    public void SendMailA(string StringMessage, bool IsBodyHtml, string To, string Subject, string[] Cc = null, string[] Bcc = null, List<Attachment> AttachamentFiles = null)
    {
      mail.From = new MailAddress(this.SMTPUser);
      try
      {
        mail.To.Add(To);
        mail.Subject = Subject;
        mail.IsBodyHtml = IsBodyHtml;
        mail.Body = StringMessage;
        if (!string.IsNullOrEmpty(this.ReplayTo))
        { mail.ReplyTo = new MailAddress(this.ReplayTo); }

        if (AttachamentFiles != null)
        {
            foreach (Attachment anexo in AttachamentFiles)
            { mail.Attachments.Add(anexo); }
        }

        if (Cc != null)
        {
          foreach (string ComCopia in Cc)
          { mail.CC.Add(ComCopia); }
        }

        if (Bcc != null)
        {
          foreach (string ComCopiaOculta in Bcc)
          { mail.Bcc.Add(ComCopiaOculta); }
        }

        SendMailMessage(mail);
      }
      finally
      {
        mail.Dispose();
        mail = null;
      }
    }
    #endregion
    
    #region public void SendMailMessage(MailMessage aMail)
    /// <summary>
    /// Se for gmail deve habilitar aplicativos menos seguros:
    /// https://www.google.com/settings/u/2/security/lesssecureapps
    /// </summary>
    /// <param name="Mail"></param>
    public void SendMailMessage(MailMessage Mail)
    {
      SmtpClient smtp = new SmtpClient();
      try
      {
        
        if (this.Port == 0)
        { smtp = new SmtpClient(this.SMTPClient); }
        else { smtp = new SmtpClient(this.SMTPClient, Port); }

        smtp.UseDefaultCredentials = false;
        smtp.EnableSsl = this.EnableSSL;
        
        if (this.RequireAutentication)
        { smtp.Credentials = new NetworkCredential(this.SMTPUser, this.SMTPPassword); }

        smtp.Send(Mail);
      }        
      catch (Exception ex)
      { throw new Exception("Erro ao enviar um email", ex); }
      finally 
      {
        smtp = null;
      }
    }
    #endregion
    #endregion
  }
}