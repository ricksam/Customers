namespace MagiaTrigo
{
  partial class frmProdutos
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
      this.lblPRO_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.lblPRO_QTDE = new lib.Visual.Components.sknLabel();
      this.txtQtde = new lib.Visual.Components.sknTextBox();
      this.lblPRO_UNIDADE = new lib.Visual.Components.sknLabel();
      this.txtUnidade = new lib.Visual.Components.sknTextBox();
      this.lblPRO_CUSTO = new lib.Visual.Components.sknLabel();
      this.txtCusto = new lib.Visual.Components.sknTextBox();
      this.lblPRO_PRECO = new lib.Visual.Components.sknLabel();
      this.txtPreco = new lib.Visual.Components.sknTextBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.lblPRO_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtDescricao);
      this.pnlEdit.Controls.Add(this.lblPRO_QTDE);
      this.pnlEdit.Controls.Add(this.txtQtde);
      this.pnlEdit.Controls.Add(this.lblPRO_UNIDADE);
      this.pnlEdit.Controls.Add(this.txtUnidade);
      this.pnlEdit.Controls.Add(this.lblPRO_CUSTO);
      this.pnlEdit.Controls.Add(this.txtCusto);
      this.pnlEdit.Controls.Add(this.lblPRO_PRECO);
      this.pnlEdit.Controls.Add(this.txtPreco);
      this.pnlEdit.Size = new System.Drawing.Size(475, 205);
      // 
      // lblPRO_DESCRICAO
      // 
      this.lblPRO_DESCRICAO.AutoSize = true;
      this.lblPRO_DESCRICAO.Location = new System.Drawing.Point(12, 3);
      this.lblPRO_DESCRICAO.Name = "lblPRO_DESCRICAO";
      this.lblPRO_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblPRO_DESCRICAO.TabIndex = 1;
      this.lblPRO_DESCRICAO.Text = "Descrição";
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
      this.txtDescricao.Location = new System.Drawing.Point(12, 19);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(300, 20);
      this.txtDescricao.TabIndex = 2;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblPRO_QTDE
      // 
      this.lblPRO_QTDE.AutoSize = true;
      this.lblPRO_QTDE.Location = new System.Drawing.Point(12, 42);
      this.lblPRO_QTDE.Name = "lblPRO_QTDE";
      this.lblPRO_QTDE.Size = new System.Drawing.Size(30, 13);
      this.lblPRO_QTDE.TabIndex = 3;
      this.lblPRO_QTDE.Text = "Qtde";
      // 
      // txtQtde
      // 
      this.txtQtde.AsDateTime = new System.DateTime(((long)(0)));
      this.txtQtde.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtQtde.AutoTab = true;
      this.txtQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtQtde.Location = new System.Drawing.Point(12, 58);
      this.txtQtde.Name = "txtQtde";
      this.txtQtde.Size = new System.Drawing.Size(120, 20);
      this.txtQtde.TabIndex = 4;
      this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtQtde.TextFormat = "#,##0.00";
      this.txtQtde.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // lblPRO_UNIDADE
      // 
      this.lblPRO_UNIDADE.AutoSize = true;
      this.lblPRO_UNIDADE.Location = new System.Drawing.Point(12, 81);
      this.lblPRO_UNIDADE.Name = "lblPRO_UNIDADE";
      this.lblPRO_UNIDADE.Size = new System.Drawing.Size(47, 13);
      this.lblPRO_UNIDADE.TabIndex = 5;
      this.lblPRO_UNIDADE.Text = "Unidade";
      // 
      // txtUnidade
      // 
      this.txtUnidade.AsDateTime = new System.DateTime(((long)(0)));
      this.txtUnidade.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtUnidade.AutoTab = true;
      this.txtUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUnidade.Location = new System.Drawing.Point(12, 97);
      this.txtUnidade.Name = "txtUnidade";
      this.txtUnidade.Size = new System.Drawing.Size(100, 20);
      this.txtUnidade.TabIndex = 6;
      this.txtUnidade.TextFormat = null;
      this.txtUnidade.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblPRO_CUSTO
      // 
      this.lblPRO_CUSTO.AutoSize = true;
      this.lblPRO_CUSTO.Location = new System.Drawing.Point(12, 120);
      this.lblPRO_CUSTO.Name = "lblPRO_CUSTO";
      this.lblPRO_CUSTO.Size = new System.Drawing.Size(34, 13);
      this.lblPRO_CUSTO.TabIndex = 7;
      this.lblPRO_CUSTO.Text = "Custo";
      // 
      // txtCusto
      // 
      this.txtCusto.AsDateTime = new System.DateTime(((long)(0)));
      this.txtCusto.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCusto.AutoTab = true;
      this.txtCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCusto.Location = new System.Drawing.Point(12, 136);
      this.txtCusto.Name = "txtCusto";
      this.txtCusto.Size = new System.Drawing.Size(120, 20);
      this.txtCusto.TabIndex = 8;
      this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtCusto.TextFormat = "#,##0.00";
      this.txtCusto.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // lblPRO_PRECO
      // 
      this.lblPRO_PRECO.AutoSize = true;
      this.lblPRO_PRECO.Location = new System.Drawing.Point(12, 159);
      this.lblPRO_PRECO.Name = "lblPRO_PRECO";
      this.lblPRO_PRECO.Size = new System.Drawing.Size(35, 13);
      this.lblPRO_PRECO.TabIndex = 9;
      this.lblPRO_PRECO.Text = "Preço";
      // 
      // txtPreco
      // 
      this.txtPreco.AsDateTime = new System.DateTime(((long)(0)));
      this.txtPreco.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtPreco.AutoTab = true;
      this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtPreco.Location = new System.Drawing.Point(12, 175);
      this.txtPreco.Name = "txtPreco";
      this.txtPreco.Size = new System.Drawing.Size(120, 20);
      this.txtPreco.TabIndex = 10;
      this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtPreco.TextFormat = "#,##0.00";
      this.txtPreco.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // frmProdutos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 285);
      this.Name = "frmProdutos";
      this.Text = "Produtos";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblPRO_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknLabel lblPRO_QTDE;
    private lib.Visual.Components.sknTextBox txtQtde;
    private lib.Visual.Components.sknLabel lblPRO_UNIDADE;
    private lib.Visual.Components.sknTextBox txtUnidade;
    private lib.Visual.Components.sknLabel lblPRO_CUSTO;
    private lib.Visual.Components.sknTextBox txtCusto;
    private lib.Visual.Components.sknLabel lblPRO_PRECO;
    private lib.Visual.Components.sknTextBox txtPreco;
  }
}
