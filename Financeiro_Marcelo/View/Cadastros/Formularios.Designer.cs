namespace Financeiro_Marcelo.View.Cadastros
{
  partial class Formularios
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.sknGroupBox1 = new lib.Visual.Components.sknGroupBox();
      this.txtData = new lib.Visual.Components.sknMaskedTextBox();
      this.txtNrFormulario = new lib.Visual.Components.sknTextBox();
      this.sknLabel4 = new lib.Visual.Components.sknLabel();
      this.btnEditar = new lib.Visual.Components.sknButton();
      this.sknLabel3 = new lib.Visual.Components.sknLabel();
      this.sknLabel2 = new lib.Visual.Components.sknLabel();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.cmbEmpresa = new lib.Visual.Components.sknComboBox();
      this.lstLancamentos = new lib.Visual.Components.sknGrid();
      this.cmForms = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.exibirRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sknButton1 = new lib.Visual.Components.sknButton();
      this.sknGroupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstLancamentos)).BeginInit();
      this.cmForms.SuspendLayout();
      this.SuspendLayout();
      // 
      // sknGroupBox1
      // 
      this.sknGroupBox1.Controls.Add(this.sknButton1);
      this.sknGroupBox1.Controls.Add(this.txtData);
      this.sknGroupBox1.Controls.Add(this.txtNrFormulario);
      this.sknGroupBox1.Controls.Add(this.sknLabel4);
      this.sknGroupBox1.Controls.Add(this.btnEditar);
      this.sknGroupBox1.Controls.Add(this.sknLabel3);
      this.sknGroupBox1.Controls.Add(this.sknLabel2);
      this.sknGroupBox1.Controls.Add(this.sknLabel1);
      this.sknGroupBox1.Controls.Add(this.cmbEmpresa);
      this.sknGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.sknGroupBox1.Location = new System.Drawing.Point(0, 0);
      this.sknGroupBox1.Name = "sknGroupBox1";
      this.sknGroupBox1.Size = new System.Drawing.Size(734, 79);
      this.sknGroupBox1.TabIndex = 2;
      this.sknGroupBox1.TabStop = false;
      // 
      // txtData
      // 
      this.txtData.AsDateTime = new System.DateTime(((long)(0)));
      this.txtData.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtData.AutoTab = true;
      this.txtData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
      this.txtData.Location = new System.Drawing.Point(295, 32);
      this.txtData.Mask = "00/00/0000";
      this.txtData.Name = "txtData";
      this.txtData.Size = new System.Drawing.Size(100, 20);
      this.txtData.TabIndex = 5;
      this.txtData.TextFormat = "dd/MM/yyyy";
      this.txtData.TextType = lib.Visual.Components.enmTextType.DateTime;
      this.txtData.ValidatingType = typeof(System.DateTime);
      // 
      // txtNrFormulario
      // 
      this.txtNrFormulario.AsDateTime = new System.DateTime(((long)(0)));
      this.txtNrFormulario.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtNrFormulario.AutoTab = true;
      this.txtNrFormulario.Location = new System.Drawing.Point(168, 33);
      this.txtNrFormulario.Name = "txtNrFormulario";
      this.txtNrFormulario.Size = new System.Drawing.Size(121, 20);
      this.txtNrFormulario.TabIndex = 3;
      this.txtNrFormulario.Text = "0";
      this.txtNrFormulario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtNrFormulario.TextFormat = null;
      this.txtNrFormulario.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // sknLabel4
      // 
      this.sknLabel4.AutoSize = true;
      this.sknLabel4.Location = new System.Drawing.Point(295, 17);
      this.sknLabel4.Name = "sknLabel4";
      this.sknLabel4.Size = new System.Drawing.Size(30, 13);
      this.sknLabel4.TabIndex = 4;
      this.sknLabel4.Text = "Data";
      // 
      // btnEditar
      // 
      this.btnEditar.Location = new System.Drawing.Point(401, 30);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(110, 23);
      this.btnEditar.TabIndex = 6;
      this.btnEditar.Text = "Exibir / Editar";
      this.btnEditar.UseVisualStyleBackColor = true;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // sknLabel3
      // 
      this.sknLabel3.AutoSize = true;
      this.sknLabel3.Location = new System.Drawing.Point(6, 56);
      this.sknLabel3.Name = "sknLabel3";
      this.sknLabel3.Size = new System.Drawing.Size(108, 13);
      this.sknLabel3.TabIndex = 7;
      this.sknLabel3.Text = "Últimos Lançamentos";
      // 
      // sknLabel2
      // 
      this.sknLabel2.AutoSize = true;
      this.sknLabel2.Location = new System.Drawing.Point(165, 16);
      this.sknLabel2.Name = "sknLabel2";
      this.sknLabel2.Size = new System.Drawing.Size(78, 13);
      this.sknLabel2.TabIndex = 2;
      this.sknLabel2.Text = "Nro. Formulário";
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(6, 16);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(77, 13);
      this.sknLabel1.TabIndex = 0;
      this.sknLabel1.Text = "Empresa (Loja)";
      // 
      // cmbEmpresa
      // 
      this.cmbEmpresa.AutoTab = true;
      this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbEmpresa.FormattingEnabled = true;
      this.cmbEmpresa.Location = new System.Drawing.Point(9, 32);
      this.cmbEmpresa.Name = "cmbEmpresa";
      this.cmbEmpresa.Size = new System.Drawing.Size(153, 21);
      this.cmbEmpresa.TabIndex = 1;
      this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
      // 
      // lstLancamentos
      // 
      this.lstLancamentos.AllowUserToAddRows = false;
      this.lstLancamentos.AllowUserToOrderColumns = true;
      this.lstLancamentos.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
      this.lstLancamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.lstLancamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
      this.lstLancamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.lstLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.lstLancamentos.ContextMenuStrip = this.cmForms;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.lstLancamentos.DefaultCellStyle = dataGridViewCellStyle2;
      this.lstLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstLancamentos.Location = new System.Drawing.Point(0, 79);
      this.lstLancamentos.MultiSelect = false;
      this.lstLancamentos.Name = "lstLancamentos";
      this.lstLancamentos.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.lstLancamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.lstLancamentos.RowHeadersVisible = false;
      this.lstLancamentos.RowHeadersWidth = 50;
      this.lstLancamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
      this.lstLancamentos.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.lstLancamentos.RowTemplate.Height = 20;
      this.lstLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.lstLancamentos.Size = new System.Drawing.Size(734, 363);
      this.lstLancamentos.TabIndex = 9;
      this.lstLancamentos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.lstLancamentos_RowEnter);
      this.lstLancamentos.DoubleClick += new System.EventHandler(this.lstLancamentos_DoubleClick);
      this.lstLancamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstLancamentos_KeyDown);
      // 
      // cmForms
      // 
      this.cmForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirRelatórioToolStripMenuItem,
            this.excluirToolStripMenuItem});
      this.cmForms.Name = "contextMenuStrip1";
      this.cmForms.Size = new System.Drawing.Size(153, 70);
      // 
      // exibirRelatórioToolStripMenuItem
      // 
      this.exibirRelatórioToolStripMenuItem.Name = "exibirRelatórioToolStripMenuItem";
      this.exibirRelatórioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exibirRelatórioToolStripMenuItem.Text = "Exibir Relatório";
      this.exibirRelatórioToolStripMenuItem.Click += new System.EventHandler(this.exibirRelatórioToolStripMenuItem_Click);
      // 
      // excluirToolStripMenuItem
      // 
      this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
      this.excluirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.excluirToolStripMenuItem.Text = "Excluir";
      this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
      // 
      // sknButton1
      // 
      this.sknButton1.Location = new System.Drawing.Point(517, 29);
      this.sknButton1.Name = "sknButton1";
      this.sknButton1.Size = new System.Drawing.Size(110, 23);
      this.sknButton1.TabIndex = 8;
      this.sknButton1.Text = "Visualizar Itens";
      this.sknButton1.UseVisualStyleBackColor = true;
      this.sknButton1.Click += new System.EventHandler(this.sknButton1_Click);
      // 
      // Formularios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(734, 442);
      this.Controls.Add(this.lstLancamentos);
      this.Controls.Add(this.sknGroupBox1);
      this.Name = "Formularios";
      this.Text = "Formularios";
      this.Load += new System.EventHandler(this.Formularios_Load);
      this.sknGroupBox1.ResumeLayout(false);
      this.sknGroupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstLancamentos)).EndInit();
      this.cmForms.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknGroupBox sknGroupBox1;
    private lib.Visual.Components.sknMaskedTextBox txtData;
    private lib.Visual.Components.sknTextBox txtNrFormulario;
    private lib.Visual.Components.sknLabel sknLabel4;
    private lib.Visual.Components.sknButton btnEditar;
    private lib.Visual.Components.sknLabel sknLabel3;
    private lib.Visual.Components.sknLabel sknLabel2;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknComboBox cmbEmpresa;
    private lib.Visual.Components.sknGrid lstLancamentos;
    private System.Windows.Forms.ContextMenuStrip cmForms;
    private System.Windows.Forms.ToolStripMenuItem exibirRelatórioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    private lib.Visual.Components.sknButton sknButton1;
  }
}