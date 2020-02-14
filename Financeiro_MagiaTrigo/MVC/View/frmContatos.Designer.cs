namespace MagiaTrigo
{
  partial class frmContato
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
      this.lblCON_NOME = new lib.Visual.Components.sknLabel();
      this.txtNome = new lib.Visual.Components.sknTextBox();
      this.lblCON_TEL_RESIDENCIAL = new lib.Visual.Components.sknLabel();
      this.lblCON_TEL_CELULAR = new lib.Visual.Components.sknLabel();
      this.lblCON_TEL_COMERCIAL = new lib.Visual.Components.sknLabel();
      this.lblCON_TEL_FAX = new lib.Visual.Components.sknLabel();
      this.lblCON_LOGRADOURO = new lib.Visual.Components.sknLabel();
      this.txtLogradouro = new lib.Visual.Components.sknTextBox();
      this.lblCON_NUMERO = new lib.Visual.Components.sknLabel();
      this.txtNumero = new lib.Visual.Components.sknTextBox();
      this.lblCON_BAIRRO = new lib.Visual.Components.sknLabel();
      this.txtBairro = new lib.Visual.Components.sknTextBox();
      this.lblCON_CIDADE = new lib.Visual.Components.sknLabel();
      this.txtCidade = new lib.Visual.Components.sknTextBox();
      this.lblCON_CEP = new lib.Visual.Components.sknLabel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtTelFax = new lib.Visual.Components.sknMaskedTextBox();
      this.txtTelComercial = new lib.Visual.Components.sknMaskedTextBox();
      this.txtTelCelular = new lib.Visual.Components.sknMaskedTextBox();
      this.txtTelResidencial = new lib.Visual.Components.sknMaskedTextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtCEP = new lib.Visual.Components.sknMaskedTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtEmail = new lib.Visual.Components.sknTextBox();
      this.pnlEdit.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Controls.Add(this.txtEmail);
      this.pnlEdit.Controls.Add(this.groupBox2);
      this.pnlEdit.Controls.Add(this.groupBox1);
      this.pnlEdit.Controls.Add(this.lblCON_NOME);
      this.pnlEdit.Controls.Add(this.txtNome);
      this.pnlEdit.Size = new System.Drawing.Size(475, 280);
      // 
      // lblCON_NOME
      // 
      this.lblCON_NOME.AutoSize = true;
      this.lblCON_NOME.Location = new System.Drawing.Point(12, 3);
      this.lblCON_NOME.Name = "lblCON_NOME";
      this.lblCON_NOME.Size = new System.Drawing.Size(35, 13);
      this.lblCON_NOME.TabIndex = 0;
      this.lblCON_NOME.Text = "Nome";
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
      this.txtNome.Location = new System.Drawing.Point(12, 19);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(427, 20);
      this.txtNome.TabIndex = 1;
      this.txtNome.TextFormat = null;
      this.txtNome.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCON_TEL_RESIDENCIAL
      // 
      this.lblCON_TEL_RESIDENCIAL.AutoSize = true;
      this.lblCON_TEL_RESIDENCIAL.Location = new System.Drawing.Point(6, 16);
      this.lblCON_TEL_RESIDENCIAL.Name = "lblCON_TEL_RESIDENCIAL";
      this.lblCON_TEL_RESIDENCIAL.Size = new System.Drawing.Size(62, 13);
      this.lblCON_TEL_RESIDENCIAL.TabIndex = 0;
      this.lblCON_TEL_RESIDENCIAL.Text = "Residencial";
      // 
      // lblCON_TEL_CELULAR
      // 
      this.lblCON_TEL_CELULAR.AutoSize = true;
      this.lblCON_TEL_CELULAR.Location = new System.Drawing.Point(112, 16);
      this.lblCON_TEL_CELULAR.Name = "lblCON_TEL_CELULAR";
      this.lblCON_TEL_CELULAR.Size = new System.Drawing.Size(39, 13);
      this.lblCON_TEL_CELULAR.TabIndex = 2;
      this.lblCON_TEL_CELULAR.Text = "Celular";
      // 
      // lblCON_TEL_COMERCIAL
      // 
      this.lblCON_TEL_COMERCIAL.AutoSize = true;
      this.lblCON_TEL_COMERCIAL.Location = new System.Drawing.Point(218, 16);
      this.lblCON_TEL_COMERCIAL.Name = "lblCON_TEL_COMERCIAL";
      this.lblCON_TEL_COMERCIAL.Size = new System.Drawing.Size(53, 13);
      this.lblCON_TEL_COMERCIAL.TabIndex = 4;
      this.lblCON_TEL_COMERCIAL.Text = "Comercial";
      // 
      // lblCON_TEL_FAX
      // 
      this.lblCON_TEL_FAX.AutoSize = true;
      this.lblCON_TEL_FAX.Location = new System.Drawing.Point(324, 16);
      this.lblCON_TEL_FAX.Name = "lblCON_TEL_FAX";
      this.lblCON_TEL_FAX.Size = new System.Drawing.Size(24, 13);
      this.lblCON_TEL_FAX.TabIndex = 6;
      this.lblCON_TEL_FAX.Text = "Fax";
      // 
      // lblCON_LOGRADOURO
      // 
      this.lblCON_LOGRADOURO.AutoSize = true;
      this.lblCON_LOGRADOURO.Location = new System.Drawing.Point(14, 23);
      this.lblCON_LOGRADOURO.Name = "lblCON_LOGRADOURO";
      this.lblCON_LOGRADOURO.Size = new System.Drawing.Size(61, 13);
      this.lblCON_LOGRADOURO.TabIndex = 0;
      this.lblCON_LOGRADOURO.Text = "Logradouro";
      // 
      // txtLogradouro
      // 
      this.txtLogradouro.AsDateTime = new System.DateTime(((long)(0)));
      this.txtLogradouro.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtLogradouro.AutoTab = true;
      this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtLogradouro.Location = new System.Drawing.Point(14, 39);
      this.txtLogradouro.Name = "txtLogradouro";
      this.txtLogradouro.Size = new System.Drawing.Size(304, 20);
      this.txtLogradouro.TabIndex = 1;
      this.txtLogradouro.TextFormat = null;
      this.txtLogradouro.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCON_NUMERO
      // 
      this.lblCON_NUMERO.AutoSize = true;
      this.lblCON_NUMERO.Location = new System.Drawing.Point(324, 23);
      this.lblCON_NUMERO.Name = "lblCON_NUMERO";
      this.lblCON_NUMERO.Size = new System.Drawing.Size(44, 13);
      this.lblCON_NUMERO.TabIndex = 2;
      this.lblCON_NUMERO.Text = "Numero";
      // 
      // txtNumero
      // 
      this.txtNumero.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNumero.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNumero.AutoTab = true;
      this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNumero.Location = new System.Drawing.Point(324, 39);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(100, 20);
      this.txtNumero.TabIndex = 3;
      this.txtNumero.TextFormat = null;
      this.txtNumero.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCON_BAIRRO
      // 
      this.lblCON_BAIRRO.AutoSize = true;
      this.lblCON_BAIRRO.Location = new System.Drawing.Point(14, 62);
      this.lblCON_BAIRRO.Name = "lblCON_BAIRRO";
      this.lblCON_BAIRRO.Size = new System.Drawing.Size(34, 13);
      this.lblCON_BAIRRO.TabIndex = 4;
      this.lblCON_BAIRRO.Text = "Bairro";
      // 
      // txtBairro
      // 
      this.txtBairro.AsDateTime = new System.DateTime(((long)(0)));
      this.txtBairro.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtBairro.AutoTab = true;
      this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtBairro.Location = new System.Drawing.Point(14, 78);
      this.txtBairro.Name = "txtBairro";
      this.txtBairro.Size = new System.Drawing.Size(137, 20);
      this.txtBairro.TabIndex = 5;
      this.txtBairro.TextFormat = null;
      this.txtBairro.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCON_CIDADE
      // 
      this.lblCON_CIDADE.AutoSize = true;
      this.lblCON_CIDADE.Location = new System.Drawing.Point(157, 62);
      this.lblCON_CIDADE.Name = "lblCON_CIDADE";
      this.lblCON_CIDADE.Size = new System.Drawing.Size(40, 13);
      this.lblCON_CIDADE.TabIndex = 6;
      this.lblCON_CIDADE.Text = "Cidade";
      // 
      // txtCidade
      // 
      this.txtCidade.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCidade.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCidade.AutoTab = true;
      this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCidade.Location = new System.Drawing.Point(157, 78);
      this.txtCidade.Name = "txtCidade";
      this.txtCidade.Size = new System.Drawing.Size(161, 20);
      this.txtCidade.TabIndex = 7;
      this.txtCidade.TextFormat = null;
      this.txtCidade.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCON_CEP
      // 
      this.lblCON_CEP.AutoSize = true;
      this.lblCON_CEP.Location = new System.Drawing.Point(324, 62);
      this.lblCON_CEP.Name = "lblCON_CEP";
      this.lblCON_CEP.Size = new System.Drawing.Size(28, 13);
      this.lblCON_CEP.TabIndex = 8;
      this.lblCON_CEP.Text = "CEP";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtTelFax);
      this.groupBox1.Controls.Add(this.txtTelComercial);
      this.groupBox1.Controls.Add(this.txtTelCelular);
      this.groupBox1.Controls.Add(this.txtTelResidencial);
      this.groupBox1.Controls.Add(this.lblCON_TEL_RESIDENCIAL);
      this.groupBox1.Controls.Add(this.lblCON_TEL_FAX);
      this.groupBox1.Controls.Add(this.lblCON_TEL_COMERCIAL);
      this.groupBox1.Controls.Add(this.lblCON_TEL_CELULAR);
      this.groupBox1.Location = new System.Drawing.Point(12, 84);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(447, 65);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = " Telefone ";
      // 
      // txtTelFax
      // 
      this.txtTelFax.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTelFax.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTelFax.AutoTab = true;
      this.txtTelFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtTelFax.Location = new System.Drawing.Point(324, 32);
      this.txtTelFax.Mask = "(99) 0000-0000";
      this.txtTelFax.Name = "txtTelFax";
      this.txtTelFax.Size = new System.Drawing.Size(100, 20);
      this.txtTelFax.TabIndex = 7;
      this.txtTelFax.TextFormat = null;
      this.txtTelFax.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtTelComercial
      // 
      this.txtTelComercial.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTelComercial.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTelComercial.AutoTab = true;
      this.txtTelComercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtTelComercial.Location = new System.Drawing.Point(218, 32);
      this.txtTelComercial.Mask = "(99) 0000-0000";
      this.txtTelComercial.Name = "txtTelComercial";
      this.txtTelComercial.Size = new System.Drawing.Size(100, 20);
      this.txtTelComercial.TabIndex = 5;
      this.txtTelComercial.TextFormat = null;
      this.txtTelComercial.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtTelCelular
      // 
      this.txtTelCelular.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTelCelular.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTelCelular.AutoTab = true;
      this.txtTelCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtTelCelular.Location = new System.Drawing.Point(112, 32);
      this.txtTelCelular.Mask = "(99) 0000-0000";
      this.txtTelCelular.Name = "txtTelCelular";
      this.txtTelCelular.Size = new System.Drawing.Size(100, 20);
      this.txtTelCelular.TabIndex = 3;
      this.txtTelCelular.TextFormat = null;
      this.txtTelCelular.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtTelResidencial
      // 
      this.txtTelResidencial.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTelResidencial.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTelResidencial.AutoTab = true;
      this.txtTelResidencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtTelResidencial.Location = new System.Drawing.Point(6, 32);
      this.txtTelResidencial.Mask = "(99) 0000-0000";
      this.txtTelResidencial.Name = "txtTelResidencial";
      this.txtTelResidencial.Size = new System.Drawing.Size(100, 20);
      this.txtTelResidencial.TabIndex = 1;
      this.txtTelResidencial.TextFormat = null;
      this.txtTelResidencial.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtCEP);
      this.groupBox2.Controls.Add(this.lblCON_LOGRADOURO);
      this.groupBox2.Controls.Add(this.txtLogradouro);
      this.groupBox2.Controls.Add(this.lblCON_NUMERO);
      this.groupBox2.Controls.Add(this.txtNumero);
      this.groupBox2.Controls.Add(this.lblCON_CEP);
      this.groupBox2.Controls.Add(this.lblCON_CIDADE);
      this.groupBox2.Controls.Add(this.txtCidade);
      this.groupBox2.Controls.Add(this.lblCON_BAIRRO);
      this.groupBox2.Controls.Add(this.txtBairro);
      this.groupBox2.Location = new System.Drawing.Point(12, 155);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(447, 111);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = " Endereço ";
      // 
      // txtCEP
      // 
      this.txtCEP.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCEP.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCEP.AutoTab = true;
      this.txtCEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCEP.Location = new System.Drawing.Point(324, 78);
      this.txtCEP.Mask = "00000-000";
      this.txtCEP.Name = "txtCEP";
      this.txtCEP.Size = new System.Drawing.Size(100, 20);
      this.txtCEP.TabIndex = 9;
      this.txtCEP.TextFormat = null;
      this.txtCEP.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 42);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(32, 13);
      this.sknLabel1.TabIndex = 2;
      this.sknLabel1.Text = "Email";
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
      this.txtEmail.Location = new System.Drawing.Point(12, 58);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(427, 20);
      this.txtEmail.TabIndex = 3;
      this.txtEmail.TextFormat = null;
      this.txtEmail.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // frmContato
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 360);
      this.Name = "frmContato";
      this.Text = "Contatos";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblCON_NOME;
    private lib.Visual.Components.sknTextBox txtNome;
    private lib.Visual.Components.sknLabel lblCON_TEL_RESIDENCIAL;
    private lib.Visual.Components.sknLabel lblCON_TEL_CELULAR;
    private lib.Visual.Components.sknLabel lblCON_TEL_COMERCIAL;
    private lib.Visual.Components.sknLabel lblCON_TEL_FAX;
    private lib.Visual.Components.sknLabel lblCON_LOGRADOURO;
    private lib.Visual.Components.sknTextBox txtLogradouro;
    private lib.Visual.Components.sknLabel lblCON_NUMERO;
    private lib.Visual.Components.sknTextBox txtNumero;
    private lib.Visual.Components.sknLabel lblCON_BAIRRO;
    private lib.Visual.Components.sknTextBox txtBairro;
    private lib.Visual.Components.sknLabel lblCON_CIDADE;
    private lib.Visual.Components.sknTextBox txtCidade;
    private lib.Visual.Components.sknLabel lblCON_CEP;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox1;
    private lib.Visual.Components.sknMaskedTextBox txtCEP;
    private lib.Visual.Components.sknMaskedTextBox txtTelFax;
    private lib.Visual.Components.sknMaskedTextBox txtTelComercial;
    private lib.Visual.Components.sknMaskedTextBox txtTelCelular;
    private lib.Visual.Components.sknMaskedTextBox txtTelResidencial;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtEmail;
  }
}
