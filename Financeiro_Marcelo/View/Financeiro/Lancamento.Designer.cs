namespace Financeiro_Marcelo
{
  partial class Lancamento
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lancamento));
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.cmbCategoria = new lib.Visual.Components.sknComboBox();
      this.cmbPlanoContas = new lib.Visual.Components.sknComboBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.txtValor = new lib.Visual.Components.sknTextBox();
      this.sknLabel5 = new lib.Visual.Components.sknLabel();
      this.dtEmissao = new System.Windows.Forms.DateTimePicker();
      this.dtVencimento = new System.Windows.Forms.DateTimePicker();
      this.sknLabel6 = new lib.Visual.Components.sknLabel();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.sknLabel7 = new lib.Visual.Components.sknLabel();
      this.sknLabel8 = new lib.Visual.Components.sknLabel();
      this.txtFornecedor = new lib.Visual.Components.sknTextBox();
      this.btnFornecedor = new lib.Visual.Components.sknButton();
      this.txtValNota = new lib.Visual.Components.sknTextBox();
      this.sknLabel9 = new lib.Visual.Components.sknLabel();
      this.grbItens = new lib.Visual.Components.sknGroupBox();
      this.btnAdicionarItem = new lib.Visual.Components.sknButton();
      this.txtProduto = new lib.Visual.Components.sknTextBox();
      this.grdItems = new lib.Visual.Components.sknGrid();
      this.cmItem = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.removerF10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnCadFornecedor = new lib.Visual.Components.sknButton();
      this.sknButton2 = new lib.Visual.Components.sknButton();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.grbItens.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
      this.cmItem.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.sknButton2);
      this.pnlContext.Controls.Add(this.btnCadFornecedor);
      this.pnlContext.Controls.Add(this.grbItens);
      this.pnlContext.Controls.Add(this.sknLabel9);
      this.pnlContext.Controls.Add(this.txtValNota);
      this.pnlContext.Controls.Add(this.btnFornecedor);
      this.pnlContext.Controls.Add(this.txtFornecedor);
      this.pnlContext.Controls.Add(this.sknLabel8);
      this.pnlContext.Controls.Add(this.txtDocumento);
      this.pnlContext.Controls.Add(this.sknLabel7);
      this.pnlContext.Controls.Add(this.dtVencimento);
      this.pnlContext.Controls.Add(this.sknLabel6);
      this.pnlContext.Controls.Add(this.dtEmissao);
      this.pnlContext.Controls.Add(this.sknLabel5);
      this.pnlContext.Controls.Add(this.txtValor);
      this.pnlContext.Controls.Add(this.sknLabel4);
      this.pnlContext.Controls.Add(this.txtDescricao);
      this.pnlContext.Controls.Add(this.sknLabel3);
      this.pnlContext.Controls.Add(this.cmbPlanoContas);
      this.pnlContext.Controls.Add(this.sknLabel2);
      this.pnlContext.Controls.Add(this.cmbCategoria);
      this.pnlContext.Controls.Add(this.sknLabel1);
      this.pnlContext.Size = new System.Drawing.Size(437, 434);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Location = new System.Drawing.Point(0, 434);
      this.pnlBottom.Size = new System.Drawing.Size(437, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(239, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(335, 8);
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 9);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(52, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Categoria";
      // 
      // cmbCategoria
      // 
      this.cmbCategoria.AutoTab = true;
      this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCategoria.FormattingEnabled = true;
      this.cmbCategoria.Location = new System.Drawing.Point(12, 25);
      this.cmbCategoria.Name = "cmbCategoria";
      this.cmbCategoria.Size = new System.Drawing.Size(156, 21);
      this.cmbCategoria.TabIndex = 1;
      this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
      // 
      // cmbPlanoContas
      // 
      this.cmbPlanoContas.AutoTab = true;
      this.cmbPlanoContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPlanoContas.Enabled = false;
      this.cmbPlanoContas.FormattingEnabled = true;
      this.cmbPlanoContas.Location = new System.Drawing.Point(174, 25);
      this.cmbPlanoContas.Name = "cmbPlanoContas";
      this.cmbPlanoContas.Size = new System.Drawing.Size(253, 21);
      this.cmbPlanoContas.TabIndex = 3;
      this.cmbPlanoContas.SelectedIndexChanged += new System.EventHandler(this.cmbPlanoContas_SelectedIndexChanged);
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(174, 9);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(85, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Plano de Contas";
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 214);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(55, 13);
      this.sknLabel3.TabIndex = 5;
      this.sknLabel3.Text = "Descrição";
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
      this.txtDescricao.Location = new System.Drawing.Point(12, 230);
      this.txtDescricao.Multiline = true;
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(415, 68);
      this.txtDescricao.TabIndex = 6;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(12, 301);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(132, 13);
      this.sknLabel4.TabIndex = 7;
      this.sknLabel4.Text = "Valor (F2 para expressões)";
      // 
      // txtValor
      // 
      this.txtValor.AsDateTime = new System.DateTime(((long)(0)));
      this.txtValor.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtValor.AutoTab = false;
      this.txtValor.Enabled = false;
      this.txtValor.Location = new System.Drawing.Point(12, 317);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(156, 20);
      this.txtValor.TabIndex = 8;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValor.TextFormat = "#,##0.00";
      this.txtValor.TextType = lib.Visual.Components.enmTextType.Decimal;
      this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
      // 
      // sknLabel5
      // 
      this.sknLabel5.AutoSize = true;
      this.sknLabel5.Location = new System.Drawing.Point(174, 379);
      this.sknLabel5.Name = "sknLabel5";
      this.sknLabel5.Size = new System.Drawing.Size(46, 13);
      this.sknLabel5.TabIndex = 18;
      this.sknLabel5.Text = "Emissao";
      // 
      // dtEmissao
      // 
      this.dtEmissao.CustomFormat = "dd/MM/yyyy";
      this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtEmissao.Location = new System.Drawing.Point(174, 395);
      this.dtEmissao.Name = "dtEmissao";
      this.dtEmissao.Size = new System.Drawing.Size(104, 20);
      this.dtEmissao.TabIndex = 19;
      // 
      // dtVencimento
      // 
      this.dtVencimento.CustomFormat = "dd/MM/yyyy";
      this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtVencimento.Location = new System.Drawing.Point(284, 395);
      this.dtVencimento.Name = "dtVencimento";
      this.dtVencimento.Size = new System.Drawing.Size(104, 20);
      this.dtVencimento.TabIndex = 21;
      // 
      // sknLabel6
      // 
      this.sknLabel6.AutoSize = true;
      this.sknLabel6.Location = new System.Drawing.Point(281, 379);
      this.sknLabel6.Name = "sknLabel6";
      this.sknLabel6.Size = new System.Drawing.Size(63, 13);
      this.sknLabel6.TabIndex = 20;
      this.sknLabel6.Text = "Vencimento";
      // 
      // txtDocumento
      // 
      this.txtDocumento.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDocumento.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDocumento.AutoTab = false;
      this.txtDocumento.Location = new System.Drawing.Point(12, 395);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(156, 20);
      this.txtDocumento.TabIndex = 17;
      this.txtDocumento.TextFormat = "";
      this.txtDocumento.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel7
      // 
      this.sknLabel7.AutoSize = true;
      this.sknLabel7.Location = new System.Drawing.Point(12, 379);
      this.sknLabel7.Name = "sknLabel7";
      this.sknLabel7.Size = new System.Drawing.Size(85, 13);
      this.sknLabel7.TabIndex = 16;
      this.sknLabel7.Text = "Nro. Documento";
      // 
      // sknLabel8
      // 
      this.sknLabel8.AutoSize = true;
      this.sknLabel8.Location = new System.Drawing.Point(12, 340);
      this.sknLabel8.Name = "sknLabel8";
      this.sknLabel8.Size = new System.Drawing.Size(61, 13);
      this.sknLabel8.TabIndex = 12;
      this.sknLabel8.Text = "Fornecedor";
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
      this.txtFornecedor.Enabled = false;
      this.txtFornecedor.Location = new System.Drawing.Point(12, 356);
      this.txtFornecedor.Name = "txtFornecedor";
      this.txtFornecedor.Size = new System.Drawing.Size(351, 20);
      this.txtFornecedor.TabIndex = 13;
      this.txtFornecedor.TextFormat = null;
      this.txtFornecedor.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // btnFornecedor
      // 
      this.btnFornecedor.Location = new System.Drawing.Point(369, 356);
      this.btnFornecedor.Name = "btnFornecedor";
      this.btnFornecedor.Size = new System.Drawing.Size(25, 20);
      this.btnFornecedor.TabIndex = 14;
      this.btnFornecedor.Text = "...";
      this.btnFornecedor.UseVisualStyleBackColor = true;
      this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
      // 
      // txtValNota
      // 
      this.txtValNota.AsDateTime = new System.DateTime(((long)(0)));
      this.txtValNota.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtValNota.AutoTab = false;
      this.txtValNota.Enabled = false;
      this.txtValNota.Location = new System.Drawing.Point(174, 317);
      this.txtValNota.Name = "txtValNota";
      this.txtValNota.Size = new System.Drawing.Size(156, 20);
      this.txtValNota.TabIndex = 10;
      this.txtValNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValNota.TextFormat = "#,##0.00";
      this.txtValNota.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel9
      // 
      this.sknLabel9.AutoSize = true;
      this.sknLabel9.Location = new System.Drawing.Point(174, 301);
      this.sknLabel9.Name = "sknLabel9";
      this.sknLabel9.Size = new System.Drawing.Size(72, 13);
      this.sknLabel9.TabIndex = 9;
      this.sknLabel9.Text = "Valor da Nota";
      // 
      // grbItens
      // 
      this.grbItens.Controls.Add(this.btnAdicionarItem);
      this.grbItens.Controls.Add(this.txtProduto);
      this.grbItens.Controls.Add(this.grdItems);
      this.grbItens.Location = new System.Drawing.Point(12, 52);
      this.grbItens.Name = "grbItens";
      this.grbItens.Size = new System.Drawing.Size(415, 159);
      this.grbItens.TabIndex = 4;
      this.grbItens.TabStop = false;
      this.grbItens.Text = "Itens";
      // 
      // btnAdicionarItem
      // 
      this.btnAdicionarItem.Location = new System.Drawing.Point(385, 17);
      this.btnAdicionarItem.Name = "btnAdicionarItem";
      this.btnAdicionarItem.Size = new System.Drawing.Size(24, 23);
      this.btnAdicionarItem.TabIndex = 1;
      this.btnAdicionarItem.Text = "+";
      this.btnAdicionarItem.UseVisualStyleBackColor = true;
      this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
      // 
      // txtProduto
      // 
      this.txtProduto.AsDateTime = new System.DateTime(((long)(0)));
      this.txtProduto.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtProduto.AutoTab = true;
      this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtProduto.Location = new System.Drawing.Point(6, 19);
      this.txtProduto.Name = "txtProduto";
      this.txtProduto.Size = new System.Drawing.Size(373, 20);
      this.txtProduto.TabIndex = 0;
      this.txtProduto.TextFormat = null;
      this.txtProduto.TextType = lib.Visual.Components.enmTextType.String;
      this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyDown);
      // 
      // grdItems
      // 
      this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdItems.ContextMenuStrip = this.cmItem;
      this.grdItems.Location = new System.Drawing.Point(6, 45);
      this.grdItems.Name = "grdItems";
      this.grdItems.Size = new System.Drawing.Size(403, 108);
      this.grdItems.TabIndex = 2;
      this.grdItems.DoubleClick += new System.EventHandler(this.grdItems_DoubleClick);
      this.grdItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdItems_KeyDown);
      // 
      // cmItem
      // 
      this.cmItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removerF10ToolStripMenuItem});
      this.cmItem.Name = "cmItem";
      this.cmItem.Size = new System.Drawing.Size(143, 26);
      // 
      // removerF10ToolStripMenuItem
      // 
      this.removerF10ToolStripMenuItem.Name = "removerF10ToolStripMenuItem";
      this.removerF10ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
      this.removerF10ToolStripMenuItem.Text = "Remover F10";
      this.removerF10ToolStripMenuItem.Click += new System.EventHandler(this.removerF10ToolStripMenuItem_Click);
      // 
      // btnCadFornecedor
      // 
      this.btnCadFornecedor.Location = new System.Drawing.Point(400, 356);
      this.btnCadFornecedor.Name = "btnCadFornecedor";
      this.btnCadFornecedor.Size = new System.Drawing.Size(25, 20);
      this.btnCadFornecedor.TabIndex = 15;
      this.btnCadFornecedor.Text = "+";
      this.btnCadFornecedor.UseVisualStyleBackColor = true;
      this.btnCadFornecedor.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // sknButton2
      // 
      this.sknButton2.Location = new System.Drawing.Point(336, 314);
      this.sknButton2.Name = "sknButton2";
      this.sknButton2.Size = new System.Drawing.Size(89, 23);
      this.sknButton2.TabIndex = 11;
      this.sknButton2.Text = "Totalizar";
      this.sknButton2.UseVisualStyleBackColor = true;
      this.sknButton2.Click += new System.EventHandler(this.sknButton2_Click);
      // 
      // Lancamento
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(437, 479);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Lancamento";
      this.Text = "Lancamento";
      this.Load += new System.EventHandler(this.Lancamento_Load);
      this.Controls.SetChildIndex(this.pnlBottom, 0);
      this.Controls.SetChildIndex(this.pnlContext, 0);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.grbItens.ResumeLayout(false);
      this.grbItens.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
      this.cmItem.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknComboBox cmbPlanoContas;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknComboBox cmbCategoria;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknTextBox txtValor;
    private lib.Visual.Components.sknLabel sknLabel4;
    private System.Windows.Forms.DateTimePicker dtEmissao;
    private lib.Visual.Components.sknLabel sknLabel5;
    private lib.Visual.Components.sknTextBox txtDocumento;
    private lib.Visual.Components.sknLabel sknLabel7;
    private System.Windows.Forms.DateTimePicker dtVencimento;
    private lib.Visual.Components.sknLabel sknLabel6;
    private lib.Visual.Components.sknButton btnFornecedor;
    private lib.Visual.Components.sknTextBox txtFornecedor;
    private lib.Visual.Components.sknLabel sknLabel8;
    private lib.Visual.Components.sknLabel sknLabel9;
    private lib.Visual.Components.sknTextBox txtValNota;
    private lib.Visual.Components.sknGroupBox grbItens;
    private lib.Visual.Components.sknButton btnAdicionarItem;
    private lib.Visual.Components.sknTextBox txtProduto;
    private lib.Visual.Components.sknGrid grdItems;
    private lib.Visual.Components.sknButton btnCadFornecedor;
    private System.Windows.Forms.ContextMenuStrip cmItem;
    private System.Windows.Forms.ToolStripMenuItem removerF10ToolStripMenuItem;
    private lib.Visual.Components.sknButton sknButton2;
  }
}