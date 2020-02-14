namespace RckRemoteClient
{
  partial class frmClient
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
      this.txtSender = new System.Windows.Forms.TextBox();
      this.txtId = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnControlar = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnNaoControlar = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Sua Id";
      // 
      // txtSender
      // 
      this.txtSender.Location = new System.Drawing.Point(51, 3);
      this.txtSender.Name = "txtSender";
      this.txtSender.Size = new System.Drawing.Size(100, 20);
      this.txtSender.TabIndex = 1;
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(179, 3);
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(100, 20);
      this.txtId.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(157, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(16, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Id";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnControlar
      // 
      this.btnControlar.Location = new System.Drawing.Point(285, 3);
      this.btnControlar.Name = "btnControlar";
      this.btnControlar.Size = new System.Drawing.Size(75, 23);
      this.btnControlar.TabIndex = 8;
      this.btnControlar.Text = "Controlar";
      this.btnControlar.UseVisualStyleBackColor = true;
      this.btnControlar.Click += new System.EventHandler(this.button2_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnNaoControlar);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.txtSender);
      this.panel1.Controls.Add(this.btnControlar);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtId);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(582, 32);
      this.panel1.TabIndex = 9;
      // 
      // btnNaoControlar
      // 
      this.btnNaoControlar.Enabled = false;
      this.btnNaoControlar.Location = new System.Drawing.Point(366, 3);
      this.btnNaoControlar.Name = "btnNaoControlar";
      this.btnNaoControlar.Size = new System.Drawing.Size(93, 23);
      this.btnNaoControlar.TabIndex = 10;
      this.btnNaoControlar.Text = "Não Controlar";
      this.btnNaoControlar.UseVisualStyleBackColor = true;
      this.btnNaoControlar.Click += new System.EventHandler(this.btnNaoControlar_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(495, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 9;
      this.button1.Text = "Call Desktop";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 32);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(582, 274);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 10;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // frmClient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 306);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.Name = "frmClient";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmClient_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSender;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnControlar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnNaoControlar;
  }
}

