namespace ControlePortarias
{
  partial class frmMoradia
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.txtCasa = new System.Windows.Forms.TextBox();
      this.txtLote = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtQuadra = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.grdMorador = new System.Windows.Forms.DataGridView();
      this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mnMrd = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.txtRamal = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.grdVisitantes = new System.Windows.Forms.DataGridView();
      this.mnVst = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.removerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DataDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DataAte = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PreAutorizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.pnlEdit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdMorador)).BeginInit();
      this.mnMrd.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdVisitantes)).BeginInit();
      this.mnVst.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.tabControl1);
      this.pnlEdit.Controls.Add(this.txtRamal);
      this.pnlEdit.Controls.Add(this.label5);
      this.pnlEdit.Controls.Add(this.txtQuadra);
      this.pnlEdit.Controls.Add(this.label3);
      this.pnlEdit.Controls.Add(this.txtLote);
      this.pnlEdit.Controls.Add(this.label2);
      this.pnlEdit.Controls.Add(this.txtCasa);
      this.pnlEdit.Controls.Add(this.label1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Casa ";
      // 
      // txtCasa
      // 
      this.txtCasa.Location = new System.Drawing.Point(13, 30);
      this.txtCasa.Name = "txtCasa";
      this.txtCasa.Size = new System.Drawing.Size(100, 20);
      this.txtCasa.TabIndex = 1;
      // 
      // txtLote
      // 
      this.txtLote.Location = new System.Drawing.Point(118, 30);
      this.txtLote.Name = "txtLote";
      this.txtLote.Size = new System.Drawing.Size(100, 20);
      this.txtLote.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(118, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Lote";
      // 
      // txtQuadra
      // 
      this.txtQuadra.Location = new System.Drawing.Point(224, 30);
      this.txtQuadra.Name = "txtQuadra";
      this.txtQuadra.Size = new System.Drawing.Size(100, 20);
      this.txtQuadra.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(224, 14);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Quadra";
      // 
      // grdMorador
      // 
      this.grdMorador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdMorador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Nome,
            this.Celular});
      this.grdMorador.ContextMenuStrip = this.mnMrd;
      this.grdMorador.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdMorador.Location = new System.Drawing.Point(3, 3);
      this.grdMorador.Name = "grdMorador";
      this.grdMorador.Size = new System.Drawing.Size(436, 188);
      this.grdMorador.TabIndex = 6;
      this.grdMorador.DoubleClick += new System.EventHandler(this.grdMorador_DoubleClick);
      this.grdMorador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdMorador_KeyDown);
      // 
      // Titulo
      // 
      this.Titulo.DataPropertyName = "MRD_TITULO";
      this.Titulo.HeaderText = "Titulo";
      this.Titulo.Name = "Titulo";
      this.Titulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // Nome
      // 
      this.Nome.DataPropertyName = "MRD_NOME";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      this.Nome.Width = 180;
      // 
      // Celular
      // 
      this.Celular.DataPropertyName = "MRD_CELULAR";
      this.Celular.HeaderText = "Celular";
      this.Celular.Name = "Celular";
      // 
      // mnMrd
      // 
      this.mnMrd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.removerToolStripMenuItem});
      this.mnMrd.Name = "mnMrd";
      this.mnMrd.Size = new System.Drawing.Size(126, 48);
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
      // txtRamal
      // 
      this.txtRamal.Location = new System.Drawing.Point(330, 30);
      this.txtRamal.Name = "txtRamal";
      this.txtRamal.Size = new System.Drawing.Size(133, 20);
      this.txtRamal.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(330, 14);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Fone / Ramal";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 56);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(450, 220);
      this.tabControl1.TabIndex = 10;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.grdMorador);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(442, 194);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Moradores";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.grdVisitantes);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(442, 194);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Visitantes pré autorizados";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // grdVisitantes
      // 
      this.grdVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DataDe,
            this.DataAte,
            this.PreAutorizado});
      this.grdVisitantes.ContextMenuStrip = this.mnVst;
      this.grdVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdVisitantes.Location = new System.Drawing.Point(3, 3);
      this.grdVisitantes.Name = "grdVisitantes";
      this.grdVisitantes.Size = new System.Drawing.Size(436, 188);
      this.grdVisitantes.TabIndex = 7;
      this.grdVisitantes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdVisitantes_CellFormatting);
      this.grdVisitantes.DoubleClick += new System.EventHandler(this.grdVisitantes_DoubleClick);
      this.grdVisitantes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdVisitantes_KeyDown);
      // 
      // mnVst
      // 
      this.mnVst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.removerToolStripMenuItem1});
      this.mnVst.Name = "mnVst";
      this.mnVst.Size = new System.Drawing.Size(126, 48);
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
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "AUT_TITULO";
      this.dataGridViewTextBoxColumn1.HeaderText = "Titulo";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "AUT_NOME";
      this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 120;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "AUT_TELEFONE";
      this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // DataDe
      // 
      this.DataDe.DataPropertyName = "AUT_DATADE";
      dataGridViewCellStyle1.Format = "dd/MM/yy HH:mm";
      this.DataDe.DefaultCellStyle = dataGridViewCellStyle1;
      this.DataDe.HeaderText = "Data de";
      this.DataDe.Name = "DataDe";
      // 
      // DataAte
      // 
      this.DataAte.DataPropertyName = "AUT_DATAATE";
      dataGridViewCellStyle2.Format = "dd/MM/yy HH:mm";
      this.DataAte.DefaultCellStyle = dataGridViewCellStyle2;
      this.DataAte.HeaderText = "Data ate";
      this.DataAte.Name = "DataAte";
      // 
      // PreAutorizado
      // 
      this.PreAutorizado.DataPropertyName = "AUT_PRE_AUTORIZADO";
      this.PreAutorizado.FalseValue = "false";
      this.PreAutorizado.HeaderText = "Pré Autorizado";
      this.PreAutorizado.Name = "PreAutorizado";
      this.PreAutorizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.PreAutorizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.PreAutorizado.TrueValue = "true";
      // 
      // frmMoradia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 368);
      this.Name = "frmMoradia";
      this.Text = "frmMoradia";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Turnos_Search);
      this.Controls.SetChildIndex(this.pnlEdit, 0);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdMorador)).EndInit();
      this.mnMrd.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdVisitantes)).EndInit();
      this.mnVst.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView grdMorador;
    private System.Windows.Forms.TextBox txtQuadra;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtLote;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCasa;
    private System.Windows.Forms.TextBox txtRamal;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView grdVisitantes;
    private System.Windows.Forms.ContextMenuStrip mnMrd;
    private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip mnVst;
    private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataDe;
    private System.Windows.Forms.DataGridViewTextBoxColumn DataAte;
    private System.Windows.Forms.DataGridViewCheckBoxColumn PreAutorizado;
  }
}