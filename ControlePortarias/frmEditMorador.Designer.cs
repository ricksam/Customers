namespace ControlePortarias
{
  partial class frmEditMorador
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
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.mnFoto = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.acessarAWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label3 = new System.Windows.Forms.Label();
      this.txtObs = new lib.Visual.Components.sknTextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtEPC = new lib.Visual.Components.sknTextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtPlaca = new lib.Visual.Components.sknTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtVeiculo = new lib.Visual.Components.sknTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEmail = new lib.Visual.Components.sknTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNome = new lib.Visual.Components.sknTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cbProprietário = new lib.Visual.Components.sknCheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cmbTitulo = new lib.Visual.Components.sknComboBox();
      this.txtCelular = new lib.Visual.Components.sknMaskedTextBox();
      this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      this.mnFoto.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtCelular);
      this.pnlContext.Controls.Add(this.cmbTitulo);
      this.pnlContext.Controls.Add(this.label5);
      this.pnlContext.Controls.Add(this.cbProprietário);
      this.pnlContext.Controls.Add(this.imgFoto);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtObs);
      this.pnlContext.Controls.Add(this.label10);
      this.pnlContext.Controls.Add(this.txtEPC);
      this.pnlContext.Controls.Add(this.label8);
      this.pnlContext.Controls.Add(this.txtPlaca);
      this.pnlContext.Controls.Add(this.label7);
      this.pnlContext.Controls.Add(this.txtVeiculo);
      this.pnlContext.Controls.Add(this.label6);
      this.pnlContext.Controls.Add(this.label4);
      this.pnlContext.Controls.Add(this.txtEmail);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.txtNome);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(487, 371);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 371);
      this.pnlBottom.Size = new System.Drawing.Size(487, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(1254, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(1350, 8);
      // 
      // imgFoto
      // 
      this.imgFoto.ContextMenuStrip = this.mnFoto;
      this.imgFoto.Location = new System.Drawing.Point(15, 25);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(138, 178);
      this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgFoto.TabIndex = 37;
      this.imgFoto.TabStop = false;
      // 
      // mnFoto
      // 
      this.mnFoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarImagemToolStripMenuItem,
            this.acessarAWebCamToolStripMenuItem});
      this.mnFoto.Name = "mnFoto";
      this.mnFoto.Size = new System.Drawing.Size(176, 48);
      // 
      // adicionarImagemToolStripMenuItem
      // 
      this.adicionarImagemToolStripMenuItem.Name = "adicionarImagemToolStripMenuItem";
      this.adicionarImagemToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.adicionarImagemToolStripMenuItem.Text = "Adicionar Imagem";
      this.adicionarImagemToolStripMenuItem.Click += new System.EventHandler(this.adicionarImagemToolStripMenuItem_Click);
      // 
      // acessarAWebCamToolStripMenuItem
      // 
      this.acessarAWebCamToolStripMenuItem.Name = "acessarAWebCamToolStripMenuItem";
      this.acessarAWebCamToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
      this.acessarAWebCamToolStripMenuItem.Text = "Acessar a WebCam";
      this.acessarAWebCamToolStripMenuItem.Click += new System.EventHandler(this.acessarAWebCamToolStripMenuItem_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Foto";
      // 
      // txtObs
      // 
      this.txtObs.AsDateTime = new System.DateTime(((long)(0)));
      this.txtObs.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtObs.AutoTab = true;
      this.txtObs.Location = new System.Drawing.Point(15, 261);
      this.txtObs.Multiline = true;
      this.txtObs.Name = "txtObs";
      this.txtObs.Size = new System.Drawing.Size(450, 62);
      this.txtObs.TabIndex = 16;
      this.txtObs.TextFormat = null;
      this.txtObs.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(15, 245);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(29, 13);
      this.label10.TabIndex = 15;
      this.label10.Text = "Obs.";
      // 
      // txtEPC
      // 
      this.txtEPC.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEPC.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEPC.AutoTab = true;
      this.txtEPC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEPC.Location = new System.Drawing.Point(159, 183);
      this.txtEPC.Name = "txtEPC";
      this.txtEPC.Size = new System.Drawing.Size(222, 20);
      this.txtEPC.TabIndex = 10;
      this.txtEPC.TextFormat = null;
      this.txtEPC.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(159, 167);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(96, 13);
      this.label8.TabIndex = 9;
      this.label8.Text = "EPC ( Cod Cartão )";
      // 
      // txtPlaca
      // 
      this.txtPlaca.AsDateTime = new System.DateTime(((long)(0)));
      this.txtPlaca.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtPlaca.AutoTab = true;
      this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPlaca.Location = new System.Drawing.Point(240, 222);
      this.txtPlaca.Name = "txtPlaca";
      this.txtPlaca.Size = new System.Drawing.Size(225, 20);
      this.txtPlaca.TabIndex = 14;
      this.txtPlaca.TextFormat = null;
      this.txtPlaca.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(240, 206);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(34, 13);
      this.label7.TabIndex = 13;
      this.label7.Text = "Placa";
      // 
      // txtVeiculo
      // 
      this.txtVeiculo.AsDateTime = new System.DateTime(((long)(0)));
      this.txtVeiculo.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtVeiculo.AutoTab = true;
      this.txtVeiculo.Location = new System.Drawing.Point(15, 222);
      this.txtVeiculo.Name = "txtVeiculo";
      this.txtVeiculo.Size = new System.Drawing.Size(219, 20);
      this.txtVeiculo.TabIndex = 12;
      this.txtVeiculo.TextFormat = null;
      this.txtVeiculo.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 206);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(123, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Veículo (Marca/Modelo)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(159, 127);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Celular";
      // 
      // txtEmail
      // 
      this.txtEmail.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEmail.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEmail.AutoTab = true;
      this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
      this.txtEmail.Location = new System.Drawing.Point(159, 104);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(222, 20);
      this.txtEmail.TabIndex = 6;
      this.txtEmail.TextFormat = null;
      this.txtEmail.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(159, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Email";
      // 
      // txtNome
      // 
      this.txtNome.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNome.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNome.AutoTab = true;
      this.txtNome.Location = new System.Drawing.Point(159, 65);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(306, 20);
      this.txtNome.TabIndex = 4;
      this.txtNome.TextFormat = null;
      this.txtNome.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(159, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Nome";
      // 
      // cbProprietário
      // 
      this.cbProprietário.Location = new System.Drawing.Point(12, 329);
      this.cbProprietário.Name = "cbProprietário";
      this.cbProprietário.Size = new System.Drawing.Size(104, 24);
      this.cbProprietário.TabIndex = 17;
      this.cbProprietário.Text = "Proprietário";
      this.cbProprietário.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(159, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "Titulo";
      // 
      // cmbTitulo
      // 
      this.cmbTitulo.AutoTab = true;
      this.cmbTitulo.FormattingEnabled = true;
      this.cmbTitulo.Location = new System.Drawing.Point(159, 25);
      this.cmbTitulo.Name = "cmbTitulo";
      this.cmbTitulo.Size = new System.Drawing.Size(306, 21);
      this.cmbTitulo.TabIndex = 2;
      // 
      // txtCelular
      // 
      this.txtCelular.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCelular.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCelular.AutoTab = true;
      this.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCelular.Location = new System.Drawing.Point(159, 143);
      this.txtCelular.Mask = "(99)999999999";
      this.txtCelular.Name = "txtCelular";
      this.txtCelular.Size = new System.Drawing.Size(222, 20);
      this.txtCelular.TabIndex = 8;
      this.txtCelular.TextFormat = null;
      this.txtCelular.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // dlgOpen
      // 
      this.dlgOpen.FileName = "openFileDialog1";
      // 
      // frmEditMorador
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(487, 416);
      this.Name = "frmEditMorador";
      this.Text = "Morador";
      this.Controls.SetChildIndex(this.pnlBottom, 0);
      this.Controls.SetChildIndex(this.pnlContext, 0);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      this.mnFoto.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknTextBox txtObs;
    private System.Windows.Forms.Label label10;
    private lib.Visual.Components.sknTextBox txtEPC;
    private System.Windows.Forms.Label label8;
    private lib.Visual.Components.sknTextBox txtPlaca;
    private System.Windows.Forms.Label label7;
    private lib.Visual.Components.sknTextBox txtVeiculo;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknTextBox txtEmail;
    private System.Windows.Forms.Label label2;
    private lib.Visual.Components.sknTextBox txtNome;
    private System.Windows.Forms.Label label1;
    private lib.Visual.Components.sknComboBox cmbTitulo;
    private System.Windows.Forms.Label label5;
    private lib.Visual.Components.sknCheckBox cbProprietário;
    private lib.Visual.Components.sknMaskedTextBox txtCelular;
    private System.Windows.Forms.ContextMenuStrip mnFoto;
    private System.Windows.Forms.ToolStripMenuItem adicionarImagemToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem acessarAWebCamToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
  }
}