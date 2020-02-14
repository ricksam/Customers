namespace Financeiro_Marcelo
{
  partial class CadastroContas
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
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtConta = new lib.Visual.Components.sknTextBox();
      this.sknLabel10 = new lib.Visual.Components.sknLabel();
      this.txtAgencia = new lib.Visual.Components.sknTextBox();
      this.sknLabel9 = new lib.Visual.Components.sknLabel();
      this.txtBanco = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtSaldo = new lib.Visual.Components.sknTextBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.txtSaldo);
      this.pnlEdit.Controls.Add(this.sknLabel3);
      this.pnlEdit.Controls.Add(this.txtBanco);
      this.pnlEdit.Controls.Add(this.sknLabel2);
      this.pnlEdit.Controls.Add(this.txtConta);
      this.pnlEdit.Controls.Add(this.sknLabel10);
      this.pnlEdit.Controls.Add(this.txtAgencia);
      this.pnlEdit.Controls.Add(this.sknLabel9);
      this.pnlEdit.Controls.Add(this.cmbEmpresa);
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Size = new System.Drawing.Size(475, 141);
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(12, 19);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(190, 21);
      this.cmbEmpresa.TabIndex = 1;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 3);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(48, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Empresa";
      // 
      // txtConta
      // 
      this.txtConta.AsDateTime = new System.DateTime(((long)(0)));
      this.txtConta.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtConta.AutoTab = true;
      this.txtConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtConta.Location = new System.Drawing.Point(315, 66);
      this.txtConta.Name = "txtConta";
      this.txtConta.Size = new System.Drawing.Size(147, 20);
      this.txtConta.TabIndex = 7;
      this.txtConta.TextFormat = null;
      this.txtConta.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel10
      // 
      this.sknLabel10.AutoSize = true;
      this.sknLabel10.Location = new System.Drawing.Point(315, 50);
      this.sknLabel10.Name = "sknLabel10";
      this.sknLabel10.Size = new System.Drawing.Size(35, 13);
      this.sknLabel10.TabIndex = 6;
      this.sknLabel10.Text = "Conta";
      // 
      // txtAgencia
      // 
      this.txtAgencia.AsDateTime = new System.DateTime(((long)(0)));
      this.txtAgencia.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAgencia.AutoTab = true;
      this.txtAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtAgencia.Location = new System.Drawing.Point(208, 66);
      this.txtAgencia.Name = "txtAgencia";
      this.txtAgencia.Size = new System.Drawing.Size(100, 20);
      this.txtAgencia.TabIndex = 5;
      this.txtAgencia.TextFormat = null;
      this.txtAgencia.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel9
      // 
      this.sknLabel9.AutoSize = true;
      this.sknLabel9.Location = new System.Drawing.Point(209, 50);
      this.sknLabel9.Name = "sknLabel9";
      this.sknLabel9.Size = new System.Drawing.Size(46, 13);
      this.sknLabel9.TabIndex = 4;
      this.sknLabel9.Text = "Agencia";
      // 
      // txtBanco
      // 
      this.txtBanco.AsDateTime = new System.DateTime(((long)(0)));
      this.txtBanco.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtBanco.AutoTab = true;
      this.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtBanco.Location = new System.Drawing.Point(12, 66);
      this.txtBanco.Name = "txtBanco";
      this.txtBanco.Size = new System.Drawing.Size(190, 20);
      this.txtBanco.TabIndex = 3;
      this.txtBanco.TextFormat = null;
      this.txtBanco.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 50);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(38, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Banco";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 89);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(34, 13);
      this.sknLabel3.TabIndex = 8;
      this.sknLabel3.Text = "Saldo";
      // 
      // txtSaldo
      // 
      this.txtSaldo.AsDateTime = new System.DateTime(((long)(0)));
      this.txtSaldo.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtSaldo.AutoTab = true;
      this.txtSaldo.Enabled = false;
      this.txtSaldo.Location = new System.Drawing.Point(12, 105);
      this.txtSaldo.Name = "txtSaldo";
      this.txtSaldo.Size = new System.Drawing.Size(190, 20);
      this.txtSaldo.TabIndex = 9;
      this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtSaldo.TextFormat = "#,##0.00";
      this.txtSaldo.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // CadastroContas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 221);
      this.Name = "CadastroContas";
      this.Text = "CadastroContas";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.CadastroContas_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtBanco;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtConta;
    private lib.Visual.Components.sknLabel sknLabel10;
    private lib.Visual.Components.sknTextBox txtAgencia;
    private lib.Visual.Components.sknLabel sknLabel9;
    private lib.Visual.Components.sknTextBox txtSaldo;
    private lib.Visual.Components.sknLabel sknLabel3;
  }
}