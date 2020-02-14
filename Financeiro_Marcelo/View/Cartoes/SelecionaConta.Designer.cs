namespace Financeiro_Marcelo.View.Cartoes
{
  partial class SelecionaConta
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
      this.cmbContas = new lib.Visual.Components.sknComboBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.cmbContas);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(351, 96);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 96);
      this.pnlBottom.Size = new System.Drawing.Size(351, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(143, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(239, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(35, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Conta";
      // 
      // cmbContas
      // 
      this.cmbContas.AutoTab = true;
      this.cmbContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbContas.FormattingEnabled = true;
      this.cmbContas.Location = new System.Drawing.Point(12, 25);
      this.cmbContas.Name = "cmbContas";
      this.cmbContas.Size = new System.Drawing.Size(325, 21);
      this.cmbContas.TabIndex = 1;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 49);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(31, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Valor";
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
      this.txtValor.Enabled = false;
      this.txtValor.Location = new System.Drawing.Point(12, 65);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(166, 20);
      this.txtValor.TabIndex = 3;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // SelecionaConta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(351, 141);
      this.Name = "SelecionaConta";
      this.Text = "Seleciona Conta";
      this.Load += new System.EventHandler(this.SelecionaConta_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtValor;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknComboBox cmbContas;
  }
}