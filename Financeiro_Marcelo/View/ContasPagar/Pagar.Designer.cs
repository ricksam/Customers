namespace Financeiro_Marcelo
{
  partial class Pagar
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
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtEmpresa = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.cmbConta = new lib.Visual.Components.sknComboBox();
      this.txtNrCheque = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtValorTotal = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.sknGroupBox1 = new lib.Visual.Components.sknGroupBox();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.rbOutra = new lib.Visual.Components.sknRadioButton();
      this.rbCheque = new lib.Visual.Components.sknRadioButton();
      this.txtDataBaixa = new lib.Visual.Components.sknTextBox();
      this.sknLabel6 = new lib.Visual.Components.sknLabel();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.sknGroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtDataBaixa);
      this.pnlContext.Controls.Add(this.sknLabel6);
      this.pnlContext.Controls.Add(this.sknGroupBox1);
      this.pnlContext.Controls.Add(this.txtValorTotal);
      this.pnlContext.Controls.Add(this.sknLabel4);
      this.pnlContext.Controls.Add(this.txtEmpresa);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(519, 326);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 326);
      this.pnlBottom.Size = new System.Drawing.Size(519, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(311, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(407, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(48, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Empresa";
      // 
      // txtEmpresa
      // 
      this.txtEmpresa.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEmpresa.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEmpresa.AutoTab = true;
      this.txtEmpresa.Enabled = false;
      this.txtEmpresa.Location = new System.Drawing.Point(12, 25);
      this.txtEmpresa.Name = "txtEmpresa";
      this.txtEmpresa.Size = new System.Drawing.Size(149, 20);
      this.txtEmpresa.TabIndex = 1;
      this.txtEmpresa.TextFormat = null;
      this.txtEmpresa.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(132, 64);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(35, 13);
      this.sknLabel2.TabIndex = 4;
      this.sknLabel2.Text = "Conta";
      // 
      // cmbConta
      // 
      this.cmbConta.AutoTab = true;
      this.cmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbConta.FormattingEnabled = true;
      this.cmbConta.Location = new System.Drawing.Point(135, 82);
      this.cmbConta.Name = "cmbConta";
      this.cmbConta.Size = new System.Drawing.Size(325, 21);
      this.cmbConta.TabIndex = 5;
      this.cmbConta.SelectedIndexChanged += new System.EventHandler(this.cmbConta_SelectedIndexChanged);
      // 
      // txtNrCheque
      // 
      this.txtNrCheque.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNrCheque.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNrCheque.AutoTab = true;
      this.txtNrCheque.Enabled = false;
      this.txtNrCheque.Location = new System.Drawing.Point(135, 41);
      this.txtNrCheque.Name = "txtNrCheque";
      this.txtNrCheque.Size = new System.Drawing.Size(192, 20);
      this.txtNrCheque.TabIndex = 3;
      this.txtNrCheque.TabStop = false;
      this.txtNrCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtNrCheque.TextFormat = null;
      this.txtNrCheque.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(132, 25);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(61, 13);
      this.sknLabel3.TabIndex = 2;
      this.sknLabel3.Text = "Nr. Cheque";
      // 
      // txtValorTotal
      // 
      this.txtValorTotal.AsDateTime = new System.DateTime(((long)(0)));
      this.txtValorTotal.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtValorTotal.AutoTab = true;
      this.txtValorTotal.Enabled = false;
      this.txtValorTotal.Location = new System.Drawing.Point(336, 288);
      this.txtValorTotal.Name = "txtValorTotal";
      this.txtValorTotal.Size = new System.Drawing.Size(149, 20);
      this.txtValorTotal.TabIndex = 6;
      this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValorTotal.TextFormat = "#,##0.00";
      this.txtValorTotal.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(333, 272);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(58, 13);
      this.sknLabel4.TabIndex = 5;
      this.sknLabel4.Text = "Valor Total";
      // 
      // sknGroupBox1
      // 
      this.sknGroupBox1.Controls.Add(this.txtDescricao);
      this.sknGroupBox1.Controls.Add(this.sknLabel5);
      this.sknGroupBox1.Controls.Add(this.rbOutra);
      this.sknGroupBox1.Controls.Add(this.rbCheque);
      this.sknGroupBox1.Controls.Add(this.sknLabel3);
      this.sknGroupBox1.Controls.Add(this.cmbConta);
      this.sknGroupBox1.Controls.Add(this.txtNrCheque);
      this.sknGroupBox1.Controls.Add(this.sknLabel2);
      this.sknGroupBox1.Location = new System.Drawing.Point(12, 51);
      this.sknGroupBox1.Name = "sknGroupBox1";
      this.sknGroupBox1.Size = new System.Drawing.Size(473, 209);
      this.sknGroupBox1.TabIndex = 2;
      this.sknGroupBox1.TabStop = false;
      this.sknGroupBox1.Text = "Tipo Pagamento";
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
      this.txtDescricao.Location = new System.Drawing.Point(135, 153);
      this.txtDescricao.Multiline = true;
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(325, 41);
      this.txtDescricao.TabIndex = 7;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(132, 137);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(55, 13);
      this.sknLabel5.TabIndex = 6;
      this.sknLabel5.Text = "Descrição";
      // 
      // rbOutra
      // 
      this.rbOutra.Location = new System.Drawing.Point(6, 137);
      this.rbOutra.Name = "rbOutra";
      this.rbOutra.Size = new System.Drawing.Size(104, 24);
      this.rbOutra.TabIndex = 1;
      this.rbOutra.Text = "Outra";
      this.rbOutra.UseVisualStyleBackColor = true;
      this.rbOutra.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // rbCheque
      // 
      this.rbCheque.Checked = true;
      this.rbCheque.Location = new System.Drawing.Point(6, 19);
      this.rbCheque.Name = "rbCheque";
      this.rbCheque.Size = new System.Drawing.Size(104, 24);
      this.rbCheque.TabIndex = 0;
      this.rbCheque.TabStop = true;
      this.rbCheque.Text = "Cheque";
      this.rbCheque.UseVisualStyleBackColor = true;
      this.rbCheque.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
      // 
      // txtDataBaixa
      // 
      this.txtDataBaixa.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDataBaixa.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDataBaixa.AutoTab = true;
      this.txtDataBaixa.Location = new System.Drawing.Point(181, 288);
      this.txtDataBaixa.Name = "txtDataBaixa";
      this.txtDataBaixa.Size = new System.Drawing.Size(149, 20);
      this.txtDataBaixa.TabIndex = 4;
      this.txtDataBaixa.TextFormat = "dd/MM/yyyy";
      this.txtDataBaixa.TextType = lib.Visual.Components.enmTextType.DateTime;
      // 
      // sknLabel6
      // 
      this.sknLabel6.AutoSize = true;
      this.sknLabel6.Location = new System.Drawing.Point(178, 272);
      this.sknLabel6.Name = "sknLabel6";
      this.sknLabel6.Size = new System.Drawing.Size(74, 13);
      this.sknLabel6.TabIndex = 3;
      this.sknLabel6.Text = "Data da Baixa";
      // 
      // Pagar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 371);
      this.Name = "Pagar";
      this.Text = "Pagar";
      this.Load += new System.EventHandler(this.Pagar_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.sknGroupBox1.ResumeLayout(false);
      this.sknGroupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtEmpresa;
    private lib.Visual.Components.sknTextBox txtNrCheque;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknComboBox cmbConta;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtValorTotal;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknGroupBox sknGroupBox1;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknLabel sknLabel5;
    private lib.Visual.Components.sknRadioButton rbOutra;
    private lib.Visual.Components.sknRadioButton rbCheque;
    private lib.Visual.Components.sknTextBox txtDataBaixa;
    private lib.Visual.Components.sknLabel sknLabel6;
  }
}