namespace Folha_Marcelo.FORMS
{
  partial class frmLancResumo
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
      this.label3 = new System.Windows.Forms.Label();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.cmbReferencia = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbOperacao = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.cmbReferencia);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.cmbOperacao);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(292, 138);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 138);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(84, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(180, 8);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 89);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Valor (F2 Expressão)";
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
      this.txtValor.Location = new System.Drawing.Point(12, 105);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(258, 20);
      this.txtValor.TabIndex = 5;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
      // 
      // cmbReferencia
      // 
      this.cmbReferencia.FormattingEnabled = true;
      this.cmbReferencia.Location = new System.Drawing.Point(12, 65);
      this.cmbReferencia.Name = "cmbReferencia";
      this.cmbReferencia.Size = new System.Drawing.Size(258, 21);
      this.cmbReferencia.TabIndex = 3;
      this.cmbReferencia.TextChanged += new System.EventHandler(this.cmbReferencia_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Referência";
      // 
      // cmbOperacao
      // 
      this.cmbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOperacao.FormattingEnabled = true;
      this.cmbOperacao.Location = new System.Drawing.Point(12, 25);
      this.cmbOperacao.Name = "cmbOperacao";
      this.cmbOperacao.Size = new System.Drawing.Size(258, 21);
      this.cmbOperacao.TabIndex = 1;
      this.cmbOperacao.SelectedIndexChanged += new System.EventHandler(this.cmbOperacao_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Operação";
      // 
      // frmLancResumo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 183);
      this.Name = "frmLancResumo";
      this.Text = "Lançamento";
      this.Load += new System.EventHandler(this.frmLancResumo_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknTextBox txtValor;
    private System.Windows.Forms.ComboBox cmbReferencia;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbOperacao;
    private System.Windows.Forms.Label label1;
  }
}