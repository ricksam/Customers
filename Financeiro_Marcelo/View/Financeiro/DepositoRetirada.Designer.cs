namespace Financeiro_Marcelo.View
{
  partial class DepositoRetirada
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
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.cmbTipo = new lib.Visual.Components.sknComboBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.cmbTipo);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.txtDescricao);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(416, 143);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 143);
      this.pnlBottom.Size = new System.Drawing.Size(416, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(208, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(304, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(55, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Descrição";
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
      this.txtDescricao.Location = new System.Drawing.Point(12, 25);
      this.txtDescricao.MaxLength = 60;
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(382, 20);
      this.txtDescricao.TabIndex = 1;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 48);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(28, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Tipo";
      // 
      // cmbTipo
      // 
      this.cmbTipo.AutoTab = true;
      this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Location = new System.Drawing.Point(12, 64);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new System.Drawing.Size(165, 21);
      this.cmbTipo.TabIndex = 3;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 88);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(104, 13);
      this.sknLabel3.TabIndex = 4;
      this.sknLabel3.Text = "Valor (F2 Expressão)";
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
      this.txtValor.Location = new System.Drawing.Point(12, 104);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(165, 20);
      this.txtValor.TabIndex = 5;
      this.txtValor.TextFormat = null;
      this.txtValor.TextType = lib.Visual.Components.enmTextType.String;
      this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
      // 
      // DepositoRetirada
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(416, 188);
      this.Name = "DepositoRetirada";
      this.Text = "DepositoRetirada";
      this.Load += new System.EventHandler(this.DepositoRetirada_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknComboBox cmbTipo;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtValor;
    private lib.Visual.Components.sknLabel sknLabel3;
  }
}