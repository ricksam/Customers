namespace Financeiro_Marcelo
{
  partial class BaixaConta
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtTotal = new lib.Visual.Components.sknTextBox();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.dtVenc = new System.Windows.Forms.DateTimePicker();
      this.btnSair = new lib.Visual.Components.sknButton();
      this.btnBaixa = new lib.Visual.Components.sknButton();
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.grdLancamentos = new lib.Visual.Components.sknGrid();
      this.panel3 = new System.Windows.Forms.Panel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.btnSalvar = new lib.Visual.Components.sknButton();
      this.lblTotPesquisa = new lib.Visual.Components.sknLabel();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdLancamentos)).BeginInit();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtTotal);
      this.panel1.Controls.Add(this.sknLabel2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.dtVenc);
      this.panel1.Controls.Add(this.btnSair);
      this.panel1.Controls.Add(this.btnBaixa);
      this.panel1.Controls.Add(this.cmbEmpresa);
      this.panel1.Controls.Add(this.sknLabel1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(742, 63);
      this.panel1.TabIndex = 0;
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
      this.txtTotal.Location = new System.Drawing.Point(366, 25);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(120, 20);
      this.txtTotal.TabIndex = 1;
      this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtTotal.TextFormat = "#,##0.00";
      this.txtTotal.TextType = lib.Visual.Components.enmTextType.Decimal;
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(329, 28);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(31, 13);
      this.sknLabel2.TabIndex = 0;
      this.sknLabel2.Text = "Total";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(205, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Até a data";
      // 
      // dtVenc
      // 
      this.dtVenc.CustomFormat = "dd/MM/yyyy";
      this.dtVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtVenc.Location = new System.Drawing.Point(208, 25);
      this.dtVenc.Name = "dtVenc";
      this.dtVenc.Size = new System.Drawing.Size(115, 20);
      this.dtVenc.TabIndex = 3;
      this.dtVenc.ValueChanged += new System.EventHandler(this.dtVenc_ValueChanged);
      // 
      // btnSair
      // 
      this.btnSair.Location = new System.Drawing.Point(573, 23);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(75, 23);
      this.btnSair.TabIndex = 5;
      this.btnSair.Text = "Sair";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.sknButton2_Click);
      // 
      // btnBaixa
      // 
      this.btnBaixa.Location = new System.Drawing.Point(492, 23);
      this.btnBaixa.Name = "btnBaixa";
      this.btnBaixa.Size = new System.Drawing.Size(75, 23);
      this.btnBaixa.TabIndex = 4;
      this.btnBaixa.Text = "Baixar";
      this.btnBaixa.UseVisualStyleBackColor = true;
      this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(12, 25);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(190, 21);
      this.cmbEmpresa.TabIndex = 1;
      this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
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
      // panel2
      // 
      this.panel2.Controls.Add(this.grdLancamentos);
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 63);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(742, 453);
      this.panel2.TabIndex = 1;
      // 
      // grdLancamentos
      // 
      this.grdLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdLancamentos.Location = new System.Drawing.Point(0, 0);
      this.grdLancamentos.Name = "grdLancamentos";
      this.grdLancamentos.Size = new System.Drawing.Size(742, 413);
      this.grdLancamentos.TabIndex = 0;
      this.grdLancamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLancamentos_CellContentClick);
      this.grdLancamentos.DoubleClick += new System.EventHandler(this.grdLancamentos_DoubleClick);
      this.grdLancamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdLancamentos_KeyDown);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.lblTotPesquisa);
      this.panel3.Controls.Add(this.sknLabel3);
      this.panel3.Controls.Add(this.btnSalvar);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, 413);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(742, 40);
      this.panel3.TabIndex = 1;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(186, 11);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(329, 13);
      this.sknLabel3.TabIndex = 1;
      this.sknLabel3.Text = "(Pressione [Enter] ou duplo clique para editar o valor do lançamento)";
      // 
      // btnSalvar
      // 
      this.btnSalvar.Location = new System.Drawing.Point(12, 6);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(168, 23);
      this.btnSalvar.TabIndex = 0;
      this.btnSalvar.Text = "Salvar itens selecionados";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // lblTotPesquisa
      // 
      this.lblTotPesquisa.AutoSize = true;
      this.lblTotPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTotPesquisa.Location = new System.Drawing.Point(521, 11);
      this.lblTotPesquisa.Name = "lblTotPesquisa";
      this.lblTotPesquisa.Size = new System.Drawing.Size(109, 13);
      this.lblTotPesquisa.TabIndex = 2;
      this.lblTotPesquisa.Text = "Total Pesquisado:";
      // 
      // BaixaConta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(742, 516);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "BaixaConta";
      this.Text = "BaixaConta";
      this.Load += new System.EventHandler(this.BaixaConta_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdLancamentos)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private lib.Visual.Components.sknButton btnSair;
    private lib.Visual.Components.sknButton btnBaixa;
    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknGrid grdLancamentos;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtVenc;
    private System.Windows.Forms.Panel panel3;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknTextBox txtTotal;
    private lib.Visual.Components.sknButton btnSalvar;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknLabel lblTotPesquisa;
  }
}