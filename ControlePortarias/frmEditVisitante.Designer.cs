namespace ControlePortarias
{
  partial class frmEditVisitante
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
      this.txtTelefone = new lib.Visual.Components.sknMaskedTextBox();
      this.cmbTitulo = new lib.Visual.Components.sknComboBox();
      this.label5 = new System.Windows.Forms.Label();
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
      this.label11 = new System.Windows.Forms.Label();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
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
      this.pnlContext.Controls.Add(this.txtPlaca);
      this.pnlContext.Controls.Add(this.label7);
      this.pnlContext.Controls.Add(this.txtVeiculo);
      this.pnlContext.Controls.Add(this.label6);
      this.pnlContext.Controls.Add(this.label4);
      this.pnlContext.Controls.Add(this.txtEmail);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.txtNome);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(481, 293);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 293);
      this.pnlBottom.Size = new System.Drawing.Size(481, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(1596, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(1692, 8);
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
      this.txtTelefone.Location = new System.Drawing.Point(15, 182);
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
      this.cmbTitulo.Location = new System.Drawing.Point(15, 25);
      this.cmbTitulo.Name = "cmbTitulo";
      this.cmbTitulo.Size = new System.Drawing.Size(306, 21);
      this.cmbTitulo.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(15, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "Titulo";
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
      this.label4.Location = new System.Drawing.Point(15, 166);
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
      this.txtEmail.Location = new System.Drawing.Point(15, 143);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(222, 20);
      this.txtEmail.TabIndex = 8;
      this.txtEmail.TextFormat = null;
      this.txtEmail.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 127);
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
      this.txtNome.Location = new System.Drawing.Point(15, 65);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(306, 20);
      this.txtNome.TabIndex = 4;
      this.txtNome.TextFormat = null;
      this.txtNome.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 49);
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
      this.txtAutDe.Location = new System.Drawing.Point(15, 261);
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
      this.label8.Location = new System.Drawing.Point(15, 245);
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
      this.txtAutAte.Location = new System.Drawing.Point(141, 259);
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
      this.label9.Location = new System.Drawing.Point(138, 245);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(25, 13);
      this.label9.TabIndex = 20;
      this.label9.Text = "até:";
      // 
      // cbPreAutorizado
      // 
      this.cbPreAutorizado.Location = new System.Drawing.Point(267, 257);
      this.cbPreAutorizado.Name = "cbPreAutorizado";
      this.cbPreAutorizado.Size = new System.Drawing.Size(104, 24);
      this.cbPreAutorizado.TabIndex = 21;
      this.cbPreAutorizado.Text = "Pré Autorizado";
      this.cbPreAutorizado.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(15, 88);
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
      this.txtDocumento.Location = new System.Drawing.Point(15, 104);
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
      this.ClientSize = new System.Drawing.Size(481, 338);
      this.Name = "frmEditVisitante";
      this.Text = "Visitante";
      this.Load += new System.EventHandler(this.frmEditVisitante_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknMaskedTextBox txtTelefone;
    private lib.Visual.Components.sknComboBox cmbTitulo;
    private System.Windows.Forms.Label label5;
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
    private lib.Visual.Components.sknTextBox txtDocumento;
    private System.Windows.Forms.Label label11;
  }
}