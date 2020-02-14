namespace Financeiro_Marcelo.View.Cadastros
{
  partial class CadEmpresas
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
      this.txtNome = new lib.Visual.Components.sknTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtNomeOnLine = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.txtCNPJ = new lib.Visual.Components.sknTextBox();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.txtCNPJ);
      this.pnlEdit.Controls.Add(this.sknLabel3);
      this.pnlEdit.Controls.Add(this.txtNomeOnLine);
      this.pnlEdit.Controls.Add(this.sknLabel2);
      this.pnlEdit.Controls.Add(this.txtNome);
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Size = new System.Drawing.Size(475, 130);
      // 
      // txtNome
      // 
      this.txtNome.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNome.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNome.AutoTab = true;
      this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNome.Location = new System.Drawing.Point(12, 19);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(450, 20);
      this.txtNome.TabIndex = 1;
      this.txtNome.TextFormat = null;
      this.txtNome.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 3);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(35, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Nome";
      // 
      // txtNomeOnLine
      // 
      this.txtNomeOnLine.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNomeOnLine.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNomeOnLine.AutoTab = true;
      this.txtNomeOnLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNomeOnLine.Location = new System.Drawing.Point(12, 97);
      this.txtNomeOnLine.Name = "txtNomeOnLine";
      this.txtNomeOnLine.Size = new System.Drawing.Size(450, 20);
      this.txtNomeOnLine.TabIndex = 5;
      this.txtNomeOnLine.TextFormat = null;
      this.txtNomeOnLine.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(12, 81);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(174, 13);
      this.sknLabel2.TabIndex = 4;
      this.sknLabel2.Text = "Nome (Sistema de vendas On-Line)";
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
      this.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCNPJ.Location = new System.Drawing.Point(12, 58);
      this.txtCNPJ.Name = "txtCNPJ";
      this.txtCNPJ.Size = new System.Drawing.Size(450, 20);
      this.txtCNPJ.TabIndex = 3;
      this.txtCNPJ.TextFormat = null;
      this.txtCNPJ.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 42);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(34, 13);
      this.sknLabel3.TabIndex = 2;
      this.sknLabel3.Text = "CNPJ";
      // 
      // CadEmpresas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 210);
      this.Name = "CadEmpresas";
      this.Text = "CadEmpresas";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.CadEmpresas_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtNome;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtNomeOnLine;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtCNPJ;
    private lib.Visual.Components.sknLabel sknLabel3;
  }
}