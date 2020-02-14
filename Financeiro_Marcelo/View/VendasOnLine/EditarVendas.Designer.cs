namespace Financeiro_Marcelo
{
  partial class EditarVendas
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
      this.txtEmpresa = new lib.Visual.Components.sknTextBox();
      this.txtEmissao = new lib.Visual.Components.sknTextBox();
      this.txtOperador = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.txtCupons = new lib.Visual.Components.sknTextBox();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.txtTotal = new lib.Visual.Components.sknTextBox();
      this.sknLabel6 = new lib.Visual.Components.sknLabel();
      this.txtNrForm = new lib.Visual.Components.sknTextBox();
      this.sknLabel7 = new lib.Visual.Components.sknLabel();
      this.btnSelForm = new lib.Visual.Components.sknButton();
      this.txtFormTotal = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtFormCupons = new lib.Visual.Components.sknTextBox();
      this.sknLabel8 = new lib.Visual.Components.sknLabel();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtFormTotal);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.txtFormCupons);
      this.pnlContext.Controls.Add(this.sknLabel8);
      this.pnlContext.Controls.Add(this.btnSelForm);
      this.pnlContext.Controls.Add(this.txtNrForm);
      this.pnlContext.Controls.Add(this.sknLabel7);
      this.pnlContext.Controls.Add(this.txtTotal);
      this.pnlContext.Controls.Add(this.sknLabel6);
      this.pnlContext.Controls.Add(this.txtCupons);
      this.pnlContext.Controls.Add(this.sknLabel5);
      this.pnlContext.Controls.Add(this.txtOperador);
      this.pnlContext.Controls.Add(this.sknLabel4);
      this.pnlContext.Controls.Add(this.txtEmissao);
      this.pnlContext.Controls.Add(this.txtEmpresa);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(497, 172);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 172);
      this.pnlBottom.Size = new System.Drawing.Size(497, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(289, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(385, 8);
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
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 87);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(46, 13);
      this.sknLabel2.TabIndex = 1;
      this.sknLabel2.Text = "Emissão";
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
      this.txtEmpresa.Size = new System.Drawing.Size(463, 20);
      this.txtEmpresa.TabIndex = 2;
      this.txtEmpresa.TextFormat = null;
      this.txtEmpresa.TextType = lib.Visual.Components.enmTextType.String;
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
      this.txtEmissao.Location = new System.Drawing.Point(12, 103);
      this.txtEmissao.Name = "txtEmissao";
      this.txtEmissao.Size = new System.Drawing.Size(100, 20);
      this.txtEmissao.TabIndex = 3;
      this.txtEmissao.TextFormat = "dd/MM/yyyy";
      this.txtEmissao.TextType = lib.Visual.Components.enmTextType.DateTime;
      // 
      // txtOperador
      // 
      this.txtOperador.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOperador.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOperador.AutoTab = true;
      this.txtOperador.Enabled = false;
      this.txtOperador.Location = new System.Drawing.Point(12, 64);
      this.txtOperador.Name = "txtOperador";
      this.txtOperador.Size = new System.Drawing.Size(463, 20);
      this.txtOperador.TabIndex = 7;
      this.txtOperador.TextFormat = null;
      this.txtOperador.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(12, 48);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(51, 13);
      this.sknLabel4.TabIndex = 6;
      this.sknLabel4.Text = "Operador";
      // 
      // txtCupons
      // 
      this.txtCupons.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCupons.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCupons.AutoTab = true;
      this.txtCupons.Enabled = false;
      this.txtCupons.Location = new System.Drawing.Point(118, 103);
      this.txtCupons.Name = "txtCupons";
      this.txtCupons.Size = new System.Drawing.Size(100, 20);
      this.txtCupons.TabIndex = 9;
      this.txtCupons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCupons.TextFormat = "";
      this.txtCupons.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(118, 87);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(43, 13);
      this.sknLabel5.TabIndex = 8;
      this.sknLabel5.Text = "Cupons";
      // 
      // txtTotal
      // 
      this.txtTotal.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTotal.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTotal.AutoTab = true;
      this.txtTotal.Enabled = false;
      this.txtTotal.Location = new System.Drawing.Point(224, 103);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(100, 20);
      this.txtTotal.TabIndex = 11;
      this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotal.TextFormat = "#,##0.00";
      this.txtTotal.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel6
      // 
      this.sknLabel6.AutoSize = true;
      this.sknLabel6.Location = new System.Drawing.Point(224, 87);
      this.sknLabel6.Name = "sknLabel6";
      this.sknLabel6.Size = new System.Drawing.Size(31, 13);
      this.sknLabel6.TabIndex = 10;
      this.sknLabel6.Text = "Total";
      // 
      // txtNrForm
      // 
      this.txtNrForm.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNrForm.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNrForm.AutoTab = true;
      this.txtNrForm.Enabled = false;
      this.txtNrForm.Location = new System.Drawing.Point(12, 142);
      this.txtNrForm.Name = "txtNrForm";
      this.txtNrForm.Size = new System.Drawing.Size(100, 20);
      this.txtNrForm.TabIndex = 13;
      this.txtNrForm.TextFormat = null;
      this.txtNrForm.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel7
      // 
      this.sknLabel7.AutoSize = true;
      this.sknLabel7.Location = new System.Drawing.Point(12, 126);
      this.sknLabel7.Name = "sknLabel7";
      this.sknLabel7.Size = new System.Drawing.Size(78, 13);
      this.sknLabel7.TabIndex = 12;
      this.sknLabel7.Text = "Nro. Formulário";
      // 
      // btnSelForm
      // 
      this.btnSelForm.Location = new System.Drawing.Point(331, 140);
      this.btnSelForm.Name = "btnSelForm";
      this.btnSelForm.Size = new System.Drawing.Size(144, 23);
      this.btnSelForm.TabIndex = 14;
      this.btnSelForm.Text = "Selecionar Formulário";
      this.btnSelForm.UseVisualStyleBackColor = true;
      this.btnSelForm.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // txtFormTotal
      // 
      this.txtFormTotal.AsDateTime = new System.DateTime(((long)(0)));
      this.txtFormTotal.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtFormTotal.AutoTab = true;
      this.txtFormTotal.Enabled = false;
      this.txtFormTotal.Location = new System.Drawing.Point(224, 142);
      this.txtFormTotal.Name = "txtFormTotal";
      this.txtFormTotal.Size = new System.Drawing.Size(100, 20);
      this.txtFormTotal.TabIndex = 18;
      this.txtFormTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtFormTotal.TextFormat = "#,##0.00";
      this.txtFormTotal.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(224, 126);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(31, 13);
      this.sknLabel3.TabIndex = 17;
      this.sknLabel3.Text = "Total";
      // 
      // txtFormCupons
      // 
      this.txtFormCupons.AsDateTime = new System.DateTime(((long)(0)));
      this.txtFormCupons.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtFormCupons.AutoTab = true;
      this.txtFormCupons.Enabled = false;
      this.txtFormCupons.Location = new System.Drawing.Point(118, 142);
      this.txtFormCupons.Name = "txtFormCupons";
      this.txtFormCupons.Size = new System.Drawing.Size(100, 20);
      this.txtFormCupons.TabIndex = 16;
      this.txtFormCupons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtFormCupons.TextFormat = "";
      this.txtFormCupons.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel8
      // 
      this.sknLabel8.AutoSize = true;
      this.sknLabel8.Location = new System.Drawing.Point(118, 126);
      this.sknLabel8.Name = "sknLabel8";
      this.sknLabel8.Size = new System.Drawing.Size(43, 13);
      this.sknLabel8.TabIndex = 15;
      this.sknLabel8.Text = "Cupons";
      // 
      // EditarVendas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(497, 217);
      this.Name = "EditarVendas";
      this.Text = "Editar Vendas";
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtEmissao;
    private lib.Visual.Components.sknTextBox txtEmpresa;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtOperador;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknButton btnSelForm;
    private lib.Visual.Components.sknTextBox txtNrForm;
    private lib.Visual.Components.sknLabel sknLabel7;
    private lib.Visual.Components.sknTextBox txtTotal;
    private lib.Visual.Components.sknLabel sknLabel6;
    private lib.Visual.Components.sknTextBox txtCupons;
    private lib.Visual.Components.sknLabel sknLabel5;
    private lib.Visual.Components.sknTextBox txtFormTotal;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknTextBox txtFormCupons;
    private lib.Visual.Components.sknLabel sknLabel8;
  }
}