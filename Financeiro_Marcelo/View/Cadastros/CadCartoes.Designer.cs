namespace Financeiro_Marcelo
{
  partial class frmCRT_CARTOES
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
      this.lblCRT_EMP_CODIGO = new lib.Visual.Components.sknLabel();
      this.lblCRT_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtCRT_DESCRICAO = new lib.Visual.Components.sknTextBox();
      this.lblCRT_NRDIAS = new lib.Visual.Components.sknLabel();
      this.txtCRT_NRDIAS = new lib.Visual.Components.sknTextBox();
      this.lblCRT_VENCIMENTOS = new lib.Visual.Components.sknLabel();
      this.txtCRT_VENCIMENTOS = new lib.Visual.Components.sknTextBox();
      this.lblCRT_TAXA = new lib.Visual.Components.sknLabel();
      this.txtCRT_TAXA = new lib.Visual.Components.sknTextBox();
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbFixo = new System.Windows.Forms.RadioButton();
      this.rbApos = new System.Windows.Forms.RadioButton();
      this.rbFechamento = new System.Windows.Forms.RadioButton();
      this.cmbSemana = new lib.Visual.Components.sknComboBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtFecha_NrDias = new lib.Visual.Components.sknTextBox();
      this.pnlEdit.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.groupBox1);
      this.pnlEdit.Controls.Add(this.cmbEmpresa);
      this.pnlEdit.Controls.Add(this.lblCRT_EMP_CODIGO);
      this.pnlEdit.Controls.Add(this.lblCRT_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtCRT_DESCRICAO);
      this.pnlEdit.Controls.Add(this.lblCRT_TAXA);
      this.pnlEdit.Controls.Add(this.txtCRT_TAXA);
      this.pnlEdit.Size = new System.Drawing.Size(475, 283);
      // 
      // lblCRT_EMP_CODIGO
      // 
      this.lblCRT_EMP_CODIGO.AutoSize = true;
      this.lblCRT_EMP_CODIGO.Location = new System.Drawing.Point(12, 3);
      this.lblCRT_EMP_CODIGO.Name = "lblCRT_EMP_CODIGO";
      this.lblCRT_EMP_CODIGO.Size = new System.Drawing.Size(48, 13);
      this.lblCRT_EMP_CODIGO.TabIndex = 0;
      this.lblCRT_EMP_CODIGO.Text = "Empresa";
      // 
      // lblCRT_DESCRICAO
      // 
      this.lblCRT_DESCRICAO.AutoSize = true;
      this.lblCRT_DESCRICAO.Location = new System.Drawing.Point(12, 43);
      this.lblCRT_DESCRICAO.Name = "lblCRT_DESCRICAO";
      this.lblCRT_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblCRT_DESCRICAO.TabIndex = 2;
      this.lblCRT_DESCRICAO.Text = "Descrição";
      // 
      // txtCRT_DESCRICAO
      // 
      this.txtCRT_DESCRICAO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCRT_DESCRICAO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCRT_DESCRICAO.AutoTab = true;
      this.txtCRT_DESCRICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCRT_DESCRICAO.Location = new System.Drawing.Point(12, 59);
      this.txtCRT_DESCRICAO.Name = "txtCRT_DESCRICAO";
      this.txtCRT_DESCRICAO.Size = new System.Drawing.Size(374, 20);
      this.txtCRT_DESCRICAO.TabIndex = 3;
      this.txtCRT_DESCRICAO.TextFormat = null;
      this.txtCRT_DESCRICAO.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCRT_NRDIAS
      // 
      this.lblCRT_NRDIAS.AutoSize = true;
      this.lblCRT_NRDIAS.Location = new System.Drawing.Point(73, 59);
      this.lblCRT_NRDIAS.Name = "lblCRT_NRDIAS";
      this.lblCRT_NRDIAS.Size = new System.Drawing.Size(126, 13);
      this.lblCRT_NRDIAS.TabIndex = 6;
      this.lblCRT_NRDIAS.Text = "Lançar após um nro. dias";
      // 
      // txtCRT_NRDIAS
      // 
      this.txtCRT_NRDIAS.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCRT_NRDIAS.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCRT_NRDIAS.AutoTab = true;
      this.txtCRT_NRDIAS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCRT_NRDIAS.Location = new System.Drawing.Point(73, 75);
      this.txtCRT_NRDIAS.Name = "txtCRT_NRDIAS";
      this.txtCRT_NRDIAS.Size = new System.Drawing.Size(121, 20);
      this.txtCRT_NRDIAS.TabIndex = 7;
      this.txtCRT_NRDIAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCRT_NRDIAS.TextFormat = null;
      this.txtCRT_NRDIAS.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // lblCRT_VENCIMENTOS
      // 
      this.lblCRT_VENCIMENTOS.AutoSize = true;
      this.lblCRT_VENCIMENTOS.Location = new System.Drawing.Point(73, 98);
      this.lblCRT_VENCIMENTOS.Name = "lblCRT_VENCIMENTOS";
      this.lblCRT_VENCIMENTOS.Size = new System.Drawing.Size(195, 13);
      this.lblCRT_VENCIMENTOS.TabIndex = 9;
      this.lblCRT_VENCIMENTOS.Text = "Vencimentos fixos (separar com vírgula)";
      // 
      // txtCRT_VENCIMENTOS
      // 
      this.txtCRT_VENCIMENTOS.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCRT_VENCIMENTOS.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCRT_VENCIMENTOS.AutoTab = true;
      this.txtCRT_VENCIMENTOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCRT_VENCIMENTOS.Location = new System.Drawing.Point(73, 114);
      this.txtCRT_VENCIMENTOS.Name = "txtCRT_VENCIMENTOS";
      this.txtCRT_VENCIMENTOS.Size = new System.Drawing.Size(200, 20);
      this.txtCRT_VENCIMENTOS.TabIndex = 10;
      this.txtCRT_VENCIMENTOS.TextFormat = null;
      this.txtCRT_VENCIMENTOS.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblCRT_TAXA
      // 
      this.lblCRT_TAXA.AutoSize = true;
      this.lblCRT_TAXA.Location = new System.Drawing.Point(12, 238);
      this.lblCRT_TAXA.Name = "lblCRT_TAXA";
      this.lblCRT_TAXA.Size = new System.Drawing.Size(31, 13);
      this.lblCRT_TAXA.TabIndex = 5;
      this.lblCRT_TAXA.Text = "Taxa";
      // 
      // txtCRT_TAXA
      // 
      this.txtCRT_TAXA.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCRT_TAXA.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCRT_TAXA.AutoTab = true;
      this.txtCRT_TAXA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCRT_TAXA.Location = new System.Drawing.Point(12, 254);
      this.txtCRT_TAXA.Name = "txtCRT_TAXA";
      this.txtCRT_TAXA.Size = new System.Drawing.Size(121, 20);
      this.txtCRT_TAXA.TabIndex = 6;
      this.txtCRT_TAXA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCRT_TAXA.TextFormat = "#,##0.00";
      this.txtCRT_TAXA.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(12, 19);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(200, 21);
      this.cmbEmpresa.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.sknLabel2);
      this.groupBox1.Controls.Add(this.txtFecha_NrDias);
      this.groupBox1.Controls.Add(this.sknLabel1);
      this.groupBox1.Controls.Add(this.cmbSemana);
      this.groupBox1.Controls.Add(this.rbFechamento);
      this.groupBox1.Controls.Add(this.rbFixo);
      this.groupBox1.Controls.Add(this.rbApos);
      this.groupBox1.Controls.Add(this.lblCRT_NRDIAS);
      this.groupBox1.Controls.Add(this.txtCRT_NRDIAS);
      this.groupBox1.Controls.Add(this.lblCRT_VENCIMENTOS);
      this.groupBox1.Controls.Add(this.txtCRT_VENCIMENTOS);
      this.groupBox1.Location = new System.Drawing.Point(12, 85);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(374, 150);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Vencimento";
      // 
      // rbFixo
      // 
      this.rbFixo.AutoSize = true;
      this.rbFixo.Location = new System.Drawing.Point(6, 115);
      this.rbFixo.Name = "rbFixo";
      this.rbFixo.Size = new System.Drawing.Size(44, 17);
      this.rbFixo.TabIndex = 8;
      this.rbFixo.TabStop = true;
      this.rbFixo.Text = "Fixo";
      this.rbFixo.UseVisualStyleBackColor = true;
      this.rbFixo.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbApos
      // 
      this.rbApos.AutoSize = true;
      this.rbApos.Location = new System.Drawing.Point(7, 76);
      this.rbApos.Name = "rbApos";
      this.rbApos.Size = new System.Drawing.Size(48, 17);
      this.rbApos.TabIndex = 5;
      this.rbApos.TabStop = true;
      this.rbApos.Text = "após";
      this.rbApos.UseVisualStyleBackColor = true;
      this.rbApos.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbFechamento
      // 
      this.rbFechamento.AutoSize = true;
      this.rbFechamento.Location = new System.Drawing.Point(6, 36);
      this.rbFechamento.Name = "rbFechamento";
      this.rbFechamento.Size = new System.Drawing.Size(84, 17);
      this.rbFechamento.TabIndex = 0;
      this.rbFechamento.TabStop = true;
      this.rbFechamento.Text = "Fechamento";
      this.rbFechamento.UseVisualStyleBackColor = true;
      this.rbFechamento.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // cmbSemana
      // 
      this.cmbSemana.AutoTab = true;
      this.cmbSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSemana.FormattingEnabled = true;
      this.cmbSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
      this.cmbSemana.Location = new System.Drawing.Point(101, 35);
      this.cmbSemana.Name = "cmbSemana";
      this.cmbSemana.Size = new System.Drawing.Size(121, 21);
      this.cmbSemana.TabIndex = 2;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(100, 16);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(46, 13);
      this.sknLabel1.TabIndex = 1;
      this.sknLabel1.Text = "Semana";
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(225, 16);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(126, 13);
      this.sknLabel2.TabIndex = 3;
      this.sknLabel2.Text = "Lançar após um nro. dias";
      // 
      // txtFecha_NrDias
      // 
      this.txtFecha_NrDias.AsDateTime = new System.DateTime(((long)(0)));
      this.txtFecha_NrDias.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtFecha_NrDias.AutoTab = true;
      this.txtFecha_NrDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtFecha_NrDias.Location = new System.Drawing.Point(228, 36);
      this.txtFecha_NrDias.Name = "txtFecha_NrDias";
      this.txtFecha_NrDias.Size = new System.Drawing.Size(121, 20);
      this.txtFecha_NrDias.TabIndex = 4;
      this.txtFecha_NrDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtFecha_NrDias.TextFormat = null;
      this.txtFecha_NrDias.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // frmCRT_CARTOES
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 363);
      this.Name = "frmCRT_CARTOES";
      this.Text = "Cadastro de Cartões";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblCRT_EMP_CODIGO;
    private lib.Visual.Components.sknLabel lblCRT_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtCRT_DESCRICAO;
    private lib.Visual.Components.sknLabel lblCRT_NRDIAS;
    private lib.Visual.Components.sknTextBox txtCRT_NRDIAS;
    private lib.Visual.Components.sknLabel lblCRT_VENCIMENTOS;
    private lib.Visual.Components.sknTextBox txtCRT_VENCIMENTOS;
    private lib.Visual.Components.sknLabel lblCRT_TAXA;
    private lib.Visual.Components.sknTextBox txtCRT_TAXA;
    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbFixo;
    private System.Windows.Forms.RadioButton rbApos;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtFecha_NrDias;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknComboBox cmbSemana;
    private System.Windows.Forms.RadioButton rbFechamento;
  }
}
