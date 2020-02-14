namespace Folha_Marcelo.FORMS
{
  partial class frmResumo
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
      this.label1 = new System.Windows.Forms.Label();
      this.cmbLoja = new System.Windows.Forms.ComboBox();
      this.cmbColaborador = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbAno = new System.Windows.Forms.ComboBox();
      this.cmbMes = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.txtTotDesconto = new lib.Visual.Components.sknTextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.txtTotRemuneracao = new lib.Visual.Components.sknTextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.txtLiquido = new lib.Visual.Components.sknTextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.grdDiario = new lib.Visual.Components.sknGrid();
      this.cmDiario = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.grdResumo = new lib.Visual.Components.sknGrid();
      this.cmResumo = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.removerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAtualizar = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.grdDiario)).BeginInit();
      this.cmDiario.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdResumo)).BeginInit();
      this.cmResumo.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Loja";
      // 
      // cmbLoja
      // 
      this.cmbLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLoja.FormattingEnabled = true;
      this.cmbLoja.Location = new System.Drawing.Point(6, 72);
      this.cmbLoja.Name = "cmbLoja";
      this.cmbLoja.Size = new System.Drawing.Size(121, 21);
      this.cmbLoja.TabIndex = 1;
      this.cmbLoja.SelectedIndexChanged += new System.EventHandler(this.cmbLoja_SelectedIndexChanged);
      // 
      // cmbColaborador
      // 
      this.cmbColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbColaborador.FormattingEnabled = true;
      this.cmbColaborador.Location = new System.Drawing.Point(133, 72);
      this.cmbColaborador.Name = "cmbColaborador";
      this.cmbColaborador.Size = new System.Drawing.Size(296, 21);
      this.cmbColaborador.TabIndex = 3;
      this.cmbColaborador.SelectedIndexChanged += new System.EventHandler(this.cmbColaborador_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(133, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Colaborador";
      // 
      // cmbAno
      // 
      this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbAno.FormattingEnabled = true;
      this.cmbAno.Location = new System.Drawing.Point(133, 32);
      this.cmbAno.Name = "cmbAno";
      this.cmbAno.Size = new System.Drawing.Size(96, 21);
      this.cmbAno.TabIndex = 20;
      this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
      // 
      // cmbMes
      // 
      this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMes.FormattingEnabled = true;
      this.cmbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
      this.cmbMes.Location = new System.Drawing.Point(6, 32);
      this.cmbMes.Name = "cmbMes";
      this.cmbMes.Size = new System.Drawing.Size(120, 21);
      this.cmbMes.TabIndex = 19;
      this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(121, 16);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(26, 13);
      this.label9.TabIndex = 18;
      this.label9.Text = "Ano";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(6, 16);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(27, 13);
      this.label10.TabIndex = 17;
      this.label10.Text = "Mês";
      // 
      // txtTotDesconto
      // 
      this.txtTotDesconto.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTotDesconto.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTotDesconto.AutoTab = true;
      this.txtTotDesconto.Enabled = false;
      this.txtTotDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotDesconto.ForeColor = System.Drawing.Color.Tomato;
      this.txtTotDesconto.Location = new System.Drawing.Point(561, 33);
      this.txtTotDesconto.Name = "txtTotDesconto";
      this.txtTotDesconto.Size = new System.Drawing.Size(120, 20);
      this.txtTotDesconto.TabIndex = 22;
      this.txtTotDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotDesconto.TextFormat = "#,##0.00";
      this.txtTotDesconto.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(558, 16);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(90, 13);
      this.label11.TabIndex = 21;
      this.label11.Text = "Descontos Totais";
      // 
      // txtTotRemuneracao
      // 
      this.txtTotRemuneracao.AsDateTime = new System.DateTime(((long)(0)));
      this.txtTotRemuneracao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtTotRemuneracao.AutoTab = true;
      this.txtTotRemuneracao.Enabled = false;
      this.txtTotRemuneracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotRemuneracao.ForeColor = System.Drawing.Color.RoyalBlue;
      this.txtTotRemuneracao.Location = new System.Drawing.Point(435, 33);
      this.txtTotRemuneracao.Name = "txtTotRemuneracao";
      this.txtTotRemuneracao.Size = new System.Drawing.Size(120, 20);
      this.txtTotRemuneracao.TabIndex = 24;
      this.txtTotRemuneracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotRemuneracao.TextFormat = "#,##0.00";
      this.txtTotRemuneracao.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(432, 16);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(101, 13);
      this.label12.TabIndex = 23;
      this.label12.Text = "Remuneração Total";
      // 
      // txtLiquido
      // 
      this.txtLiquido.AsDateTime = new System.DateTime(((long)(0)));
      this.txtLiquido.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtLiquido.AutoTab = true;
      this.txtLiquido.Enabled = false;
      this.txtLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLiquido.ForeColor = System.Drawing.Color.RoyalBlue;
      this.txtLiquido.Location = new System.Drawing.Point(435, 72);
      this.txtLiquido.Name = "txtLiquido";
      this.txtLiquido.Size = new System.Drawing.Size(246, 20);
      this.txtLiquido.TabIndex = 26;
      this.txtLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtLiquido.TextFormat = "#,##0.00";
      this.txtLiquido.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(435, 56);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(113, 13);
      this.label13.TabIndex = 25;
      this.label13.Text = "Remuneração Líquida";
      // 
      // grdDiario
      // 
      this.grdDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdDiario.ContextMenuStrip = this.cmDiario;
      this.grdDiario.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdDiario.Location = new System.Drawing.Point(3, 16);
      this.grdDiario.Name = "grdDiario";
      this.grdDiario.Size = new System.Drawing.Size(444, 344);
      this.grdDiario.TabIndex = 27;
      this.grdDiario.DoubleClick += new System.EventHandler(this.grdDiario_DoubleClick);
      this.grdDiario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDiario_KeyDown);
      // 
      // cmDiario
      // 
      this.cmDiario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.removerToolStripMenuItem});
      this.cmDiario.Name = "cmDiario";
      this.cmDiario.Size = new System.Drawing.Size(126, 48);
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
      // grdResumo
      // 
      this.grdResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdResumo.ContextMenuStrip = this.cmResumo;
      this.grdResumo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdResumo.Location = new System.Drawing.Point(3, 16);
      this.grdResumo.Name = "grdResumo";
      this.grdResumo.Size = new System.Drawing.Size(228, 344);
      this.grdResumo.TabIndex = 28;
      this.grdResumo.DoubleClick += new System.EventHandler(this.grdResumo_DoubleClick);
      this.grdResumo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdResumo_KeyDown);
      // 
      // cmResumo
      // 
      this.cmResumo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.removerToolStripMenuItem1});
      this.cmResumo.Name = "cmResumo";
      this.cmResumo.Size = new System.Drawing.Size(126, 48);
      // 
      // adicionarToolStripMenuItem1
      // 
      this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
      this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
      this.adicionarToolStripMenuItem1.Text = "Adicionar";
      this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
      // 
      // removerToolStripMenuItem1
      // 
      this.removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
      this.removerToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
      this.removerToolStripMenuItem1.Text = "Remover";
      this.removerToolStripMenuItem1.Click += new System.EventHandler(this.removerToolStripMenuItem1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.btnAtualizar);
      this.groupBox1.Controls.Add(this.label12);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.txtTotDesconto);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtTotRemuneracao);
      this.groupBox1.Controls.Add(this.cmbLoja);
      this.groupBox1.Controls.Add(this.label13);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtLiquido);
      this.groupBox1.Controls.Add(this.cmbColaborador);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.cmbMes);
      this.groupBox1.Controls.Add(this.cmbAno);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(684, 99);
      this.groupBox1.TabIndex = 30;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pesquisa";
      // 
      // btnAtualizar
      // 
      this.btnAtualizar.Location = new System.Drawing.Point(235, 32);
      this.btnAtualizar.Name = "btnAtualizar";
      this.btnAtualizar.Size = new System.Drawing.Size(96, 21);
      this.btnAtualizar.TabIndex = 27;
      this.btnAtualizar.Text = "Atualizar";
      this.btnAtualizar.UseVisualStyleBackColor = true;
      this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.grdDiario);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox2.Location = new System.Drawing.Point(0, 99);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(450, 363);
      this.groupBox2.TabIndex = 31;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Lançamentos Diários";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.grdResumo);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Location = new System.Drawing.Point(450, 99);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(234, 363);
      this.groupBox3.TabIndex = 32;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Resumo Mês";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(337, 32);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(92, 21);
      this.button1.TabIndex = 28;
      this.button1.Text = "Imprimir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmResumo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 462);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "frmResumo";
      this.Text = "Resumo";
      this.Load += new System.EventHandler(this.frmResumo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grdDiario)).EndInit();
      this.cmDiario.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdResumo)).EndInit();
      this.cmResumo.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbLoja;
    private System.Windows.Forms.ComboBox cmbColaborador;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbAno;
    private System.Windows.Forms.ComboBox cmbMes;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private lib.Visual.Components.sknTextBox txtTotDesconto;
    private System.Windows.Forms.Label label11;
    private lib.Visual.Components.sknTextBox txtTotRemuneracao;
    private System.Windows.Forms.Label label12;
    private lib.Visual.Components.sknTextBox txtLiquido;
    private System.Windows.Forms.Label label13;
    private lib.Visual.Components.sknGrid grdDiario;
    private lib.Visual.Components.sknGrid grdResumo;
    private System.Windows.Forms.ContextMenuStrip cmDiario;
    private System.Windows.Forms.ContextMenuStrip cmResumo;
    private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnAtualizar;
    private System.Windows.Forms.Button button1;
  }
}