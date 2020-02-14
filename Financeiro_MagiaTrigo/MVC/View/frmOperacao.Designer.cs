namespace MagiaTrigo
{
  partial class frmOperacao
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
      this.lblOPR_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.lblOPR_PLN_CODIGO = new lib.Visual.Components.sknLabel();
      this.lblOPR_ADDESTOQUE = new lib.Visual.Components.sknLabel();
      this.txtAdicionarEstoque = new lib.Visual.Components.sknTextBox();
      this.cmbPlanoContas = new lib.Visual.Components.sknComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cbFinanceiro = new System.Windows.Forms.CheckBox();
      this.pnlEdit.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.groupBox1);
      this.pnlEdit.Controls.Add(this.lblOPR_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtDescricao);
      this.pnlEdit.Controls.Add(this.lblOPR_ADDESTOQUE);
      this.pnlEdit.Controls.Add(this.txtAdicionarEstoque);
      this.pnlEdit.Size = new System.Drawing.Size(475, 145);
      // 
      // lblOPR_DESCRICAO
      // 
      this.lblOPR_DESCRICAO.AutoSize = true;
      this.lblOPR_DESCRICAO.Location = new System.Drawing.Point(12, 3);
      this.lblOPR_DESCRICAO.Name = "lblOPR_DESCRICAO";
      this.lblOPR_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblOPR_DESCRICAO.TabIndex = 0;
      this.lblOPR_DESCRICAO.Text = "Descrição";
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
      this.txtDescricao.Size = new System.Drawing.Size(324, 20);
      this.txtDescricao.TabIndex = 2;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblOPR_PLN_CODIGO
      // 
      this.lblOPR_PLN_CODIGO.AutoSize = true;
      this.lblOPR_PLN_CODIGO.Location = new System.Drawing.Point(6, 39);
      this.lblOPR_PLN_CODIGO.Name = "lblOPR_PLN_CODIGO";
      this.lblOPR_PLN_CODIGO.Size = new System.Drawing.Size(85, 13);
      this.lblOPR_PLN_CODIGO.TabIndex = 1;
      this.lblOPR_PLN_CODIGO.Text = "Plano de Contas";
      // 
      // lblOPR_ADDESTOQUE
      // 
      this.lblOPR_ADDESTOQUE.AutoSize = true;
      this.lblOPR_ADDESTOQUE.Location = new System.Drawing.Point(342, 3);
      this.lblOPR_ADDESTOQUE.Name = "lblOPR_ADDESTOQUE";
      this.lblOPR_ADDESTOQUE.Size = new System.Drawing.Size(108, 13);
      this.lblOPR_ADDESTOQUE.TabIndex = 1;
      this.lblOPR_ADDESTOQUE.Text = "Adicionar ao Estoque";
      // 
      // txtAdicionarEstoque
      // 
      this.txtAdicionarEstoque.AsDateTime = new System.DateTime(((long)(0)));
      this.txtAdicionarEstoque.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAdicionarEstoque.AutoTab = true;
      this.txtAdicionarEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtAdicionarEstoque.Location = new System.Drawing.Point(342, 19);
      this.txtAdicionarEstoque.Name = "txtAdicionarEstoque";
      this.txtAdicionarEstoque.Size = new System.Drawing.Size(120, 20);
      this.txtAdicionarEstoque.TabIndex = 3;
      this.txtAdicionarEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtAdicionarEstoque.TextFormat = null;
      this.txtAdicionarEstoque.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // cmbPlanoContas
      // 
      this.cmbPlanoContas.AutoTab = true;
      this.cmbPlanoContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPlanoContas.Enabled = false;
      this.cmbPlanoContas.FormattingEnabled = true;
      this.cmbPlanoContas.Location = new System.Drawing.Point(6, 55);
      this.cmbPlanoContas.Name = "cmbPlanoContas";
      this.cmbPlanoContas.Size = new System.Drawing.Size(318, 21);
      this.cmbPlanoContas.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.cbFinanceiro);
      this.groupBox1.Controls.Add(this.lblOPR_PLN_CODIGO);
      this.groupBox1.Controls.Add(this.cmbPlanoContas);
      this.groupBox1.Location = new System.Drawing.Point(12, 45);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(450, 85);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Plano de Contas";
      // 
      // cbFinanceiro
      // 
      this.cbFinanceiro.AutoSize = true;
      this.cbFinanceiro.Location = new System.Drawing.Point(6, 19);
      this.cbFinanceiro.Name = "cbFinanceiro";
      this.cbFinanceiro.Size = new System.Drawing.Size(126, 17);
      this.cbFinanceiro.TabIndex = 0;
      this.cbFinanceiro.Text = "Lançar no Financeiro";
      this.cbFinanceiro.UseVisualStyleBackColor = true;
      this.cbFinanceiro.CheckedChanged += new System.EventHandler(this.cbFinanceiro_CheckedChanged);
      // 
      // frmOperacao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 225);
      this.Name = "frmOperacao";
      this.Text = "Operação";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblOPR_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknLabel lblOPR_PLN_CODIGO;
    private lib.Visual.Components.sknLabel lblOPR_ADDESTOQUE;
    private lib.Visual.Components.sknTextBox txtAdicionarEstoque;
    private lib.Visual.Components.sknComboBox cmbPlanoContas;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox cbFinanceiro;
  }
}
