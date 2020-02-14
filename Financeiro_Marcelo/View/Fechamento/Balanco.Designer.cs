namespace Financeiro_Marcelo.Fechamento
{
  partial class Balanco
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
      this.txtEstoqueFinal = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtEstoqueInicial = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtCompras = new lib.Visual.Components.sknTextBox();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.txtCMV = new lib.Visual.Components.sknTextBox();
      this.sknLabel6 = new lib.Visual.Components.sknLabel();
      this.cmbFechamentoAnterior = new lib.Visual.Components.sknComboBox();
      this.sknLabel7 = new lib.Visual.Components.sknLabel();
      this.txtApuracao = new lib.Visual.Components.sknMaskedTextBox();
      this.cmbEmpresas = new lib.Visual.Components.sknComboBox();
      this.sknLabel8 = new lib.Visual.Components.sknLabel();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.sknButton1);
      this.pnlContext.Controls.Add(this.cmbEmpresas);
      this.pnlContext.Controls.Add(this.sknLabel8);
      this.pnlContext.Controls.Add(this.txtApuracao);
      this.pnlContext.Controls.Add(this.sknLabel7);
      this.pnlContext.Controls.Add(this.cmbFechamentoAnterior);
      this.pnlContext.Controls.Add(this.txtCMV);
      this.pnlContext.Controls.Add(this.sknLabel6);
      this.pnlContext.Controls.Add(this.txtCompras);
      this.pnlContext.Controls.Add(this.sknLabel5);
      this.pnlContext.Controls.Add(this.txtEstoqueFinal);
      this.pnlContext.Controls.Add(this.sknLabel4);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.txtEstoqueInicial);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(337, 233);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 233);
      this.pnlBottom.Size = new System.Drawing.Size(337, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(129, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(225, 8);
      // 
      // txtEstoqueFinal
      // 
      this.txtEstoqueFinal.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEstoqueFinal.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEstoqueFinal.AutoTab = true;
      this.txtEstoqueFinal.Location = new System.Drawing.Point(183, 105);
      this.txtEstoqueFinal.Name = "txtEstoqueFinal";
      this.txtEstoqueFinal.Size = new System.Drawing.Size(141, 20);
      this.txtEstoqueFinal.TabIndex = 9;
      this.txtEstoqueFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtEstoqueFinal.TextFormat = "#,##0.00";
      this.txtEstoqueFinal.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtEstoqueFinal.TextChanged += new System.EventHandler(this.txtEstoqueFinal_TextChanged);
      this.txtEstoqueFinal.Leave += new System.EventHandler(this.txtEstoqueFinal_Leave);
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(180, 89);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(71, 13);
      this.sknLabel4.TabIndex = 8;
      this.sknLabel4.Text = "Estoque Final";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 89);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(53, 13);
      this.sknLabel3.TabIndex = 6;
      this.sknLabel3.Text = "Apuração";
      // 
      // txtEstoqueInicial
      // 
      this.txtEstoqueInicial.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEstoqueInicial.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEstoqueInicial.AutoTab = true;
      this.txtEstoqueInicial.Enabled = false;
      this.txtEstoqueInicial.Location = new System.Drawing.Point(183, 66);
      this.txtEstoqueInicial.Name = "txtEstoqueInicial";
      this.txtEstoqueInicial.Size = new System.Drawing.Size(141, 20);
      this.txtEstoqueInicial.TabIndex = 5;
      this.txtEstoqueInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtEstoqueInicial.TextFormat = "#,##0.00";
      this.txtEstoqueInicial.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(183, 49);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(76, 13);
      this.sknLabel2.TabIndex = 4;
      this.sknLabel2.Text = "Estoque Inicial";
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 49);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(105, 13);
      this.sknLabel1.TabIndex = 2;
      this.sknLabel1.Text = "Fechamento Anterior";
      // 
      // txtCompras
      // 
      this.txtCompras.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCompras.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCompras.AutoTab = true;
      this.txtCompras.Enabled = false;
      this.txtCompras.Location = new System.Drawing.Point(183, 144);
      this.txtCompras.Name = "txtCompras";
      this.txtCompras.Size = new System.Drawing.Size(141, 20);
      this.txtCompras.TabIndex = 11;
      this.txtCompras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCompras.TextFormat = "#,##0.00";
      this.txtCompras.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(183, 128);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(103, 13);
      this.sknLabel5.TabIndex = 10;
      this.sknLabel5.Text = "Compras do período";
      // 
      // txtCMV
      // 
      this.txtCMV.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCMV.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCMV.AutoTab = true;
      this.txtCMV.Enabled = false;
      this.txtCMV.Location = new System.Drawing.Point(183, 183);
      this.txtCMV.Name = "txtCMV";
      this.txtCMV.Size = new System.Drawing.Size(141, 20);
      this.txtCMV.TabIndex = 13;
      this.txtCMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCMV.TextFormat = "#,##0.00";
      this.txtCMV.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel6
      // 
      this.sknLabel6.AutoSize = true;
      this.sknLabel6.Location = new System.Drawing.Point(183, 167);
      this.sknLabel6.Name = "sknLabel6";
      this.sknLabel6.Size = new System.Drawing.Size(30, 13);
      this.sknLabel6.TabIndex = 12;
      this.sknLabel6.Text = "CMV";
      // 
      // cmbFechamentoAnterior
      // 
      this.cmbFechamentoAnterior.AutoTab = true;
      this.cmbFechamentoAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbFechamentoAnterior.FormattingEnabled = true;
      this.cmbFechamentoAnterior.Location = new System.Drawing.Point(12, 65);
      this.cmbFechamentoAnterior.Name = "cmbFechamentoAnterior";
      this.cmbFechamentoAnterior.Size = new System.Drawing.Size(165, 21);
      this.cmbFechamentoAnterior.TabIndex = 3;
      this.cmbFechamentoAnterior.SelectedIndexChanged += new System.EventHandler(this.cmbFechamentoAnterior_SelectedIndexChanged);
      // 
      // sknLabel7
      // 
      this.sknLabel7.AutoSize = true;
      this.sknLabel7.Location = new System.Drawing.Point(9, 206);
      this.sknLabel7.Name = "sknLabel7";
      this.sknLabel7.Size = new System.Drawing.Size(313, 13);
      this.sknLabel7.TabIndex = 14;
      this.sknLabel7.Text = "Obs.: CVM = (Total de Compras + Estoque Inicial) - Estoque Final";
      // 
      // txtApuracao
      // 
      this.txtApuracao.AsDateTime = new System.DateTime(2011, 7, 3, 0, 0, 0, 0);
      this.txtApuracao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtApuracao.AutoTab = true;
      this.txtApuracao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtApuracao.Location = new System.Drawing.Point(12, 105);
      this.txtApuracao.Mask = "00/00/0000";
      this.txtApuracao.Name = "txtApuracao";
      this.txtApuracao.Size = new System.Drawing.Size(165, 20);
      this.txtApuracao.TabIndex = 7;
      this.txtApuracao.Text = "03072011";
      this.txtApuracao.TextFormat = "dd/MM/yyyy";
      this.txtApuracao.TextType = lib.Visual.Components.enmTextType.DateTime;
      this.txtApuracao.ValidatingType = typeof(System.DateTime);
      this.txtApuracao.Leave += new System.EventHandler(this.txtApuracao_Leave);
      // 
      // cmbEmpresas
      // 
      this.cmbEmpresas.AutoTab = true;
      this.cmbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresas.FormattingEnabled = true;
      this.cmbEmpresas.Location = new System.Drawing.Point(12, 25);
      this.cmbEmpresas.Name = "cmbEmpresas";
      this.cmbEmpresas.Size = new System.Drawing.Size(165, 21);
      this.cmbEmpresas.TabIndex = 1;
      this.cmbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresas_SelectedIndexChanged);
      // 
      // sknLabel8
      // 
      this.sknLabel8.AutoSize = true;
      this.sknLabel8.Location = new System.Drawing.Point(12, 9);
      this.sknLabel8.Name = "sknLabel8";
      this.sknLabel8.Size = new System.Drawing.Size(48, 13);
      this.sknLabel8.TabIndex = 0;
      this.sknLabel8.Text = "Empresa";
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(183, 23);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(141, 23);
      this.sknButton1.TabIndex = 15;
      this.sknButton1.Text = "Manutenção";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // Balanco
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(337, 278);
      this.Name = "Balanco";
      this.Text = "Balanço";
      this.Load += new System.EventHandler(this.Balanco_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtCMV;
    private lib.Visual.Components.sknLabel sknLabel6;
    private lib.Visual.Components.sknTextBox txtCompras;
    private lib.Visual.Components.sknLabel sknLabel5;
    private lib.Visual.Components.sknTextBox txtEstoqueFinal;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknTextBox txtEstoqueInicial;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknComboBox cmbFechamentoAnterior;
    private lib.Visual.Components.sknLabel sknLabel7;
    private lib.Visual.Components.sknMaskedTextBox txtApuracao;
    private lib.Visual.Components.sknComboBox cmbEmpresas;
    private lib.Visual.Components.sknLabel sknLabel8;
    private lib.Visual.Components.sknButton sknButton1;

  }
}