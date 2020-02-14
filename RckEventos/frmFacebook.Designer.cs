namespace RckEventos
{
  partial class frmFacebook
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.wbSite = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // wbSite
      // 
      this.wbSite.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wbSite.Location = new System.Drawing.Point(0, 0);
      this.wbSite.MinimumSize = new System.Drawing.Size(20, 20);
      this.wbSite.Name = "wbSite";
      this.wbSite.Size = new System.Drawing.Size(784, 562);
      this.wbSite.TabIndex = 1;
      this.wbSite.Url = new System.Uri("", System.UriKind.Relative);
      this.wbSite.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbSite_Navigated);
      // 
      // frmFacebook
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 562);
      this.Controls.Add(this.wbSite);
      this.Name = "frmFacebook";
      this.Text = "Facebook";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmCadastro_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser wbSite;

  }
}