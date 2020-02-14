namespace Financeiro_Marcelo
{
  partial class PlanoContas
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanoContas));
      this.pnlEdicao = new System.Windows.Forms.Panel();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.btnAdicionar = new lib.Visual.Components.sknButton();
      this.lstPlano = new lib.Visual.Components.sknGrid();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.cmbTipo = new lib.Visual.Components.sknComboBox();
      this.txtCategoria = new lib.Visual.Components.sknTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.btnCancelar = new lib.Visual.Components.sknButton();
      this.btnSalvar = new lib.Visual.Components.sknButton();
      this.pnlList = new System.Windows.Forms.Panel();
      this.sknPanel1 = new lib.Visual.Components.sknPanel();
      this.btnExcluir = new lib.Visual.Components.sknButton();
      this.btnAlterar = new lib.Visual.Components.sknButton();
      this.btnNovo = new lib.Visual.Components.sknButton();
      this.lstCategorias = new lib.Visual.Components.sknGrid();
      this.pnlEdicao.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstPlano)).BeginInit();
      this.pnlList.SuspendLayout();
      this.sknPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlEdicao
      // 
      this.pnlEdicao.Controls.Add(this.sknLabel3);
      this.pnlEdicao.Controls.Add(this.btnAdicionar);
      this.pnlEdicao.Controls.Add(this.lstPlano);
      this.pnlEdicao.Controls.Add(this.sknLabel2);
      this.pnlEdicao.Controls.Add(this.cmbTipo);
      this.pnlEdicao.Controls.Add(this.txtCategoria);
      this.pnlEdicao.Controls.Add(this.sknLabel1);
      this.pnlEdicao.Controls.Add(this.btnCancelar);
      this.pnlEdicao.Controls.Add(this.btnSalvar);
      this.pnlEdicao.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlEdicao.Location = new System.Drawing.Point(0, 185);
      this.pnlEdicao.Name = "pnlEdicao";
      this.pnlEdicao.Size = new System.Drawing.Size(534, 327);
      this.pnlEdicao.TabIndex = 0;
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(12, 52);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(444, 13);
      this.sknLabel3.TabIndex = 8;
      this.sknLabel3.Text = "Pressione [Enter] para alterar o plano de contas e [Delete] para remover um plano" +
          " de contas.";
      // 
      // btnAdicionar
      // 
      this.btnAdicionar.Location = new System.Drawing.Point(382, 26);
      this.btnAdicionar.Name = "btnAdicionar";
      this.btnAdicionar.Size = new System.Drawing.Size(140, 23);
      this.btnAdicionar.TabIndex = 7;
      this.btnAdicionar.Text = "&Adicionar plano de contas";
      this.btnAdicionar.UseVisualStyleBackColor = true;
      this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
      // 
      // lstPlano
      // 
      this.lstPlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.lstPlano.Location = new System.Drawing.Point(12, 68);
      this.lstPlano.Name = "lstPlano";
      this.lstPlano.Size = new System.Drawing.Size(510, 218);
      this.lstPlano.TabIndex = 6;
      this.lstPlano.DoubleClick += new System.EventHandler(this.lstPlano_DoubleClick);
      this.lstPlano.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPlano_KeyDown);
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(252, 12);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(28, 13);
      this.sknLabel2.TabIndex = 5;
      this.sknLabel2.Text = "Tipo";
      // 
      // cmbTipo
      // 
      this.cmbTipo.AutoTab = true;
      this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Items.AddRange(new object[] {
            "Receita",
            "Despesa"});
      this.cmbTipo.Location = new System.Drawing.Point(255, 28);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new System.Drawing.Size(121, 21);
      this.cmbTipo.TabIndex = 4;
      // 
      // txtCategoria
      // 
      this.txtCategoria.AsDateTime = new System.DateTime(2011, 6, 18, 8, 53, 39, 447);
      this.txtCategoria.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtCategoria.AutoTab = true;
      this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtCategoria.Location = new System.Drawing.Point(12, 29);
      this.txtCategoria.Name = "txtCategoria";
      this.txtCategoria.Size = new System.Drawing.Size(237, 20);
      this.txtCategoria.TabIndex = 3;
      this.txtCategoria.TextFormat = null;
      this.txtCategoria.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 12);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(52, 13);
      this.sknLabel1.TabIndex = 2;
      this.sknLabel1.Text = "Categoria";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(93, 292);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 1;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnSalvar
      // 
      this.btnSalvar.Location = new System.Drawing.Point(12, 292);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(75, 23);
      this.btnSalvar.TabIndex = 0;
      this.btnSalvar.Text = "&Salvar";
      this.btnSalvar.UseVisualStyleBackColor = true;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // pnlList
      // 
      this.pnlList.Controls.Add(this.sknPanel1);
      this.pnlList.Controls.Add(this.lstCategorias);
      this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlList.Location = new System.Drawing.Point(0, 0);
      this.pnlList.Name = "pnlList";
      this.pnlList.Size = new System.Drawing.Size(534, 185);
      this.pnlList.TabIndex = 1;
      // 
      // sknPanel1
      // 
      this.sknPanel1.Controls.Add(this.btnExcluir);
      this.sknPanel1.Controls.Add(this.btnAlterar);
      this.sknPanel1.Controls.Add(this.btnNovo);
      this.sknPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.sknPanel1.Location = new System.Drawing.Point(0, 141);
      this.sknPanel1.Name = "sknPanel1";
      this.sknPanel1.Size = new System.Drawing.Size(534, 44);
      this.sknPanel1.TabIndex = 1;
      // 
      // btnExcluir
      // 
      this.btnExcluir.Location = new System.Drawing.Point(174, 11);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(75, 23);
      this.btnExcluir.TabIndex = 2;
      this.btnExcluir.Text = "&Remover";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnAlterar
      // 
      this.btnAlterar.Location = new System.Drawing.Point(93, 11);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(75, 23);
      this.btnAlterar.TabIndex = 1;
      this.btnAlterar.Text = "&Editar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // btnNovo
      // 
      this.btnNovo.Location = new System.Drawing.Point(12, 11);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(75, 23);
      this.btnNovo.TabIndex = 0;
      this.btnNovo.Text = "&Novo";
      this.btnNovo.UseVisualStyleBackColor = true;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // lstCategorias
      // 
      this.lstCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.lstCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstCategorias.Location = new System.Drawing.Point(0, 0);
      this.lstCategorias.Name = "lstCategorias";
      this.lstCategorias.Size = new System.Drawing.Size(534, 185);
      this.lstCategorias.TabIndex = 0;
      // 
      // PlanoContas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(534, 512);
      this.Controls.Add(this.pnlList);
      this.Controls.Add(this.pnlEdicao);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "PlanoContas";
      this.Text = "Plano de Contas";
      this.Load += new System.EventHandler(this.PlanoContas_Load);
      this.pnlEdicao.ResumeLayout(false);
      this.pnlEdicao.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstPlano)).EndInit();
      this.pnlList.ResumeLayout(false);
      this.sknPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.lstCategorias)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlEdicao;
    private System.Windows.Forms.Panel pnlList;
    private lib.Visual.Components.sknGrid lstCategorias;
    private lib.Visual.Components.sknPanel sknPanel1;
    private lib.Visual.Components.sknTextBox txtCategoria;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknButton btnCancelar;
    private lib.Visual.Components.sknButton btnSalvar;
    private lib.Visual.Components.sknButton btnExcluir;
    private lib.Visual.Components.sknButton btnAlterar;
    private lib.Visual.Components.sknButton btnNovo;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknComboBox cmbTipo;
    private lib.Visual.Components.sknGrid lstPlano;
    private lib.Visual.Components.sknButton btnAdicionar;
    private lib.Visual.Components.sknLabel sknLabel3;
  }
}