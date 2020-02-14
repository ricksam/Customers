namespace Folha_Marcelo
{
  partial class frmCLB_COLABORADOR
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
      this.lblCLB_EMP_CODIGO = new lib.Visual.Components.sknLabel();
      this.lblCLB_NOME = new lib.Visual.Components.sknLabel();
      this.txtCLB_NOME = new lib.Visual.Components.sknTextBox();
      this.lblCLB_FONE = new lib.Visual.Components.sknLabel();
      this.lblCLB_RECADO = new lib.Visual.Components.sknLabel();
      this.lblCLB_LOGRADOURO = new lib.Visual.Components.sknLabel();
      this.lblCLB_NUMERO = new lib.Visual.Components.sknLabel();
      this.txtCLB_NUMERO = new lib.Visual.Components.sknTextBox();
      this.lblCLB_BAIRRO = new lib.Visual.Components.sknLabel();
      this.lblCLB_CIDADE = new lib.Visual.Components.sknLabel();
      this.txtCLB_CIDADE = new lib.Visual.Components.sknTextBox();
      this.lblCLB_ESTADO = new lib.Visual.Components.sknLabel();
      this.lblCLB_CEP = new lib.Visual.Components.sknLabel();
      this.lblCLB_OBS = new lib.Visual.Components.sknLabel();
      this.txtCLB_OBS = new lib.Visual.Components.sknTextBox();
      this.lblCLB_FOTO = new lib.Visual.Components.sknLabel();
      this.lblCLB_SALARIO = new lib.Visual.Components.sknLabel();
      this.txtCLB_SALARIO = new lib.Visual.Components.sknTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtCLB_DTNASC = new lib.Visual.Components.sknTextBox();
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
      this.btnPesquisaCEP = new System.Windows.Forms.Button();
      this.cmbCLB_LOGRADOURO = new lib.Visual.Components.sknComboBox();
      this.cmbCLB_BAIRRO = new lib.Visual.Components.sknComboBox();
      this.cmbCLB_ESTADO = new lib.Visual.Components.sknComboBox();
      this.txtCLB_CEP = new lib.Visual.Components.sknMaskedTextBox();
      this.txtCLB_RECADO = new lib.Visual.Components.sknMaskedTextBox();
      this.txtCLB_FONE = new lib.Visual.Components.sknMaskedTextBox();
      this.cbCLB_INATIVO = new lib.Visual.Components.sknCheckBox();
      this.tbcCadastro = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.txtCLB_CPF = new lib.Visual.Components.sknMaskedTextBox();
      this.txtCLB_RG = new lib.Visual.Components.sknMaskedTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.tbHistorico = new System.Windows.Forms.TabPage();
      this.grdHistorico = new lib.Visual.Components.sknGrid();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnEditarHistorico = new System.Windows.Forms.Button();
      this.btnRemoverHistorico = new System.Windows.Forms.Button();
      this.btnAdicionarHistorico = new System.Windows.Forms.Button();
      this.tbAlertas = new System.Windows.Forms.TabPage();
      this.grdAlertas = new lib.Visual.Components.sknGrid();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnEditarAlerta = new System.Windows.Forms.Button();
      this.btnRemoverAlertas = new System.Windows.Forms.Button();
      this.btnAdicionarAlertas = new System.Windows.Forms.Button();
      this.pnlEdit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      this.tbcCadastro.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tbHistorico.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).BeginInit();
      this.panel2.SuspendLayout();
      this.tbAlertas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdAlertas)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.tbcCadastro);
      this.pnlEdit.Size = new System.Drawing.Size(518, 352);
      this.pnlEdit.TabIndex = 0;
      // 
      // lblCLB_EMP_CODIGO
      // 
      this.lblCLB_EMP_CODIGO.AutoSize = true;
      this.lblCLB_EMP_CODIGO.Location = new System.Drawing.Point(8, 263);
      this.lblCLB_EMP_CODIGO.Name = "lblCLB_EMP_CODIGO";
      this.lblCLB_EMP_CODIGO.Size = new System.Drawing.Size(27, 13);
      this.lblCLB_EMP_CODIGO.TabIndex = 26;
      this.lblCLB_EMP_CODIGO.Text = "Loja";
      // 
      // lblCLB_NOME
      // 
      this.lblCLB_NOME.AutoSize = true;
      this.lblCLB_NOME.Location = new System.Drawing.Point(6, 3);
      this.lblCLB_NOME.Name = "lblCLB_NOME";
      this.lblCLB_NOME.Size = new System.Drawing.Size(35, 13);
      this.lblCLB_NOME.TabIndex = 0;
      this.lblCLB_NOME.Text = "Nome";
      // 
      // txtCLB_NOME
      // 
      this.txtCLB_NOME.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_NOME.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_NOME.AutoTab = true;
      this.txtCLB_NOME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCLB_NOME.Location = new System.Drawing.Point(6, 19);
      this.txtCLB_NOME.Name = "txtCLB_NOME";
      this.txtCLB_NOME.Size = new System.Drawing.Size(334, 20);
      this.txtCLB_NOME.TabIndex = 1;
      this.txtCLB_NOME.TextFormat = null;
      this.txtCLB_NOME.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCLB_FONE
      // 
      this.lblCLB_FONE.AutoSize = true;
      this.lblCLB_FONE.Location = new System.Drawing.Point(6, 42);
      this.lblCLB_FONE.Name = "lblCLB_FONE";
      this.lblCLB_FONE.Size = new System.Drawing.Size(91, 13);
      this.lblCLB_FONE.TabIndex = 2;
      this.lblCLB_FONE.Text = "Telefone principal";
      // 
      // lblCLB_RECADO
      // 
      this.lblCLB_RECADO.AutoSize = true;
      this.lblCLB_RECADO.Location = new System.Drawing.Point(114, 42);
      this.lblCLB_RECADO.Name = "lblCLB_RECADO";
      this.lblCLB_RECADO.Size = new System.Drawing.Size(85, 13);
      this.lblCLB_RECADO.TabIndex = 4;
      this.lblCLB_RECADO.Text = "Telefone recado";
      // 
      // lblCLB_LOGRADOURO
      // 
      this.lblCLB_LOGRADOURO.AutoSize = true;
      this.lblCLB_LOGRADOURO.Location = new System.Drawing.Point(127, 120);
      this.lblCLB_LOGRADOURO.Name = "lblCLB_LOGRADOURO";
      this.lblCLB_LOGRADOURO.Size = new System.Drawing.Size(53, 13);
      this.lblCLB_LOGRADOURO.TabIndex = 14;
      this.lblCLB_LOGRADOURO.Text = "Endereço";
      // 
      // lblCLB_NUMERO
      // 
      this.lblCLB_NUMERO.AutoSize = true;
      this.lblCLB_NUMERO.Location = new System.Drawing.Point(398, 120);
      this.lblCLB_NUMERO.Name = "lblCLB_NUMERO";
      this.lblCLB_NUMERO.Size = new System.Drawing.Size(44, 13);
      this.lblCLB_NUMERO.TabIndex = 16;
      this.lblCLB_NUMERO.Text = "Número";
      // 
      // txtCLB_NUMERO
      // 
      this.txtCLB_NUMERO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_NUMERO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_NUMERO.AutoTab = true;
      this.txtCLB_NUMERO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCLB_NUMERO.Location = new System.Drawing.Point(404, 136);
      this.txtCLB_NUMERO.Name = "txtCLB_NUMERO";
      this.txtCLB_NUMERO.Size = new System.Drawing.Size(58, 20);
      this.txtCLB_NUMERO.TabIndex = 17;
      this.txtCLB_NUMERO.TextFormat = null;
      this.txtCLB_NUMERO.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCLB_BAIRRO
      // 
      this.lblCLB_BAIRRO.AutoSize = true;
      this.lblCLB_BAIRRO.Location = new System.Drawing.Point(7, 159);
      this.lblCLB_BAIRRO.Name = "lblCLB_BAIRRO";
      this.lblCLB_BAIRRO.Size = new System.Drawing.Size(34, 13);
      this.lblCLB_BAIRRO.TabIndex = 18;
      this.lblCLB_BAIRRO.Text = "Bairro";
      // 
      // lblCLB_CIDADE
      // 
      this.lblCLB_CIDADE.AutoSize = true;
      this.lblCLB_CIDADE.Location = new System.Drawing.Point(213, 159);
      this.lblCLB_CIDADE.Name = "lblCLB_CIDADE";
      this.lblCLB_CIDADE.Size = new System.Drawing.Size(40, 13);
      this.lblCLB_CIDADE.TabIndex = 20;
      this.lblCLB_CIDADE.Text = "Cidade";
      // 
      // txtCLB_CIDADE
      // 
      this.txtCLB_CIDADE.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_CIDADE.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_CIDADE.AutoTab = true;
      this.txtCLB_CIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCLB_CIDADE.Location = new System.Drawing.Point(213, 175);
      this.txtCLB_CIDADE.Name = "txtCLB_CIDADE";
      this.txtCLB_CIDADE.Size = new System.Drawing.Size(180, 20);
      this.txtCLB_CIDADE.TabIndex = 21;
      this.txtCLB_CIDADE.TextFormat = null;
      this.txtCLB_CIDADE.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCLB_ESTADO
      // 
      this.lblCLB_ESTADO.AutoSize = true;
      this.lblCLB_ESTADO.Location = new System.Drawing.Point(399, 159);
      this.lblCLB_ESTADO.Name = "lblCLB_ESTADO";
      this.lblCLB_ESTADO.Size = new System.Drawing.Size(40, 13);
      this.lblCLB_ESTADO.TabIndex = 22;
      this.lblCLB_ESTADO.Text = "Estado";
      // 
      // lblCLB_CEP
      // 
      this.lblCLB_CEP.AutoSize = true;
      this.lblCLB_CEP.Location = new System.Drawing.Point(6, 120);
      this.lblCLB_CEP.Name = "lblCLB_CEP";
      this.lblCLB_CEP.Size = new System.Drawing.Size(28, 13);
      this.lblCLB_CEP.TabIndex = 11;
      this.lblCLB_CEP.Text = "CEP";
      // 
      // lblCLB_OBS
      // 
      this.lblCLB_OBS.AutoSize = true;
      this.lblCLB_OBS.Location = new System.Drawing.Point(8, 199);
      this.lblCLB_OBS.Name = "lblCLB_OBS";
      this.lblCLB_OBS.Size = new System.Drawing.Size(26, 13);
      this.lblCLB_OBS.TabIndex = 24;
      this.lblCLB_OBS.Text = "Obs";
      // 
      // txtCLB_OBS
      // 
      this.txtCLB_OBS.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_OBS.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_OBS.AutoTab = true;
      this.txtCLB_OBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCLB_OBS.Location = new System.Drawing.Point(8, 215);
      this.txtCLB_OBS.Multiline = true;
      this.txtCLB_OBS.Name = "txtCLB_OBS";
      this.txtCLB_OBS.Size = new System.Drawing.Size(449, 45);
      this.txtCLB_OBS.TabIndex = 25;
      this.txtCLB_OBS.TextFormat = null;
      this.txtCLB_OBS.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCLB_FOTO
      // 
      this.lblCLB_FOTO.AutoSize = true;
      this.lblCLB_FOTO.Location = new System.Drawing.Point(346, 3);
      this.lblCLB_FOTO.Name = "lblCLB_FOTO";
      this.lblCLB_FOTO.Size = new System.Drawing.Size(28, 13);
      this.lblCLB_FOTO.TabIndex = 10;
      this.lblCLB_FOTO.Text = "Foto";
      // 
      // lblCLB_SALARIO
      // 
      this.lblCLB_SALARIO.AutoSize = true;
      this.lblCLB_SALARIO.Location = new System.Drawing.Point(284, 263);
      this.lblCLB_SALARIO.Name = "lblCLB_SALARIO";
      this.lblCLB_SALARIO.Size = new System.Drawing.Size(39, 13);
      this.lblCLB_SALARIO.TabIndex = 30;
      this.lblCLB_SALARIO.Text = "Salário";
      // 
      // txtCLB_SALARIO
      // 
      this.txtCLB_SALARIO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_SALARIO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_SALARIO.AutoTab = true;
      this.txtCLB_SALARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCLB_SALARIO.Location = new System.Drawing.Point(282, 281);
      this.txtCLB_SALARIO.Name = "txtCLB_SALARIO";
      this.txtCLB_SALARIO.Size = new System.Drawing.Size(102, 20);
      this.txtCLB_SALARIO.TabIndex = 31;
      this.txtCLB_SALARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCLB_SALARIO.TextFormat = "#,##0.00";
      this.txtCLB_SALARIO.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(195, 263);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(80, 13);
      this.sknLabel1.TabIndex = 28;
      this.sknLabel1.Text = "Dt. Nascimento";
      // 
      // txtCLB_DTNASC
      // 
      this.txtCLB_DTNASC.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_DTNASC.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_DTNASC.AutoTab = true;
      this.txtCLB_DTNASC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCLB_DTNASC.Location = new System.Drawing.Point(198, 281);
      this.txtCLB_DTNASC.Name = "txtCLB_DTNASC";
      this.txtCLB_DTNASC.Size = new System.Drawing.Size(80, 20);
      this.txtCLB_DTNASC.TabIndex = 29;
      this.txtCLB_DTNASC.TextFormat = "dd/MM/yyyy";
      this.txtCLB_DTNASC.TextType = lib.Visual.Components.enmTextType.DateTime;
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(6, 279);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(186, 21);
      this.cmbEmpresa.TabIndex = 27;
      // 
      // imgFoto
      // 
      this.imgFoto.BackColor = System.Drawing.SystemColors.ControlDark;
      this.imgFoto.Location = new System.Drawing.Point(346, 19);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(114, 98);
      this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgFoto.TabIndex = 31;
      this.imgFoto.TabStop = false;
      this.imgFoto.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // btnPesquisaCEP
      // 
      this.btnPesquisaCEP.Image = global::Folha_Marcelo.Properties.Resources.search;
      this.btnPesquisaCEP.Location = new System.Drawing.Point(83, 123);
      this.btnPesquisaCEP.Name = "btnPesquisaCEP";
      this.btnPesquisaCEP.Size = new System.Drawing.Size(38, 33);
      this.btnPesquisaCEP.TabIndex = 13;
      this.btnPesquisaCEP.UseVisualStyleBackColor = true;
      this.btnPesquisaCEP.Click += new System.EventHandler(this.btnPesquisaCEP_Click);
      // 
      // cmbCLB_LOGRADOURO
      // 
      this.cmbCLB_LOGRADOURO.AutoTab = true;
      this.cmbCLB_LOGRADOURO.FormattingEnabled = true;
      this.cmbCLB_LOGRADOURO.Location = new System.Drawing.Point(128, 136);
      this.cmbCLB_LOGRADOURO.Name = "cmbCLB_LOGRADOURO";
      this.cmbCLB_LOGRADOURO.Size = new System.Drawing.Size(270, 21);
      this.cmbCLB_LOGRADOURO.TabIndex = 15;
      // 
      // cmbCLB_BAIRRO
      // 
      this.cmbCLB_BAIRRO.AutoTab = true;
      this.cmbCLB_BAIRRO.FormattingEnabled = true;
      this.cmbCLB_BAIRRO.Location = new System.Drawing.Point(5, 175);
      this.cmbCLB_BAIRRO.Name = "cmbCLB_BAIRRO";
      this.cmbCLB_BAIRRO.Size = new System.Drawing.Size(202, 21);
      this.cmbCLB_BAIRRO.TabIndex = 19;
      // 
      // cmbCLB_ESTADO
      // 
      this.cmbCLB_ESTADO.AutoTab = true;
      this.cmbCLB_ESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCLB_ESTADO.FormattingEnabled = true;
      this.cmbCLB_ESTADO.Location = new System.Drawing.Point(399, 175);
      this.cmbCLB_ESTADO.Name = "cmbCLB_ESTADO";
      this.cmbCLB_ESTADO.Size = new System.Drawing.Size(60, 21);
      this.cmbCLB_ESTADO.TabIndex = 23;
      // 
      // txtCLB_CEP
      // 
      this.txtCLB_CEP.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_CEP.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_CEP.AutoTab = true;
      this.txtCLB_CEP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCLB_CEP.Location = new System.Drawing.Point(7, 136);
      this.txtCLB_CEP.Mask = "99999-999";
      this.txtCLB_CEP.Name = "txtCLB_CEP";
      this.txtCLB_CEP.Size = new System.Drawing.Size(70, 20);
      this.txtCLB_CEP.TabIndex = 12;
      this.txtCLB_CEP.TextFormat = null;
      this.txtCLB_CEP.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtCLB_RECADO
      // 
      this.txtCLB_RECADO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_RECADO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_RECADO.AutoTab = true;
      this.txtCLB_RECADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCLB_RECADO.Location = new System.Drawing.Point(114, 58);
      this.txtCLB_RECADO.Mask = "(99)999999999";
      this.txtCLB_RECADO.Name = "txtCLB_RECADO";
      this.txtCLB_RECADO.Size = new System.Drawing.Size(100, 20);
      this.txtCLB_RECADO.TabIndex = 5;
      this.txtCLB_RECADO.TextFormat = null;
      this.txtCLB_RECADO.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtCLB_FONE
      // 
      this.txtCLB_FONE.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_FONE.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_FONE.AutoTab = true;
      this.txtCLB_FONE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCLB_FONE.Location = new System.Drawing.Point(6, 58);
      this.txtCLB_FONE.Mask = "(99)999999999";
      this.txtCLB_FONE.Name = "txtCLB_FONE";
      this.txtCLB_FONE.Size = new System.Drawing.Size(104, 20);
      this.txtCLB_FONE.TabIndex = 3;
      this.txtCLB_FONE.TextFormat = null;
      this.txtCLB_FONE.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // cbCLB_INATIVO
      // 
      this.cbCLB_INATIVO.Location = new System.Drawing.Point(390, 276);
      this.cbCLB_INATIVO.Name = "cbCLB_INATIVO";
      this.cbCLB_INATIVO.Size = new System.Drawing.Size(70, 24);
      this.cbCLB_INATIVO.TabIndex = 32;
      this.cbCLB_INATIVO.Text = "Inativo";
      this.cbCLB_INATIVO.UseVisualStyleBackColor = true;
      // 
      // tbcCadastro
      // 
      this.tbcCadastro.Controls.Add(this.tabPage1);
      this.tbcCadastro.Controls.Add(this.tbHistorico);
      this.tbcCadastro.Controls.Add(this.tbAlertas);
      this.tbcCadastro.Location = new System.Drawing.Point(12, 6);
      this.tbcCadastro.Name = "tbcCadastro";
      this.tbcCadastro.SelectedIndex = 0;
      this.tbcCadastro.Size = new System.Drawing.Size(496, 342);
      this.tbcCadastro.TabIndex = 32;
      this.tbcCadastro.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.txtCLB_CPF);
      this.tabPage1.Controls.Add(this.txtCLB_RG);
      this.tabPage1.Controls.Add(this.sknLabel2);
      this.tabPage1.Controls.Add(this.sknLabel3);
      this.tabPage1.Controls.Add(this.lblCLB_NOME);
      this.tabPage1.Controls.Add(this.txtCLB_FONE);
      this.tabPage1.Controls.Add(this.txtCLB_SALARIO);
      this.tabPage1.Controls.Add(this.txtCLB_RECADO);
      this.tabPage1.Controls.Add(this.lblCLB_SALARIO);
      this.tabPage1.Controls.Add(this.txtCLB_CEP);
      this.tabPage1.Controls.Add(this.lblCLB_FOTO);
      this.tabPage1.Controls.Add(this.cmbCLB_ESTADO);
      this.tabPage1.Controls.Add(this.txtCLB_OBS);
      this.tabPage1.Controls.Add(this.cmbCLB_BAIRRO);
      this.tabPage1.Controls.Add(this.lblCLB_OBS);
      this.tabPage1.Controls.Add(this.cmbCLB_LOGRADOURO);
      this.tabPage1.Controls.Add(this.lblCLB_CEP);
      this.tabPage1.Controls.Add(this.btnPesquisaCEP);
      this.tabPage1.Controls.Add(this.lblCLB_ESTADO);
      this.tabPage1.Controls.Add(this.imgFoto);
      this.tabPage1.Controls.Add(this.txtCLB_CIDADE);
      this.tabPage1.Controls.Add(this.cbCLB_INATIVO);
      this.tabPage1.Controls.Add(this.lblCLB_CIDADE);
      this.tabPage1.Controls.Add(this.cmbEmpresa);
      this.tabPage1.Controls.Add(this.lblCLB_BAIRRO);
      this.tabPage1.Controls.Add(this.sknLabel1);
      this.tabPage1.Controls.Add(this.txtCLB_NUMERO);
      this.tabPage1.Controls.Add(this.txtCLB_DTNASC);
      this.tabPage1.Controls.Add(this.lblCLB_NUMERO);
      this.tabPage1.Controls.Add(this.lblCLB_EMP_CODIGO);
      this.tabPage1.Controls.Add(this.lblCLB_LOGRADOURO);
      this.tabPage1.Controls.Add(this.lblCLB_RECADO);
      this.tabPage1.Controls.Add(this.txtCLB_NOME);
      this.tabPage1.Controls.Add(this.lblCLB_FONE);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(488, 316);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Dados Pessoais";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // txtCLB_CPF
      // 
      this.txtCLB_CPF.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_CPF.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_CPF.AutoTab = true;
      this.txtCLB_CPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCLB_CPF.Location = new System.Drawing.Point(7, 97);
      this.txtCLB_CPF.Mask = "999,999,999-99";
      this.txtCLB_CPF.Name = "txtCLB_CPF";
      this.txtCLB_CPF.Size = new System.Drawing.Size(104, 20);
      this.txtCLB_CPF.TabIndex = 7;
      this.txtCLB_CPF.TextFormat = null;
      this.txtCLB_CPF.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtCLB_RG
      // 
      this.txtCLB_RG.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCLB_RG.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCLB_RG.AutoTab = true;
      this.txtCLB_RG.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCLB_RG.Location = new System.Drawing.Point(114, 97);
      this.txtCLB_RG.Mask = "99,999,999-A";
      this.txtCLB_RG.Name = "txtCLB_RG";
      this.txtCLB_RG.Size = new System.Drawing.Size(100, 20);
      this.txtCLB_RG.TabIndex = 9;
      this.txtCLB_RG.TextFormat = null;
      this.txtCLB_RG.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(115, 81);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(23, 13);
      this.sknLabel2.TabIndex = 8;
      this.sknLabel2.Text = "RG";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(6, 81);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(27, 13);
      this.sknLabel3.TabIndex = 6;
      this.sknLabel3.Text = "CPF";
      // 
      // tbHistorico
      // 
      this.tbHistorico.Controls.Add(this.grdHistorico);
      this.tbHistorico.Controls.Add(this.panel2);
      this.tbHistorico.Location = new System.Drawing.Point(4, 22);
      this.tbHistorico.Name = "tbHistorico";
      this.tbHistorico.Padding = new System.Windows.Forms.Padding(3);
      this.tbHistorico.Size = new System.Drawing.Size(488, 316);
      this.tbHistorico.TabIndex = 1;
      this.tbHistorico.Text = "Histórico";
      this.tbHistorico.UseVisualStyleBackColor = true;
      // 
      // grdHistorico
      // 
      this.grdHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
      this.grdHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdHistorico.Location = new System.Drawing.Point(3, 32);
      this.grdHistorico.Name = "grdHistorico";
      this.grdHistorico.Size = new System.Drawing.Size(482, 281);
      this.grdHistorico.TabIndex = 11;
      this.grdHistorico.DoubleClick += new System.EventHandler(this.grdHistorico_DoubleClick);
      this.grdHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdHistorico_KeyDown);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Column1";
      this.Column1.Name = "Column1";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnEditarHistorico);
      this.panel2.Controls.Add(this.btnRemoverHistorico);
      this.panel2.Controls.Add(this.btnAdicionarHistorico);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(482, 29);
      this.panel2.TabIndex = 12;
      // 
      // btnEditarHistorico
      // 
      this.btnEditarHistorico.Location = new System.Drawing.Point(84, 3);
      this.btnEditarHistorico.Name = "btnEditarHistorico";
      this.btnEditarHistorico.Size = new System.Drawing.Size(75, 23);
      this.btnEditarHistorico.TabIndex = 2;
      this.btnEditarHistorico.Text = "Editar";
      this.btnEditarHistorico.UseVisualStyleBackColor = true;
      this.btnEditarHistorico.Click += new System.EventHandler(this.btnEditarHistorico_Click);
      // 
      // btnRemoverHistorico
      // 
      this.btnRemoverHistorico.Location = new System.Drawing.Point(165, 3);
      this.btnRemoverHistorico.Name = "btnRemoverHistorico";
      this.btnRemoverHistorico.Size = new System.Drawing.Size(75, 23);
      this.btnRemoverHistorico.TabIndex = 1;
      this.btnRemoverHistorico.Text = "Remover";
      this.btnRemoverHistorico.UseVisualStyleBackColor = true;
      this.btnRemoverHistorico.Click += new System.EventHandler(this.btnRemoverHistorico_Click);
      // 
      // btnAdicionarHistorico
      // 
      this.btnAdicionarHistorico.Location = new System.Drawing.Point(3, 3);
      this.btnAdicionarHistorico.Name = "btnAdicionarHistorico";
      this.btnAdicionarHistorico.Size = new System.Drawing.Size(75, 23);
      this.btnAdicionarHistorico.TabIndex = 0;
      this.btnAdicionarHistorico.Text = "Adicionar";
      this.btnAdicionarHistorico.UseVisualStyleBackColor = true;
      this.btnAdicionarHistorico.Click += new System.EventHandler(this.btnAdicionarHistorico_Click);
      // 
      // tbAlertas
      // 
      this.tbAlertas.Controls.Add(this.grdAlertas);
      this.tbAlertas.Controls.Add(this.panel1);
      this.tbAlertas.Location = new System.Drawing.Point(4, 22);
      this.tbAlertas.Name = "tbAlertas";
      this.tbAlertas.Padding = new System.Windows.Forms.Padding(3);
      this.tbAlertas.Size = new System.Drawing.Size(488, 316);
      this.tbAlertas.TabIndex = 2;
      this.tbAlertas.Text = "Alertas";
      this.tbAlertas.UseVisualStyleBackColor = true;
      // 
      // grdAlertas
      // 
      this.grdAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdAlertas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdAlertas.Location = new System.Drawing.Point(3, 32);
      this.grdAlertas.Name = "grdAlertas";
      this.grdAlertas.Size = new System.Drawing.Size(482, 281);
      this.grdAlertas.TabIndex = 4;
      this.grdAlertas.DoubleClick += new System.EventHandler(this.grdAlertas_DoubleClick);
      this.grdAlertas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdAlertas_KeyDown);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnEditarAlerta);
      this.panel1.Controls.Add(this.btnRemoverAlertas);
      this.panel1.Controls.Add(this.btnAdicionarAlertas);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(482, 29);
      this.panel1.TabIndex = 3;
      // 
      // btnEditarAlerta
      // 
      this.btnEditarAlerta.Location = new System.Drawing.Point(84, 3);
      this.btnEditarAlerta.Name = "btnEditarAlerta";
      this.btnEditarAlerta.Size = new System.Drawing.Size(75, 23);
      this.btnEditarAlerta.TabIndex = 2;
      this.btnEditarAlerta.Text = "Editar";
      this.btnEditarAlerta.UseVisualStyleBackColor = true;
      this.btnEditarAlerta.Click += new System.EventHandler(this.btnEditarAlerta_Click);
      // 
      // btnRemoverAlertas
      // 
      this.btnRemoverAlertas.Location = new System.Drawing.Point(165, 3);
      this.btnRemoverAlertas.Name = "btnRemoverAlertas";
      this.btnRemoverAlertas.Size = new System.Drawing.Size(75, 23);
      this.btnRemoverAlertas.TabIndex = 1;
      this.btnRemoverAlertas.Text = "Remover";
      this.btnRemoverAlertas.UseVisualStyleBackColor = true;
      this.btnRemoverAlertas.Click += new System.EventHandler(this.btnRemoverAlertas_Click);
      // 
      // btnAdicionarAlertas
      // 
      this.btnAdicionarAlertas.Location = new System.Drawing.Point(3, 3);
      this.btnAdicionarAlertas.Name = "btnAdicionarAlertas";
      this.btnAdicionarAlertas.Size = new System.Drawing.Size(75, 23);
      this.btnAdicionarAlertas.TabIndex = 0;
      this.btnAdicionarAlertas.Text = "Adicionar";
      this.btnAdicionarAlertas.UseVisualStyleBackColor = true;
      this.btnAdicionarAlertas.Click += new System.EventHandler(this.btnAdicionarAlertas_Click);
      // 
      // frmCLB_COLABORADOR
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 432);
      this.Name = "frmCLB_COLABORADOR";
      this.Text = "Cadastro de colaboradores";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      this.tbcCadastro.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tbHistorico.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).EndInit();
      this.panel2.ResumeLayout(false);
      this.tbAlertas.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdAlertas)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblCLB_EMP_CODIGO;
    private lib.Visual.Components.sknLabel lblCLB_NOME;
    private lib.Visual.Components.sknTextBox txtCLB_NOME;
    private lib.Visual.Components.sknLabel lblCLB_FONE;
    private lib.Visual.Components.sknLabel lblCLB_RECADO;
    private lib.Visual.Components.sknLabel lblCLB_LOGRADOURO;
    private lib.Visual.Components.sknLabel lblCLB_NUMERO;
    private lib.Visual.Components.sknTextBox txtCLB_NUMERO;
    private lib.Visual.Components.sknLabel lblCLB_BAIRRO;
    private lib.Visual.Components.sknLabel lblCLB_CIDADE;
    private lib.Visual.Components.sknTextBox txtCLB_CIDADE;
    private lib.Visual.Components.sknLabel lblCLB_ESTADO;
    private lib.Visual.Components.sknLabel lblCLB_CEP;
    private lib.Visual.Components.sknLabel lblCLB_OBS;
    private lib.Visual.Components.sknTextBox txtCLB_OBS;
    private lib.Visual.Components.sknLabel lblCLB_FOTO;
    private lib.Visual.Components.sknLabel lblCLB_SALARIO;
    private lib.Visual.Components.sknTextBox txtCLB_SALARIO;
    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtCLB_DTNASC;
    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.OpenFileDialog dlgOpen;
    private System.Windows.Forms.Button btnPesquisaCEP;
    private lib.Visual.Components.sknComboBox cmbCLB_ESTADO;
    private lib.Visual.Components.sknComboBox cmbCLB_BAIRRO;
    private lib.Visual.Components.sknComboBox cmbCLB_LOGRADOURO;
    private lib.Visual.Components.sknMaskedTextBox txtCLB_CEP;
    private lib.Visual.Components.sknMaskedTextBox txtCLB_FONE;
    private lib.Visual.Components.sknMaskedTextBox txtCLB_RECADO;
    private lib.Visual.Components.sknCheckBox cbCLB_INATIVO;
    private System.Windows.Forms.TabControl tbcCadastro;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tbHistorico;
    private lib.Visual.Components.sknMaskedTextBox txtCLB_CPF;
    private lib.Visual.Components.sknMaskedTextBox txtCLB_RG;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknGrid grdHistorico;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnEditarHistorico;
    private System.Windows.Forms.Button btnRemoverHistorico;
    private System.Windows.Forms.Button btnAdicionarHistorico;
    private System.Windows.Forms.TabPage tbAlertas;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnEditarAlerta;
    private System.Windows.Forms.Button btnRemoverAlertas;
    private System.Windows.Forms.Button btnAdicionarAlertas;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private lib.Visual.Components.sknGrid grdAlertas;
  }
}
