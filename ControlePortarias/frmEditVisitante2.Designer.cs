namespace ControlePortarias
{
  partial class frmEditVisitante2
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
      this.txtTelefone = new lib.Visual.Components.sknMaskedTextBox();
      this.cmbTitulo = new lib.Visual.Components.sknComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.mnFoto = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.acessarAWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label3 = new System.Windows.Forms.Label();
      this.txtObs = new lib.Visual.Components.sknTextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.txtPlaca = new lib.Visual.Components.sknTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtVeiculo = new lib.Visual.Components.sknTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtEmail = new lib.Visual.Components.sknTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNome = new lib.Visual.Components.sknTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtAutDe = new lib.Visual.Components.sknMaskedTextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtAutAte = new lib.Visual.Components.sknMaskedTextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.cbPreAutorizado = new lib.Visual.Components.sknCheckBox();
      this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
      this.label11 = new System.Windows.Forms.Label();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      this.mnFoto.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtDocumento);
      this.pnlContext.Controls.Add(this.label11);
      this.pnlContext.Controls.Add(this.cbPreAutorizado);
      this.pnlContext.Controls.Add(this.txtAutAte);
      this.pnlContext.Controls.Add(this.label9);
      this.pnlContext.Controls.Add(this.txtAutDe);
      this.pnlContext.Controls.Add(this.label8);
      this.pnlContext.Controls.Add(this.txtTelefone);
      this.pnlContext.Controls.Add(this.cmbTitulo);
      this.pnlContext.Controls.Add(this.label5);
      this.pnlContext.Controls.Add(this.imgFoto);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtObs);
      this.pnlContext.Controls.Add(this.label10);
      this.pnlContext.Controls.Add(this.txtPlaca);
      this.pnlContext.Controls.Add(this.label7);
      this.pnlContext.Controls.Add(this.txtVeiculo);
      this.pnlContext.Controls.Add(this.label6);
      this.pnlContext.Controls.Add(this.label4);
      this.pnlContext.Controls.Add(this.txtEmail);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.txtNome);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(481, 372);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 372);
      this.pnlBottom.Size = new System.Drawing.Size(481, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(1407, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(1503, 8);
      // 
      // txtTelefone
      // 
      this.txtTelefone.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTelefone.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTelefone.AutoTab = true;
      this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtTelefone.Location = new System.Drawing.Point(159, 182);
      this.txtTelefone.Mask = "(99)999999999";
      this.txtTelefone.Name = "txtTelefone";
      this.txtTelefone.Size = new System.Drawing.Size(222, 20);
      this.txtTelefone.TabIndex = 10;
      this.txtTelefone.TextFormat = null;
      this.txtTelefone.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // cmbTitulo
      // 
      this.cmbTitulo.AutoTab = true;
      this.cmbTitulo.FormattingEnabled = true;
      this.cmbTitulo.Location = new System.Drawing.Point(159, 25);
      this.cmbTitulo.Name = "cmbTitulo";
      this.cmbTitulo.Size = new System.Drawing.Size(306, 21);
      this.cmbTitulo.TabIndex = 2;
      this.cmbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTitulo_KeyPress);
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
      // imgFoto
      // 
      this.imgFoto.ContextMenuStrip = this.mnFoto;
      this.imgFoto.Location = new System.Drawing.Point(15, 25);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(138, 178);
      this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgFoto.TabIndex = 56;
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
      this.txtPlaca.Location = new System.Drawing.Point(237, 222);
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
      this.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
      this.label4.Location = new System.Drawing.Point(159, 166);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Telefone";
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
      this.txtEmail.Location = new System.Drawing.Point(159, 143);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(222, 20);
      this.txtEmail.TabIndex = 8;
      this.txtEmail.TextFormat = null;
      this.txtEmail.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(159, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 7;
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
      this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
      // txtAutDe
      // 
      this.txtAutDe.AsDateTime = new System.DateTime(((long)(0)));
      this.txtAutDe.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAutDe.AutoTab = true;
      this.txtAutDe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtAutDe.Location = new System.Drawing.Point(15, 342);
      this.txtAutDe.Mask = "99/99/9999 99:99";
      this.txtAutDe.Name = "txtAutDe";
      this.txtAutDe.Size = new System.Drawing.Size(120, 20);
      this.txtAutDe.TabIndex = 18;
      this.txtAutDe.TextFormat = null;
      this.txtAutDe.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(15, 326);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(75, 13);
      this.label8.TabIndex = 17;
      this.label8.Text = "Autorizado de:";
      // 
      // txtAutAte
      // 
      this.txtAutAte.AsDateTime = new System.DateTime(((long)(0)));
      this.txtAutAte.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAutAte.AutoTab = true;
      this.txtAutAte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtAutAte.Location = new System.Drawing.Point(141, 340);
      this.txtAutAte.Mask = "99/99/9999 99:99";
      this.txtAutAte.Name = "txtAutAte";
      this.txtAutAte.Size = new System.Drawing.Size(120, 20);
      this.txtAutAte.TabIndex = 19;
      this.txtAutAte.TextFormat = null;
      this.txtAutAte.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(138, 326);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(25, 13);
      this.label9.TabIndex = 20;
      this.label9.Text = "até:";
      // 
      // cbPreAutorizado
      // 
      this.cbPreAutorizado.Location = new System.Drawing.Point(267, 338);
      this.cbPreAutorizado.Name = "cbPreAutorizado";
      this.cbPreAutorizado.Size = new System.Drawing.Size(104, 24);
      this.cbPreAutorizado.TabIndex = 21;
      this.cbPreAutorizado.Text = "Pré Autorizado";
      this.cbPreAutorizado.UseVisualStyleBackColor = true;
      // 
      // dlgOpen
      // 
      this.dlgOpen.FileName = "openFileDialog1";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(159, 88);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(62, 13);
      this.label11.TabIndex = 5;
      this.label11.Text = "Documento";
      // 
      // txtDocumento
      // 
      this.txtDocumento.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDocumento.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDocumento.AutoTab = true;
      this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDocumento.Location = new System.Drawing.Point(159, 104);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(222, 20);
      this.txtDocumento.TabIndex = 6;
      this.txtDocumento.TextFormat = null;
      this.txtDocumento.TextType = lib.Visual.Components.enmTextType.String;
      this.txtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyDown);
      this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
      // 
      // frmEditVisitante
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 417);
      this.Name = "frmEditVisitante";
      this.Text = "frmEditVisitante";
      this.Load += new System.EventHandler(this.frmEditVisitante_Load);
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

    private lib.Visual.Components.sknMaskedTextBox txtTelefone;
    private lib.Visual.Components.sknComboBox cmbTitulo;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknTextBox txtObs;
    private System.Windows.Forms.Label label10;
    private lib.Visual.Components.sknTextBox txtPlaca;
    private System.Windows.Forms.Label label7;
    private lib.Visual.Components.sknTextBox txtVeiculo;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknTextBox txtEmail;
    private System.Windows.Forms.Label label2;
    private lib.Visual.Components.sknTextBox txtNome;
    private System.Windows.Forms.Label label1;
    private lib.Visual.Components.sknCheckBox cbPreAutorizado;
    private lib.Visual.Components.sknMaskedTextBox txtAutAte;
    private System.Windows.Forms.Label label9;
    private lib.Visual.Components.sknMaskedTextBox txtAutDe;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ContextMenuStrip mnFoto;
    private System.Windows.Forms.ToolStripMenuItem adicionarImagemToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem acessarAWebCamToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
    private lib.Visual.Components.sknTextBox txtDocumento;
    private System.Windows.Forms.Label label11;
  }
}