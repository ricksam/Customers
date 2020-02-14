namespace Financeiro_Marcelo.View.Cartoes
{
  partial class LancaCartoes
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
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.grdCartoes = new lib.Visual.Components.sknGrid();
      this.cmCartoes = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAdicionar = new System.Windows.Forms.Button();
      this.dtEmissao = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtTotalReceber = new lib.Visual.Components.sknTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtTotalTaxas = new lib.Visual.Components.sknTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtValorTotal = new lib.Visual.Components.sknTextBox();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.grdCartoes)).BeginInit();
      this.cmCartoes.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(12, 32);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(198, 21);
      this.cmbEmpresa.TabIndex = 0;
      this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Empresa";
      // 
      // grdCartoes
      // 
      this.grdCartoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdCartoes.ContextMenuStrip = this.cmCartoes;
      this.grdCartoes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdCartoes.Location = new System.Drawing.Point(0, 62);
      this.grdCartoes.Name = "grdCartoes";
      this.grdCartoes.Size = new System.Drawing.Size(734, 352);
      this.grdCartoes.TabIndex = 2;
      this.grdCartoes.DoubleClick += new System.EventHandler(this.grdCartoes_DoubleClick);
      this.grdCartoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdCartoes_KeyDown);
      // 
      // cmCartoes
      // 
      this.cmCartoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.removerToolStripMenuItem});
      this.cmCartoes.Name = "cmCartoes";
      this.cmCartoes.Size = new System.Drawing.Size(126, 48);
      // 
      // adicionarToolStripMenuItem
      // 
      this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
      this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
      this.adicionarToolStripMenuItem.Text = "Adicionar";
      this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
      // 
      // removerToolStripMenuItem
      // 
      this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
      this.removerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
      this.removerToolStripMenuItem.Text = "Remover";
      this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnAdicionar);
      this.groupBox1.Controls.Add(this.dtEmissao);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.cmbEmpresa);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(734, 62);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa";
      // 
      // btnAdicionar
      // 
      this.btnAdicionar.Location = new System.Drawing.Point(341, 30);
      this.btnAdicionar.Name = "btnAdicionar";
      this.btnAdicionar.Size = new System.Drawing.Size(102, 23);
      this.btnAdicionar.TabIndex = 4;
      this.btnAdicionar.Text = "&Adicionar";
      this.btnAdicionar.UseVisualStyleBackColor = true;
      this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
      // 
      // dtEmissao
      // 
      this.dtEmissao.CustomFormat = "dd/MM/yyyy";
      this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtEmissao.Location = new System.Drawing.Point(216, 33);
      this.dtEmissao.Name = "dtEmissao";
      this.dtEmissao.Size = new System.Drawing.Size(119, 20);
      this.dtEmissao.TabIndex = 3;
      this.dtEmissao.ValueChanged += new System.EventHandler(this.dtEmissao_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(213, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Emissão";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtTotalReceber);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txtTotalTaxas);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.txtValorTotal);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 414);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(734, 28);
      this.panel1.TabIndex = 4;
      // 
      // txtTotalReceber
      // 
      this.txtTotalReceber.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTotalReceber.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTotalReceber.AutoTab = true;
      this.txtTotalReceber.Enabled = false;
      this.txtTotalReceber.Location = new System.Drawing.Point(352, 3);
      this.txtTotalReceber.Name = "txtTotalReceber";
      this.txtTotalReceber.Size = new System.Drawing.Size(100, 20);
      this.txtTotalReceber.TabIndex = 5;
      this.txtTotalReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotalReceber.TextFormat = "#,##0.00";
      this.txtTotalReceber.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(298, 6);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Receber";
      // 
      // txtTotalTaxas
      // 
      this.txtTotalTaxas.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTotalTaxas.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTotalTaxas.AutoTab = true;
      this.txtTotalTaxas.Enabled = false;
      this.txtTotalTaxas.Location = new System.Drawing.Point(192, 3);
      this.txtTotalTaxas.Name = "txtTotalTaxas";
      this.txtTotalTaxas.Size = new System.Drawing.Size(100, 20);
      this.txtTotalTaxas.TabIndex = 3;
      this.txtTotalTaxas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotalTaxas.TextFormat = "#,##0.00";
      this.txtTotalTaxas.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(155, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(36, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Taxas";
      // 
      // txtValorTotal
      // 
      this.txtValorTotal.AsDateTime = new System.DateTime(((long)(0)));
      this.txtValorTotal.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtValorTotal.AutoTab = true;
      this.txtValorTotal.Enabled = false;
      this.txtValorTotal.Location = new System.Drawing.Point(49, 3);
      this.txtValorTotal.Name = "txtValorTotal";
      this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
      this.txtValorTotal.TabIndex = 1;
      this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtValorTotal.TextFormat = "#,##0.00";
      this.txtValorTotal.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Total";
      // 
      // LancaCartoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 442);
      this.Controls.Add(this.grdCartoes);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Name = "LancaCartoes";
      this.Text = "Lancamento de Cartoes";
      this.Load += new System.EventHandler(this.LancaCartoes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grdCartoes)).EndInit();
      this.cmCartoes.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private System.Windows.Forms.Label label1;
    private lib.Visual.Components.sknGrid grdCartoes;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnAdicionar;
    private System.Windows.Forms.DateTimePicker dtEmissao;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private lib.Visual.Components.sknTextBox txtTotalReceber;
    private System.Windows.Forms.Label label5;
    private lib.Visual.Components.sknTextBox txtTotalTaxas;
    private System.Windows.Forms.Label label4;
    private lib.Visual.Components.sknTextBox txtValorTotal;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ContextMenuStrip cmCartoes;
    private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
  }
}