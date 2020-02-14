namespace Financeiro_Marcelo
{
  partial class Configuracoes
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
      this.cbRemoveOnLine = new lib.Visual.Components.sknCheckBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.sknGroupBox1 = new lib.Visual.Components.sknGroupBox();
      this.txtPorta = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.cbRequerAutenticacao = new lib.Visual.Components.sknCheckBox();
      this.cbHabilitaSSL = new lib.Visual.Components.sknCheckBox();
      this.txtSenha = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtUsuario = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtServidor = new lib.Visual.Components.sknTextBox();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.txtNrRegForm = new lib.Visual.Components.sknTextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPastaCopiaBkp = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.dlgBkp = new System.Windows.Forms.FolderBrowserDialog();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.sknGroupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.groupBox2);
      this.pnlContext.Controls.Add(this.txtNrRegForm);
      this.pnlContext.Controls.Add(this.sknLabel5);
      this.pnlContext.Controls.Add(this.sknButton1);
      this.pnlContext.Controls.Add(this.sknGroupBox1);
      this.pnlContext.Controls.Add(this.cbRemoveOnLine);
      this.pnlContext.Size = new System.Drawing.Size(332, 417);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 417);
      this.pnlBottom.Size = new System.Drawing.Size(332, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(124, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(220, 8);
      // 
      // cbRemoveOnLine
      // 
      this.cbRemoveOnLine.Location = new System.Drawing.Point(12, 228);
      this.cbRemoveOnLine.Name = "cbRemoveOnLine";
      this.cbRemoveOnLine.Size = new System.Drawing.Size(297, 39);
      this.cbRemoveOnLine.TabIndex = 1;
      this.cbRemoveOnLine.Text = "Esta máquina permite remover registros de vendas On-Line";
      this.cbRemoveOnLine.UseVisualStyleBackColor = true;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(6, 16);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(46, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Servidor";
      // 
      // sknGroupBox1
      // 
      this.sknGroupBox1.Controls.Add(this.txtPorta);
      this.sknGroupBox1.Controls.Add(this.sknLabel4);
      this.sknGroupBox1.Controls.Add(this.cbRequerAutenticacao);
      this.sknGroupBox1.Controls.Add(this.cbHabilitaSSL);
      this.sknGroupBox1.Controls.Add(this.txtSenha);
      this.sknGroupBox1.Controls.Add(this.sknLabel3);
      this.sknGroupBox1.Controls.Add(this.txtUsuario);
      this.sknGroupBox1.Controls.Add(this.sknLabel2);
      this.sknGroupBox1.Controls.Add(this.txtServidor);
      this.sknGroupBox1.Controls.Add(this.sknLabel1);
      this.sknGroupBox1.Location = new System.Drawing.Point(12, 12);
      this.sknGroupBox1.Name = "sknGroupBox1";
      this.sknGroupBox1.Size = new System.Drawing.Size(308, 210);
      this.sknGroupBox1.TabIndex = 0;
      this.sknGroupBox1.TabStop = false;
      this.sknGroupBox1.Text = "Configurações do Email";
      // 
      // txtPorta
      // 
      this.txtPorta.AsDateTime = new System.DateTime(((long)(0)));
      this.txtPorta.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtPorta.AutoTab = true;
      this.txtPorta.Location = new System.Drawing.Point(6, 179);
      this.txtPorta.Name = "txtPorta";
      this.txtPorta.Size = new System.Drawing.Size(100, 20);
      this.txtPorta.TabIndex = 9;
      this.txtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtPorta.TextFormat = null;
      this.txtPorta.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(6, 163);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(32, 13);
      this.sknLabel4.TabIndex = 8;
      this.sknLabel4.Text = "Porta";
      // 
      // cbRequerAutenticacao
      // 
      this.cbRequerAutenticacao.Location = new System.Drawing.Point(116, 136);
      this.cbRequerAutenticacao.Name = "cbRequerAutenticacao";
      this.cbRequerAutenticacao.Size = new System.Drawing.Size(186, 24);
      this.cbRequerAutenticacao.TabIndex = 7;
      this.cbRequerAutenticacao.Text = "Requer Autenticação";
      this.cbRequerAutenticacao.UseVisualStyleBackColor = true;
      // 
      // cbHabilitaSSL
      // 
      this.cbHabilitaSSL.Location = new System.Drawing.Point(6, 136);
      this.cbHabilitaSSL.Name = "cbHabilitaSSL";
      this.cbHabilitaSSL.Size = new System.Drawing.Size(104, 24);
      this.cbHabilitaSSL.TabIndex = 6;
      this.cbHabilitaSSL.Text = "Habilita SSL";
      this.cbHabilitaSSL.UseVisualStyleBackColor = true;
      // 
      // txtSenha
      // 
      this.txtSenha.AsDateTime = new System.DateTime(((long)(0)));
      this.txtSenha.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtSenha.AutoTab = true;
      this.txtSenha.Location = new System.Drawing.Point(6, 110);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(296, 20);
      this.txtSenha.TabIndex = 5;
      this.txtSenha.TextFormat = null;
      this.txtSenha.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(6, 94);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(38, 13);
      this.sknLabel3.TabIndex = 4;
      this.sknLabel3.Text = "Senha";
      // 
      // txtUsuario
      // 
      this.txtUsuario.AsDateTime = new System.DateTime(((long)(0)));
      this.txtUsuario.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtUsuario.AutoTab = true;
      this.txtUsuario.Location = new System.Drawing.Point(6, 71);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(296, 20);
      this.txtUsuario.TabIndex = 3;
      this.txtUsuario.TextFormat = null;
      this.txtUsuario.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(6, 55);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(32, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Email";
      // 
      // txtServidor
      // 
      this.txtServidor.AsDateTime = new System.DateTime(((long)(0)));
      this.txtServidor.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtServidor.AutoTab = true;
      this.txtServidor.Location = new System.Drawing.Point(6, 32);
      this.txtServidor.Name = "txtServidor";
      this.txtServidor.Size = new System.Drawing.Size(296, 20);
      this.txtServidor.TabIndex = 1;
      this.txtServidor.TextFormat = null;
      this.txtServidor.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(12, 312);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(134, 23);
      this.sknButton1.TabIndex = 4;
      this.sknButton1.Text = "Lista de Emails";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(12, 270);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(182, 13);
      this.sknLabel5.TabIndex = 2;
      this.sknLabel5.Text = "Nr. de registros na lista de formulários";
      // 
      // txtNrRegForm
      // 
      this.txtNrRegForm.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNrRegForm.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNrRegForm.AutoTab = true;
      this.txtNrRegForm.Location = new System.Drawing.Point(12, 286);
      this.txtNrRegForm.Name = "txtNrRegForm";
      this.txtNrRegForm.Size = new System.Drawing.Size(100, 20);
      this.txtNrRegForm.TabIndex = 3;
      this.txtNrRegForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtNrRegForm.TextFormat = null;
      this.txtNrRegForm.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button1);
      this.groupBox2.Controls.Add(this.txtPastaCopiaBkp);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Location = new System.Drawing.Point(12, 341);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(308, 65);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Backup";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(188, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Copia arquivo de backup para a pasta";
      // 
      // txtPastaCopiaBkp
      // 
      this.txtPastaCopiaBkp.Location = new System.Drawing.Point(6, 32);
      this.txtPastaCopiaBkp.Name = "txtPastaCopiaBkp";
      this.txtPastaCopiaBkp.Size = new System.Drawing.Size(260, 20);
      this.txtPastaCopiaBkp.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(272, 30);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(30, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Configuracoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(332, 462);
      this.Name = "Configuracoes";
      this.Text = "Configuracoes";
      this.Load += new System.EventHandler(this.Configuracoes_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.sknGroupBox1.ResumeLayout(false);
      this.sknGroupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknCheckBox cbRemoveOnLine;
    private lib.Visual.Components.sknGroupBox sknGroupBox1;
    private lib.Visual.Components.sknTextBox txtPorta;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknCheckBox cbRequerAutenticacao;
    private lib.Visual.Components.sknCheckBox cbHabilitaSSL;
    private lib.Visual.Components.sknTextBox txtSenha;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknTextBox txtUsuario;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtServidor;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknButton sknButton1;
    private lib.Visual.Components.sknTextBox txtNrRegForm;
    private lib.Visual.Components.sknLabel sknLabel5;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtPastaCopiaBkp;
    private System.Windows.Forms.FolderBrowserDialog dlgBkp;
  }
}