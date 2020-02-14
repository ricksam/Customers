namespace RckRemoteServer
{
  partial class frmServer
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.txtIP = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.tmrTimer = new System.Windows.Forms.Timer(this.components);
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(17, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "IP";
      // 
      // txtIP
      // 
      this.txtIP.Location = new System.Drawing.Point(12, 25);
      this.txtIP.Name = "txtIP";
      this.txtIP.Size = new System.Drawing.Size(100, 20);
      this.txtIP.TabIndex = 1;
      this.txtIP.Text = "127.0.0.1";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(118, 23);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Conectar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // tmrTimer
      // 
      this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 51);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(611, 274);
      this.textBox1.TabIndex = 4;
      // 
      // frmServer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(635, 337);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtIP);
      this.Controls.Add(this.label1);
      this.Name = "frmServer";
      this.Text = "Server";
      this.Load += new System.EventHandler(this.frmServer_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Timer tmrTimer;
    private System.Windows.Forms.TextBox textBox1;
  }
}

