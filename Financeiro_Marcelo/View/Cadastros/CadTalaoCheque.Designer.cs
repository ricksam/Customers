namespace Financeiro_Marcelo.View.Cadastros
{
  partial class CadTalaoCheque
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
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtInicio = new lib.Visual.Components.sknTextBox();
      this.txtAtual = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtFim = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.cmbContas = new lib.Visual.Components.sknComboBox();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.cmbContas);
      this.pnlEdit.Controls.Add(this.sknLabel5);
      this.pnlEdit.Controls.Add(this.txtFim);
      this.pnlEdit.Controls.Add(this.sknLabel4);
      this.pnlEdit.Controls.Add(this.txtAtual);
      this.pnlEdit.Controls.Add(this.sknLabel3);
      this.pnlEdit.Controls.Add(this.txtInicio);
      this.pnlEdit.Controls.Add(this.sknLabel2);
      this.pnlEdit.Controls.Add(this.cmbEmpresa);
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Size = new System.Drawing.Size(475, 228);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 12);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(48, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Empresa";
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(12, 28);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(222, 21);
      this.cmbEmpresa.TabIndex = 1;
      this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(15, 92);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(32, 13);
      this.sknLabel2.TabIndex = 4;
      this.sknLabel2.Text = "Inicio";
      // 
      // txtInicio
      // 
      this.txtInicio.AsDateTime = new System.DateTime(((long)(0)));
      this.txtInicio.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtInicio.AutoTab = true;
      this.txtInicio.Location = new System.Drawing.Point(15, 108);
      this.txtInicio.Name = "txtInicio";
      this.txtInicio.Size = new System.Drawing.Size(146, 20);
      this.txtInicio.TabIndex = 5;
      this.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtInicio.TextFormat = null;
      this.txtInicio.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // txtAtual
      // 
      this.txtAtual.AsDateTime = new System.DateTime(((long)(0)));
      this.txtAtual.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAtual.AutoTab = true;
      this.txtAtual.Location = new System.Drawing.Point(15, 186);
      this.txtAtual.Name = "txtAtual";
      this.txtAtual.Size = new System.Drawing.Size(146, 20);
      this.txtAtual.TabIndex = 9;
      this.txtAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtAtual.TextFormat = null;
      this.txtAtual.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(15, 170);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(31, 13);
      this.sknLabel3.TabIndex = 8;
      this.sknLabel3.Text = "Atual";
      // 
      // txtFim
      // 
      this.txtFim.AsDateTime = new System.DateTime(((long)(0)));
      this.txtFim.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtFim.AutoTab = true;
      this.txtFim.Location = new System.Drawing.Point(15, 147);
      this.txtFim.Name = "txtFim";
      this.txtFim.Size = new System.Drawing.Size(146, 20);
      this.txtFim.TabIndex = 7;
      this.txtFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtFim.TextFormat = null;
      this.txtFim.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(15, 131);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(23, 13);
      this.sknLabel4.TabIndex = 6;
      this.sknLabel4.Text = "Fim";
      // 
      // cmbContas
      // 
      this.cmbContas.AutoTab = true;
      this.cmbContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbContas.FormattingEnabled = true;
      this.cmbContas.Location = new System.Drawing.Point(12, 68);
      this.cmbContas.Name = "cmbContas";
      this.cmbContas.Size = new System.Drawing.Size(374, 21);
      this.cmbContas.TabIndex = 3;
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(12, 52);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(35, 13);
      this.sknLabel5.TabIndex = 2;
      this.sknLabel5.Text = "Conta";
      // 
      // CadTalaoCheque
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 308);
      this.Name = "CadTalaoCheque";
      this.Text = "Cadastro de Talao de Cheque";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Talao_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private lib.Visual.Components.sknTextBox txtFim;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknTextBox txtAtual;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknTextBox txtInicio;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknComboBox cmbContas;
    private lib.Visual.Components.sknLabel sknLabel5;
  }
}