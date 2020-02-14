namespace Financeiro_Marcelo.View.Cadastros
{
  partial class CadFornecedores
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
      this.txtFornecedor = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtCNPJ = new lib.Visual.Components.sknMaskedTextBox();
      this.txtTelefone = new lib.Visual.Components.sknMaskedTextBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.txtTelefone);
      this.pnlEdit.Controls.Add(this.txtCNPJ);
      this.pnlEdit.Controls.Add(this.sknLabel3);
      this.pnlEdit.Controls.Add(this.sknLabel2);
      this.pnlEdit.Controls.Add(this.txtFornecedor);
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Size = new System.Drawing.Size(475, 144);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 13);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(61, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Fornecedor";
      // 
      // txtFornecedor
      // 
      this.txtFornecedor.AsDateTime = new System.DateTime(((long)(0)));
      this.txtFornecedor.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtFornecedor.AutoTab = true;
      this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtFornecedor.Location = new System.Drawing.Point(12, 29);
      this.txtFornecedor.Name = "txtFornecedor";
      this.txtFornecedor.Size = new System.Drawing.Size(450, 20);
      this.txtFornecedor.TabIndex = 1;
      this.txtFornecedor.TextFormat = null;
      this.txtFornecedor.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 52);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(34, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "CNPJ";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 91);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(49, 13);
      this.sknLabel3.TabIndex = 4;
      this.sknLabel3.Text = "Telefone";
      // 
      // txtCNPJ
      // 
      this.txtCNPJ.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCNPJ.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCNPJ.AutoTab = true;
      this.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtCNPJ.Location = new System.Drawing.Point(12, 68);
      this.txtCNPJ.Mask = "00.000.000/0000-00";
      this.txtCNPJ.Name = "txtCNPJ";
      this.txtCNPJ.Size = new System.Drawing.Size(146, 20);
      this.txtCNPJ.TabIndex = 3;
      this.txtCNPJ.TextFormat = null;
      this.txtCNPJ.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // txtTelefone
      // 
      this.txtTelefone.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTelefone.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTelefone.AutoTab = true;
      this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtTelefone.Location = new System.Drawing.Point(12, 107);
      this.txtTelefone.Mask = "(99) 0000-0000";
      this.txtTelefone.Name = "txtTelefone";
      this.txtTelefone.Size = new System.Drawing.Size(146, 20);
      this.txtTelefone.TabIndex = 5;
      this.txtTelefone.TextFormat = null;
      this.txtTelefone.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // CadFornecedores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 224);
      this.Name = "CadFornecedores";
      this.Text = "Cadadastro Fornecedores";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.CadFornecedores_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtFornecedor;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknMaskedTextBox txtTelefone;
    private lib.Visual.Components.sknMaskedTextBox txtCNPJ;
  }
}