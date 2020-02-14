namespace Financeiro_Marcelo.View.Cartoes
{
  partial class BaixaCartoesParcial
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
      this.txtCartao = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEmissao = new lib.Visual.Components.sknTextBox();
      this.txtVencimento = new lib.Visual.Components.sknTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtRestante = new lib.Visual.Components.sknTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtRestante);
      this.pnlContext.Controls.Add(this.label5);
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.label4);
      this.pnlContext.Controls.Add(this.txtVencimento);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtEmissao);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.txtCartao);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(323, 134);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 134);
      this.pnlBottom.Size = new System.Drawing.Size(323, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(115, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(211, 8);
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
      // txtCartao
      // 
      this.txtCartao.Enabled = false;
      this.txtCartao.Location = new System.Drawing.Point(12, 25);
      this.txtCartao.Name = "txtCartao";
      this.txtCartao.Size = new System.Drawing.Size(298, 20);
      this.txtCartao.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Emissão";
      // 
      // txtEmissao
      // 
      this.txtEmissao.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEmissao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEmissao.AutoTab = true;
      this.txtEmissao.Enabled = false;
      this.txtEmissao.Location = new System.Drawing.Point(12, 64);
      this.txtEmissao.Name = "txtEmissao";
      this.txtEmissao.Size = new System.Drawing.Size(146, 20);
      this.txtEmissao.TabIndex = 3;
      this.txtEmissao.TextFormat = "dd/MM/yyyy";
      this.txtEmissao.TextType = lib.Visual.Components.enmTextType.DateTime;
      // 
      // txtVencimento
      // 
      this.txtVencimento.AsDateTime = new System.DateTime(((long)(0)));
      this.txtVencimento.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtVencimento.AutoTab = true;
      this.txtVencimento.Enabled = false;
      this.txtVencimento.Location = new System.Drawing.Point(164, 64);
      this.txtVencimento.Name = "txtVencimento";
      this.txtVencimento.Size = new System.Drawing.Size(146, 20);
      this.txtVencimento.TabIndex = 5;
      this.txtVencimento.TextFormat = "dd/MM/yyyy";
      this.txtVencimento.TextType = lib.Visual.Components.enmTextType.DateTime;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(164, 48);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Vencimento";
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
      this.txtValor.Location = new System.Drawing.Point(12, 103);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(146, 20);
      this.txtValor.TabIndex = 7;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 87);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Valor";
      // 
      // txtRestante
      // 
      this.txtRestante.AsDateTime = new System.DateTime(((long)(0)));
      this.txtRestante.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtRestante.AutoTab = true;
      this.txtRestante.Enabled = false;
      this.txtRestante.Location = new System.Drawing.Point(164, 103);
      this.txtRestante.Name = "txtRestante";
      this.txtRestante.Size = new System.Drawing.Size(146, 20);
      this.txtRestante.TabIndex = 9;
      this.txtRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtRestante.TextFormat = "#,##0.00";
      this.txtRestante.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(164, 87);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(50, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Restante";
      // 
      // BaixaCartoesParcial
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 179);
      this.Name = "BaixaCartoesParcial";
      this.Text = "Baixa Parcial";
      this.Load += new System.EventHandler(this.BaixaCartoesParcial_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtRestante;
    private System.Windows.Forms.Label label5;
    private lib.Visual.Components.sknTextBox txtValor;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknTextBox txtVencimento;
    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknTextBox txtEmissao;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCartao;
    private System.Windows.Forms.Label label1;
  }
}