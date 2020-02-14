namespace RckEventos
{
  partial class Menu
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
      this.button1 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDirFotos = new System.Windows.Forms.TextBox();
      this.button4 = new System.Windows.Forms.Button();
      this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.label2 = new System.Windows.Forms.Label();
      this.lstLog = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCaptionFotos = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.cmbResolucao = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(318, 90);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(124, 67);
      this.button1.TabIndex = 0;
      this.button1.Text = "Mural";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(448, 91);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(124, 67);
      this.button3.TabIndex = 2;
      this.button3.Text = "Mensagens";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Diretório das Fotos";
      // 
      // txtDirFotos
      // 
      this.txtDirFotos.Location = new System.Drawing.Point(12, 64);
      this.txtDirFotos.Name = "txtDirFotos";
      this.txtDirFotos.Size = new System.Drawing.Size(515, 20);
      this.txtDirFotos.TabIndex = 5;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(533, 62);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(39, 23);
      this.button4.TabIndex = 6;
      this.button4.Text = "...";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 160);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(128, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Processo em background";
      // 
      // lstLog
      // 
      this.lstLog.BackColor = System.Drawing.Color.Black;
      this.lstLog.ForeColor = System.Drawing.Color.Green;
      this.lstLog.FormattingEnabled = true;
      this.lstLog.Location = new System.Drawing.Point(12, 176);
      this.lstLog.Name = "lstLog";
      this.lstLog.Size = new System.Drawing.Size(560, 147);
      this.lstLog.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(79, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Titulo nas fotos";
      // 
      // txtCaptionFotos
      // 
      this.txtCaptionFotos.Location = new System.Drawing.Point(12, 25);
      this.txtCaptionFotos.Name = "txtCaptionFotos";
      this.txtCaptionFotos.Size = new System.Drawing.Size(430, 20);
      this.txtCaptionFotos.TabIndex = 10;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 90);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(124, 67);
      this.button2.TabIndex = 11;
      this.button2.Text = "Salvar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // cmbResolucao
      // 
      this.cmbResolucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbResolucao.FormattingEnabled = true;
      this.cmbResolucao.Items.AddRange(new object[] {
            "1080",
            "720",
            "540",
            "480",
            "360",
            "240"});
      this.cmbResolucao.Location = new System.Drawing.Point(448, 24);
      this.cmbResolucao.Name = "cmbResolucao";
      this.cmbResolucao.Size = new System.Drawing.Size(124, 21);
      this.cmbResolucao.TabIndex = 12;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(448, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Resolução";
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(188, 113);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(75, 23);
      this.sknButton1.TabIndex = 14;
      this.sknButton1.Text = "sknButton1";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 336);
      this.Controls.Add(this.sknButton1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cmbResolucao);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.txtCaptionFotos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lstLog);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.txtDirFotos);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button1);
      this.Name = "Menu";
      this.Text = "Mural";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
      this.Load += new System.EventHandler(this.Menu_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDirFotos;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.FolderBrowserDialog dlgFolder;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lstLog;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCaptionFotos;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ComboBox cmbResolucao;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknButton sknButton1;
  }
}

