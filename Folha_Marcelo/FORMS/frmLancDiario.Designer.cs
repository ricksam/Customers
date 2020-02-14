namespace Folha_Marcelo.FORMS
{
  partial class frmLancDiario
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
      this.cmbOperacao = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbReferencia = new System.Windows.Forms.ComboBox();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtDia = new lib.Visual.Components.sknTextBox();
      this.lblMesAno = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.label5);
      this.pnlContext.Controls.Add(this.txtDescricao);
      this.pnlContext.Controls.Add(this.lblMesAno);
      this.pnlContext.Controls.Add(this.txtDia);
      this.pnlContext.Controls.Add(this.label4);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.cmbReferencia);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.cmbOperacao);
      this.pnlContext.Controls.Add(this.label1);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(84, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(180, 8);
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Referência";
      // 
      // cmbReferencia
      // 
      this.cmbReferencia.FormattingEnabled = true;
      this.cmbReferencia.Location = new System.Drawing.Point(12, 143);
      this.cmbReferencia.Name = "cmbReferencia";
      this.cmbReferencia.Size = new System.Drawing.Size(258, 21);
      this.cmbReferencia.TabIndex = 8;
      this.cmbReferencia.TextChanged += new System.EventHandler(this.cmbReferencia_TextChanged);
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
      this.txtValor.Location = new System.Drawing.Point(12, 183);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(258, 20);
      this.txtValor.TabIndex = 10;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 167);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Valor (F2 Expressão)";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 88);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(23, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Dia";
      // 
      // txtDia
      // 
      this.txtDia.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDia.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDia.AutoTab = true;
      this.txtDia.Location = new System.Drawing.Point(12, 104);
      this.txtDia.MaxLength = 2;
      this.txtDia.Name = "txtDia";
      this.txtDia.Size = new System.Drawing.Size(54, 20);
      this.txtDia.TabIndex = 5;
      this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtDia.TextFormat = "00";
      this.txtDia.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // lblMesAno
      // 
      this.lblMesAno.AutoSize = true;
      this.lblMesAno.Location = new System.Drawing.Point(72, 107);
      this.lblMesAno.Name = "lblMesAno";
      this.lblMesAno.Size = new System.Drawing.Size(55, 13);
      this.lblMesAno.TabIndex = 6;
      this.lblMesAno.Text = "mês / ano";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 49);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(55, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "Descrição";
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
      this.txtDescricao.Location = new System.Drawing.Point(12, 65);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(258, 20);
      this.txtDescricao.TabIndex = 3;
      this.txtDescricao.TextFormat = "";
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // frmLancDiario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 262);
      this.Name = "frmLancDiario";
      this.Text = "Lançamento";
      this.Load += new System.EventHandler(this.frmLancDiario_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbOperacao;
    private lib.Visual.Components.sknTextBox txtValor;
    private System.Windows.Forms.ComboBox cmbReferencia;
    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknTextBox txtDia;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblMesAno;
    private System.Windows.Forms.Label label5;
    private lib.Visual.Components.sknTextBox txtDescricao;
  }
}