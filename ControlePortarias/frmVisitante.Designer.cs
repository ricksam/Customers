namespace ControlePortarias
{
  partial class frmVisitante
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitante));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPlaca = new System.Windows.Forms.TextBox();
      this.txtVeiculo = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.txtEmail = new lib.Visual.Components.sknTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtNome = new lib.Visual.Components.sknTextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnSalvar = new lib.Visual.Components.sknButton();
      this.label9 = new System.Windows.Forms.Label();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.lblInfo = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.cmbTitulo = new System.Windows.Forms.ComboBox();
      this.imgFoto = new System.Windows.Forms.PictureBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtObs = new lib.Visual.Components.sknTextBox();
      this.txtTelefone = new lib.Visual.Components.sknMaskedTextBox();
      this.txtMorador = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.btnPesquisa = new lib.Visual.Components.sknButton();
      this.grdVisitas = new System.Windows.Forms.DataGridView();
      this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Morador = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnRejeitar = new lib.Visual.Components.sknButton();
      this.btnAutorizar = new lib.Visual.Components.sknButton();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdVisitas)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Placa";
      // 
      // txtPlaca
      // 
      this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPlaca.Location = new System.Drawing.Point(12, 70);
      this.txtPlaca.Name = "txtPlaca";
      this.txtPlaca.Size = new System.Drawing.Size(109, 26);
      this.txtPlaca.TabIndex = 1;
      // 
      // txtVeiculo
      // 
      this.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtVeiculo.Location = new System.Drawing.Point(127, 70);
      this.txtVeiculo.Name = "txtVeiculo";
      this.txtVeiculo.Size = new System.Drawing.Size(190, 26);
      this.txtVeiculo.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(127, 54);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(123, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Veículo (Modelo/Marca)";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 177);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(49, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Telefone";
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
      this.txtEmail.Location = new System.Drawing.Point(12, 154);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(450, 20);
      this.txtEmail.TabIndex = 11;
      this.txtEmail.TextFormat = null;
      this.txtEmail.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 138);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(32, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Email";
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
      this.txtNome.Location = new System.Drawing.Point(224, 115);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(238, 20);
      this.txtNome.TabIndex = 9;
      this.txtNome.TextFormat = null;
      this.txtNome.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(221, 99);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(35, 13);
      this.label8.TabIndex = 8;
      this.label8.Text = "Nome";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(237, 177);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(92, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "Visitará o Morador";
      // 
      // btnSalvar
      // 
      this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
      this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSalvar.Location = new System.Drawing.Point(12, 258);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(357, 39);
      this.btnSalvar.TabIndex = 20;
      this.btnSalvar.Text = "Salvar / Enviar Notificação";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(320, 54);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(124, 13);
      this.label9.TabIndex = 4;
      this.label9.Text = "RG / CPF ( Documento )";
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
      this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.txtDocumento.Location = new System.Drawing.Point(323, 70);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(139, 26);
      this.txtDocumento.TabIndex = 5;
      this.txtDocumento.TextFormat = null;
      this.txtDocumento.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblInfo
      // 
      this.lblInfo.BackColor = System.Drawing.Color.Green;
      this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblInfo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfo.ForeColor = System.Drawing.Color.White;
      this.lblInfo.Location = new System.Drawing.Point(0, 468);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(634, 44);
      this.lblInfo.TabIndex = 22;
      this.lblInfo.Text = "Liberado pelo Morador";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(12, 99);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(33, 13);
      this.label11.TabIndex = 6;
      this.label11.Text = "Titulo";
      // 
      // cmbTitulo
      // 
      this.cmbTitulo.FormattingEnabled = true;
      this.cmbTitulo.Items.AddRange(new object[] {
            "Visitante",
            "Prestador de Serviços",
            "Empregados Domésticos / Faixineiros",
            "Predreiros ativos Obras",
            "Saae",
            "Eletropaulo",
            "Internet ( Vivo / Net / GVT )"});
      this.cmbTitulo.Location = new System.Drawing.Point(12, 115);
      this.cmbTitulo.Name = "cmbTitulo";
      this.cmbTitulo.Size = new System.Drawing.Size(206, 21);
      this.cmbTitulo.TabIndex = 7;
      this.cmbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_KeyPress);
      // 
      // imgFoto
      // 
      this.imgFoto.Location = new System.Drawing.Point(469, 70);
      this.imgFoto.Name = "imgFoto";
      this.imgFoto.Size = new System.Drawing.Size(152, 182);
      this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.imgFoto.TabIndex = 24;
      this.imgFoto.TabStop = false;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(466, 54);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(49, 13);
      this.label12.TabIndex = 21;
      this.label12.Text = "Foto [F3]";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 216);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "Obs";
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
      this.txtObs.Location = new System.Drawing.Point(12, 232);
      this.txtObs.Name = "txtObs";
      this.txtObs.Size = new System.Drawing.Size(450, 20);
      this.txtObs.TabIndex = 18;
      this.txtObs.TextFormat = null;
      this.txtObs.TextType = lib.Visual.Components.enmTextType.String;
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
      this.txtTelefone.Location = new System.Drawing.Point(12, 193);
      this.txtTelefone.Mask = "(99)999999999";
      this.txtTelefone.Name = "txtTelefone";
      this.txtTelefone.Size = new System.Drawing.Size(222, 20);
      this.txtTelefone.TabIndex = 13;
      this.txtTelefone.TextFormat = null;
      this.txtTelefone.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtMorador
      // 
      this.txtMorador.Enabled = false;
      this.txtMorador.Location = new System.Drawing.Point(240, 193);
      this.txtMorador.Name = "txtMorador";
      this.txtMorador.Size = new System.Drawing.Size(187, 20);
      this.txtMorador.TabIndex = 15;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(433, 191);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(30, 23);
      this.button1.TabIndex = 16;
      this.button1.Text = "...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnPesquisa
      // 
      this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
      this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPesquisa.Location = new System.Drawing.Point(12, 12);
      this.btnPesquisa.Name = "btnPesquisa";
      this.btnPesquisa.Size = new System.Drawing.Size(609, 39);
      this.btnPesquisa.TabIndex = 25;
      this.btnPesquisa.Text = "&Pesquisar Visitante";
      this.btnPesquisa.UseVisualStyleBackColor = true;
      this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
      // 
      // grdVisitas
      // 
      this.grdVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdVisitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nome,
            this.Titulo,
            this.Casa,
            this.Morador,
            this.Status});
      this.grdVisitas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdVisitas.Location = new System.Drawing.Point(0, 305);
      this.grdVisitas.Name = "grdVisitas";
      this.grdVisitas.Size = new System.Drawing.Size(634, 163);
      this.grdVisitas.TabIndex = 26;
      // 
      // Data
      // 
      this.Data.DataPropertyName = "RVT_DATA";
      dataGridViewCellStyle2.Format = "dd/MM/yy HH:mm";
      this.Data.DefaultCellStyle = dataGridViewCellStyle2;
      this.Data.HeaderText = "Data";
      this.Data.Name = "Data";
      // 
      // Nome
      // 
      this.Nome.DataPropertyName = "RVT_NOME";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      // 
      // Titulo
      // 
      this.Titulo.DataPropertyName = "RVT_TITULO";
      this.Titulo.HeaderText = "Título";
      this.Titulo.Name = "Titulo";
      // 
      // Casa
      // 
      this.Casa.DataPropertyName = "CASA";
      this.Casa.HeaderText = "Casa";
      this.Casa.Name = "Casa";
      // 
      // Morador
      // 
      this.Morador.DataPropertyName = "MRD_NOME";
      this.Morador.HeaderText = "Morador";
      this.Morador.Name = "Morador";
      // 
      // Status
      // 
      this.Status.DataPropertyName = "RVT_STATUS";
      this.Status.HeaderText = "Status";
      this.Status.Name = "Status";
      this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnRejeitar);
      this.panel1.Controls.Add(this.btnAutorizar);
      this.panel1.Controls.Add(this.btnPesquisa);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtPlaca);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.txtMorador);
      this.panel1.Controls.Add(this.txtVeiculo);
      this.panel1.Controls.Add(this.txtTelefone);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.txtObs);
      this.panel1.Controls.Add(this.txtNome);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.txtEmail);
      this.panel1.Controls.Add(this.imgFoto);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.cmbTitulo);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Controls.Add(this.btnSalvar);
      this.panel1.Controls.Add(this.txtDocumento);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(634, 305);
      this.panel1.TabIndex = 27;
      // 
      // btnRejeitar
      // 
      this.btnRejeitar.Image = ((System.Drawing.Image)(resources.GetObject("btnRejeitar.Image")));
      this.btnRejeitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRejeitar.Location = new System.Drawing.Point(501, 258);
      this.btnRejeitar.Name = "btnRejeitar";
      this.btnRejeitar.Size = new System.Drawing.Size(120, 39);
      this.btnRejeitar.TabIndex = 27;
      this.btnRejeitar.Text = "Rejeitar";
      this.btnRejeitar.UseVisualStyleBackColor = true;
      this.btnRejeitar.Click += new System.EventHandler(this.btnRejeitar_Click);
      // 
      // btnAutorizar
      // 
      this.btnAutorizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizar.Image")));
      this.btnAutorizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAutorizar.Location = new System.Drawing.Point(375, 258);
      this.btnAutorizar.Name = "btnAutorizar";
      this.btnAutorizar.Size = new System.Drawing.Size(120, 39);
      this.btnAutorizar.TabIndex = 26;
      this.btnAutorizar.Text = "Autorizar";
      this.btnAutorizar.UseVisualStyleBackColor = true;
      this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 2000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // frmVisitante
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(634, 512);
      this.Controls.Add(this.grdVisitas);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblInfo);
      this.Name = "frmVisitante";
      this.Text = "Registros de Visitas";
      this.Load += new System.EventHandler(this.frmVisitante_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVisitante_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdVisitas)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPlaca;
    private System.Windows.Forms.TextBox txtVeiculo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private lib.Visual.Components.sknTextBox txtEmail;
    private System.Windows.Forms.Label label7;
    private lib.Visual.Components.sknTextBox txtNome;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknButton btnSalvar;
    private System.Windows.Forms.Label label9;
    private lib.Visual.Components.sknTextBox txtDocumento;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox cmbTitulo;
    private System.Windows.Forms.PictureBox imgFoto;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label1;
    private lib.Visual.Components.sknTextBox txtObs;
    private lib.Visual.Components.sknMaskedTextBox txtTelefone;
    private System.Windows.Forms.TextBox txtMorador;
    private System.Windows.Forms.Button button1;
    protected lib.Visual.Components.sknButton btnPesquisa;
    private System.Windows.Forms.DataGridView grdVisitas;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Casa;
    private System.Windows.Forms.DataGridViewTextBoxColumn Morador;
    private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    private lib.Visual.Components.sknButton btnRejeitar;
    private lib.Visual.Components.sknButton btnAutorizar;
    private System.Windows.Forms.Timer timer1;
  }
}