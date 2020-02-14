namespace Financeiro_Marcelo.View.Cartoes
{
  partial class ItemCartoes
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
      this.label1 = new System.Windows.Forms.Label();
      this.cmbCartao = new lib.Visual.Components.sknComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.cmbCartao);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(409, 61);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 61);
      this.pnlBottom.Size = new System.Drawing.Size(409, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(201, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(297, 8);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Cartão";
      // 
      // cmbCartao
      // 
      this.cmbCartao.AutoTab = true;
      this.cmbCartao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCartao.FormattingEnabled = true;
      this.cmbCartao.Location = new System.Drawing.Point(12, 25);
      this.cmbCartao.Name = "cmbCartao";
      this.cmbCartao.Size = new System.Drawing.Size(239, 21);
      this.cmbCartao.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(257, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(31, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Valor";
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
      this.txtValor.Location = new System.Drawing.Point(257, 25);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(140, 20);
      this.txtValor.TabIndex = 3;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
      // 
      // ItemCartoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 106);
      this.Name = "ItemCartoes";
      this.Text = "Cartão";
      this.Load += new System.EventHandler(this.ItemCartoes_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtValor;
    private System.Windows.Forms.Label label2;
    private lib.Visual.Components.sknComboBox cmbCartao;
    private System.Windows.Forms.Label label1;
  }
}