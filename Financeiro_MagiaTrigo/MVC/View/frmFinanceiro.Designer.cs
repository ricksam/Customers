namespace MagiaTrigo
{
  partial class frmFinanceiro
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
      this.lblFIN_PLN_CODIGO = new lib.Visual.Components.sknLabel();
      this.lblFIN_DOCUMENTO = new lib.Visual.Components.sknLabel();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.lblFIN_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.lblFIN_EMISSAO = new lib.Visual.Components.sknLabel();
      this.lblFIN_VENCIMENTO = new lib.Visual.Components.sknLabel();
      this.lblFIN_VALOR = new lib.Visual.Components.sknLabel();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.cmbPlanoContas = new lib.Visual.Components.sknComboBox();
      this.dtEmissao = new System.Windows.Forms.DateTimePicker();
      this.dtVencimento = new System.Windows.Forms.DateTimePicker();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtContato = new lib.Visual.Components.sknTextBox();
      this.btnContato = new lib.Visual.Components.sknButton();
      this.cbBaixado = new lib.Visual.Components.sknCheckBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.cbBaixado);
      this.pnlEdit.Controls.Add(this.btnContato);
      this.pnlEdit.Controls.Add(this.txtContato);
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Controls.Add(this.dtVencimento);
      this.pnlEdit.Controls.Add(this.dtEmissao);
      this.pnlEdit.Controls.Add(this.cmbPlanoContas);
      this.pnlEdit.Controls.Add(this.lblFIN_PLN_CODIGO);
      this.pnlEdit.Controls.Add(this.lblFIN_DOCUMENTO);
      this.pnlEdit.Controls.Add(this.txtDocumento);
      this.pnlEdit.Controls.Add(this.lblFIN_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtDescricao);
      this.pnlEdit.Controls.Add(this.lblFIN_EMISSAO);
      this.pnlEdit.Controls.Add(this.lblFIN_VENCIMENTO);
      this.pnlEdit.Controls.Add(this.lblFIN_VALOR);
      this.pnlEdit.Controls.Add(this.txtValor);
      this.pnlEdit.Size = new System.Drawing.Size(475, 202);
      // 
      // lblFIN_PLN_CODIGO
      // 
      this.lblFIN_PLN_CODIGO.AutoSize = true;
      this.lblFIN_PLN_CODIGO.Location = new System.Drawing.Point(12, 3);
      this.lblFIN_PLN_CODIGO.Name = "lblFIN_PLN_CODIGO";
      this.lblFIN_PLN_CODIGO.Size = new System.Drawing.Size(85, 13);
      this.lblFIN_PLN_CODIGO.TabIndex = 0;
      this.lblFIN_PLN_CODIGO.Text = "Plano de Contas";
      // 
      // lblFIN_DOCUMENTO
      // 
      this.lblFIN_DOCUMENTO.AutoSize = true;
      this.lblFIN_DOCUMENTO.Location = new System.Drawing.Point(258, 3);
      this.lblFIN_DOCUMENTO.Name = "lblFIN_DOCUMENTO";
      this.lblFIN_DOCUMENTO.Size = new System.Drawing.Size(62, 13);
      this.lblFIN_DOCUMENTO.TabIndex = 2;
      this.lblFIN_DOCUMENTO.Text = "Documento";
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
      this.txtDocumento.Location = new System.Drawing.Point(258, 19);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(204, 20);
      this.txtDocumento.TabIndex = 3;
      this.txtDocumento.TextFormat = null;
      this.txtDocumento.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblFIN_DESCRICAO
      // 
      this.lblFIN_DESCRICAO.AutoSize = true;
      this.lblFIN_DESCRICAO.Location = new System.Drawing.Point(12, 82);
      this.lblFIN_DESCRICAO.Name = "lblFIN_DESCRICAO";
      this.lblFIN_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblFIN_DESCRICAO.TabIndex = 7;
      this.lblFIN_DESCRICAO.Text = "Descrição";
      // 
      // txtDescricao
      // 
      this.txtDescricao.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDescricao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDescricao.AutoTab = true;
      this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescricao.Location = new System.Drawing.Point(12, 98);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(450, 20);
      this.txtDescricao.TabIndex = 8;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblFIN_EMISSAO
      // 
      this.lblFIN_EMISSAO.AutoSize = true;
      this.lblFIN_EMISSAO.Location = new System.Drawing.Point(12, 121);
      this.lblFIN_EMISSAO.Name = "lblFIN_EMISSAO";
      this.lblFIN_EMISSAO.Size = new System.Drawing.Size(46, 13);
      this.lblFIN_EMISSAO.TabIndex = 9;
      this.lblFIN_EMISSAO.Text = "Emissão";
      // 
      // lblFIN_VENCIMENTO
      // 
      this.lblFIN_VENCIMENTO.AutoSize = true;
      this.lblFIN_VENCIMENTO.Location = new System.Drawing.Point(161, 121);
      this.lblFIN_VENCIMENTO.Name = "lblFIN_VENCIMENTO";
      this.lblFIN_VENCIMENTO.Size = new System.Drawing.Size(63, 13);
      this.lblFIN_VENCIMENTO.TabIndex = 11;
      this.lblFIN_VENCIMENTO.Text = "Vencimento";
      // 
      // lblFIN_VALOR
      // 
      this.lblFIN_VALOR.AutoSize = true;
      this.lblFIN_VALOR.Location = new System.Drawing.Point(313, 121);
      this.lblFIN_VALOR.Name = "lblFIN_VALOR";
      this.lblFIN_VALOR.Size = new System.Drawing.Size(103, 13);
      this.lblFIN_VALOR.TabIndex = 13;
      this.lblFIN_VALOR.Text = "Valor (F2 expressão)";
      // 
      // txtValor
      // 
      this.txtValor.AsDateTime = new System.DateTime(((long)(0)));
      this.txtValor.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtValor.AutoTab = true;
      this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtValor.Location = new System.Drawing.Point(316, 137);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(146, 20);
      this.txtValor.TabIndex = 14;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFIN_VALOR_KeyDown);
      // 
      // cmbPlanoContas
      // 
      this.cmbPlanoContas.AutoTab = true;
      this.cmbPlanoContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPlanoContas.FormattingEnabled = true;
      this.cmbPlanoContas.Location = new System.Drawing.Point(12, 19);
      this.cmbPlanoContas.Name = "cmbPlanoContas";
      this.cmbPlanoContas.Size = new System.Drawing.Size(240, 21);
      this.cmbPlanoContas.TabIndex = 1;
      // 
      // dtEmissao
      // 
      this.dtEmissao.CustomFormat = "dd/MM/yyyy";
      this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtEmissao.Location = new System.Drawing.Point(12, 137);
      this.dtEmissao.Name = "dtEmissao";
      this.dtEmissao.Size = new System.Drawing.Size(146, 20);
      this.dtEmissao.TabIndex = 10;
      // 
      // dtVencimento
      // 
      this.dtVencimento.CustomFormat = "dd/MM/yyyy";
      this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtVencimento.Location = new System.Drawing.Point(164, 137);
      this.dtVencimento.Name = "dtVencimento";
      this.dtVencimento.Size = new System.Drawing.Size(146, 20);
      this.dtVencimento.TabIndex = 12;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 43);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(44, 13);
      this.sknLabel1.TabIndex = 4;
      this.sknLabel1.Text = "Contato";
      // 
      // txtContato
      // 
      this.txtContato.AsDateTime = new System.DateTime(((long)(0)));
      this.txtContato.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtContato.AutoTab = true;
      this.txtContato.Enabled = false;
      this.txtContato.Location = new System.Drawing.Point(12, 59);
      this.txtContato.Name = "txtContato";
      this.txtContato.Size = new System.Drawing.Size(419, 20);
      this.txtContato.TabIndex = 5;
      this.txtContato.TextFormat = null;
      this.txtContato.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // btnContato
      // 
      this.btnContato.Location = new System.Drawing.Point(437, 57);
      this.btnContato.Name = "btnContato";
      this.btnContato.Size = new System.Drawing.Size(25, 23);
      this.btnContato.TabIndex = 6;
      this.btnContato.Text = "...";
      this.btnContato.UseVisualStyleBackColor = true;
      this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
      // 
      // cbBaixado
      // 
      this.cbBaixado.Location = new System.Drawing.Point(12, 163);
      this.cbBaixado.Name = "cbBaixado";
      this.cbBaixado.Size = new System.Drawing.Size(256, 24);
      this.cbBaixado.TabIndex = 15;
      this.cbBaixado.Text = "Realizar lançamento como baixado";
      this.cbBaixado.UseVisualStyleBackColor = true;
      // 
      // frmFinanceiro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 282);
      this.Name = "frmFinanceiro";
      this.Text = "Financeiro";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblFIN_PLN_CODIGO;
    private lib.Visual.Components.sknLabel lblFIN_DOCUMENTO;
    private lib.Visual.Components.sknTextBox txtDocumento;
    private lib.Visual.Components.sknLabel lblFIN_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknLabel lblFIN_EMISSAO;
    private lib.Visual.Components.sknLabel lblFIN_VENCIMENTO;
    private lib.Visual.Components.sknLabel lblFIN_VALOR;
    private lib.Visual.Components.sknTextBox txtValor;
    private lib.Visual.Components.sknComboBox cmbPlanoContas;
    private System.Windows.Forms.DateTimePicker dtVencimento;
    private System.Windows.Forms.DateTimePicker dtEmissao;
    private lib.Visual.Components.sknButton btnContato;
    private lib.Visual.Components.sknTextBox txtContato;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknCheckBox cbBaixado;
  }
}
