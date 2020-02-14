namespace Financeiro_Marcelo
{
  partial class BaixaParcial
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
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.sknLabel6 = new lib.Visual.Components.sknLabel();
      this.sknLabel7 = new lib.Visual.Components.sknLabel();
      this.txtPlanoContas = new lib.Visual.Components.sknTextBox();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.txtEntrada = new lib.Visual.Components.sknTextBox();
      this.txtVencimento = new lib.Visual.Components.sknTextBox();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.txtRestante = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtRestante);
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.txtVencimento);
      this.pnlContext.Controls.Add(this.txtEntrada);
      this.pnlContext.Controls.Add(this.txtDocumento);
      this.pnlContext.Controls.Add(this.txtDescricao);
      this.pnlContext.Controls.Add(this.txtPlanoContas);
      this.pnlContext.Controls.Add(this.sknLabel7);
      this.pnlContext.Controls.Add(this.sknLabel6);
      this.pnlContext.Controls.Add(this.sknLabel5);
      this.pnlContext.Controls.Add(this.sknLabel4);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(356, 178);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 178);
      this.pnlBottom.Size = new System.Drawing.Size(356, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(148, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(244, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(70, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Plano Contas";
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 48);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(55, 13);
      this.sknLabel2.TabIndex = 1;
      this.sknLabel2.Text = "Descrição";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(208, 9);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(62, 13);
      this.sknLabel3.TabIndex = 2;
      this.sknLabel3.Text = "Documento";
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(12, 87);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(44, 13);
      this.sknLabel4.TabIndex = 3;
      this.sknLabel4.Text = "Entrada";
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(153, 87);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(63, 13);
      this.sknLabel5.TabIndex = 4;
      this.sknLabel5.Text = "Vencimento";
      // 
      // sknLabel6
      // 
      this.sknLabel6.AutoSize = true;
      this.sknLabel6.Location = new System.Drawing.Point(12, 126);
      this.sknLabel6.Name = "sknLabel6";
      this.sknLabel6.Size = new System.Drawing.Size(31, 13);
      this.sknLabel6.TabIndex = 5;
      this.sknLabel6.Text = "Valor";
      // 
      // sknLabel7
      // 
      this.sknLabel7.AutoSize = true;
      this.sknLabel7.Location = new System.Drawing.Point(153, 126);
      this.sknLabel7.Name = "sknLabel7";
      this.sknLabel7.Size = new System.Drawing.Size(50, 13);
      this.sknLabel7.TabIndex = 6;
      this.sknLabel7.Text = "Restante";
      // 
      // txtPlanoContas
      // 
      this.txtPlanoContas.AsDateTime = new System.DateTime(((long)(0)));
      this.txtPlanoContas.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtPlanoContas.AutoTab = true;
      this.txtPlanoContas.Enabled = false;
      this.txtPlanoContas.Location = new System.Drawing.Point(12, 25);
      this.txtPlanoContas.Name = "txtPlanoContas";
      this.txtPlanoContas.Size = new System.Drawing.Size(191, 20);
      this.txtPlanoContas.TabIndex = 7;
      this.txtPlanoContas.TextFormat = null;
      this.txtPlanoContas.TextType = lib.Visual.Components.enmTextType.String;
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
      this.txtDescricao.Enabled = false;
      this.txtDescricao.Location = new System.Drawing.Point(12, 64);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(332, 20);
      this.txtDescricao.TabIndex = 8;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
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
      this.txtDocumento.Enabled = false;
      this.txtDocumento.Location = new System.Drawing.Point(209, 25);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(135, 20);
      this.txtDocumento.TabIndex = 9;
      this.txtDocumento.TextFormat = null;
      this.txtDocumento.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtEntrada
      // 
      this.txtEntrada.AsDateTime = new System.DateTime(((long)(0)));
      this.txtEntrada.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtEntrada.AutoTab = true;
      this.txtEntrada.Enabled = false;
      this.txtEntrada.Location = new System.Drawing.Point(12, 103);
      this.txtEntrada.Name = "txtEntrada";
      this.txtEntrada.Size = new System.Drawing.Size(136, 20);
      this.txtEntrada.TabIndex = 10;
      this.txtEntrada.TextFormat = null;
      this.txtEntrada.TextType = lib.Visual.Components.enmTextType.String;
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
      this.txtVencimento.Location = new System.Drawing.Point(154, 103);
      this.txtVencimento.Name = "txtVencimento";
      this.txtVencimento.Size = new System.Drawing.Size(136, 20);
      this.txtVencimento.TabIndex = 11;
      this.txtVencimento.TextFormat = null;
      this.txtVencimento.TextType = lib.Visual.Components.enmTextType.String;
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
      this.txtValor.Location = new System.Drawing.Point(12, 142);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(136, 20);
      this.txtValor.TabIndex = 12;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
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
      this.txtRestante.Location = new System.Drawing.Point(154, 142);
      this.txtRestante.Name = "txtRestante";
      this.txtRestante.Size = new System.Drawing.Size(136, 20);
      this.txtRestante.TabIndex = 13;
      this.txtRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtRestante.TextFormat = "#,##0.00";
      this.txtRestante.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // BaixaParcial
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(356, 223);
      this.Name = "BaixaParcial";
      this.Text = "BaixaParcial";
      this.Load += new System.EventHandler(this.BaixaParcial_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel7;
    private lib.Visual.Components.sknLabel sknLabel6;
    private lib.Visual.Components.sknLabel sknLabel5;
    private lib.Visual.Components.sknTextBox txtRestante;
    private lib.Visual.Components.sknTextBox txtValor;
    private lib.Visual.Components.sknTextBox txtVencimento;
    private lib.Visual.Components.sknTextBox txtEntrada;
    private lib.Visual.Components.sknTextBox txtDocumento;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknTextBox txtPlanoContas;
  }
}