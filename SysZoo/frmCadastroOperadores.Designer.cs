namespace SysZoo
{
  partial class frmCadastroOperadores
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroOperadores));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.cbGerencia = new System.Windows.Forms.CheckBox();
      this.cbCancelarItem = new System.Windows.Forms.CheckBox();
      this.cbCancelarVenda = new System.Windows.Forms.CheckBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.grdOperadores = new System.Windows.Forms.DataGridView();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AcessarGerencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.CancelarItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.CancelarVenda = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.grdOperadores)).BeginInit();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(700, 30);
      this.lblWindowTitle.TabIndex = 0;
      this.lblWindowTitle.Text = "Cadastro de Operadores";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(658, 6);
      this.btnWindowClose.TabIndex = 2;
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(622, 6);
      this.btnWindowMinimize.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 82);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 18);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nome";
      // 
      // txtNome
      // 
      this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNome.Location = new System.Drawing.Point(12, 103);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(197, 26);
      this.txtNome.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 132);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(197, 18);
      this.label2.TabIndex = 6;
      this.label2.Text = "Senha (Somente Números)";
      // 
      // txtSenha
      // 
      this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSenha.Location = new System.Drawing.Point(12, 153);
      this.txtSenha.MaxLength = 8;
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(197, 26);
      this.txtSenha.TabIndex = 7;
      // 
      // cbGerencia
      // 
      this.cbGerencia.AutoSize = true;
      this.cbGerencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbGerencia.Location = new System.Drawing.Point(12, 185);
      this.cbGerencia.Name = "cbGerencia";
      this.cbGerencia.Size = new System.Drawing.Size(107, 17);
      this.cbGerencia.TabIndex = 8;
      this.cbGerencia.Text = "Acessar Gerencia";
      this.cbGerencia.UseVisualStyleBackColor = true;
      // 
      // cbCancelarItem
      // 
      this.cbCancelarItem.AutoSize = true;
      this.cbCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbCancelarItem.Location = new System.Drawing.Point(12, 208);
      this.cbCancelarItem.Name = "cbCancelarItem";
      this.cbCancelarItem.Size = new System.Drawing.Size(137, 17);
      this.cbCancelarItem.TabIndex = 9;
      this.cbCancelarItem.Text = "Cancelar Item da Venda";
      this.cbCancelarItem.UseVisualStyleBackColor = true;
      // 
      // cbCancelarVenda
      // 
      this.cbCancelarVenda.AutoSize = true;
      this.cbCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbCancelarVenda.Location = new System.Drawing.Point(12, 231);
      this.cbCancelarVenda.Name = "cbCancelarVenda";
      this.cbCancelarVenda.Size = new System.Drawing.Size(99, 17);
      this.cbCancelarVenda.TabIndex = 10;
      this.cbCancelarVenda.Text = "Cancelar Venda";
      this.cbCancelarVenda.UseVisualStyleBackColor = true;
      // 
      // btnGravar
      // 
      this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGravar.ForeColor = System.Drawing.Color.White;
      this.btnGravar.Location = new System.Drawing.Point(12, 254);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(197, 38);
      this.btnGravar.TabIndex = 11;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = false;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // grdOperadores
      // 
      this.grdOperadores.AllowUserToAddRows = false;
      this.grdOperadores.AllowUserToDeleteRows = false;
      this.grdOperadores.AllowUserToResizeColumns = false;
      this.grdOperadores.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.grdOperadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.grdOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdOperadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.AcessarGerencia,
            this.CancelarItem,
            this.CancelarVenda});
      this.grdOperadores.Location = new System.Drawing.Point(215, 72);
      this.grdOperadores.Name = "grdOperadores";
      this.grdOperadores.ReadOnly = true;
      this.grdOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdOperadores.Size = new System.Drawing.Size(473, 264);
      this.grdOperadores.TabIndex = 14;
      this.grdOperadores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOperadores_CellDoubleClick);
      // 
      // Nome
      // 
      this.Nome.DataPropertyName = "OPR_NOME";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      this.Nome.Width = 120;
      // 
      // AcessarGerencia
      // 
      this.AcessarGerencia.DataPropertyName = "OPR_GERENCIA";
      this.AcessarGerencia.HeaderText = "Gerência";
      this.AcessarGerencia.Name = "AcessarGerencia";
      this.AcessarGerencia.ReadOnly = true;
      this.AcessarGerencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.AcessarGerencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.AcessarGerencia.Width = 90;
      // 
      // CancelarItem
      // 
      this.CancelarItem.DataPropertyName = "OPR_CANCELAR_ITEM";
      this.CancelarItem.HeaderText = "C. Item";
      this.CancelarItem.Name = "CancelarItem";
      this.CancelarItem.ReadOnly = true;
      this.CancelarItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.CancelarItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.CancelarItem.Width = 90;
      // 
      // CancelarVenda
      // 
      this.CancelarVenda.DataPropertyName = "OPR_CANCELAR_CUPOM";
      this.CancelarVenda.HeaderText = "C. Venda";
      this.CancelarVenda.Name = "CancelarVenda";
      this.CancelarVenda.ReadOnly = true;
      this.CancelarVenda.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.CancelarVenda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.CancelarVenda.Width = 90;
      // 
      // btnNovo
      // 
      this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNovo.ForeColor = System.Drawing.Color.White;
      this.btnNovo.Location = new System.Drawing.Point(12, 41);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(197, 38);
      this.btnNovo.TabIndex = 3;
      this.btnNovo.Text = "Novo";
      this.btnNovo.UseVisualStyleBackColor = false;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExcluir.ForeColor = System.Drawing.Color.White;
      this.btnExcluir.Location = new System.Drawing.Point(12, 298);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(197, 38);
      this.btnExcluir.TabIndex = 12;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = false;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(215, 39);
      this.label5.Name = "label5";
      this.label5.Padding = new System.Windows.Forms.Padding(5);
      this.label5.Size = new System.Drawing.Size(473, 30);
      this.label5.TabIndex = 13;
      this.label5.Text = "Lista de Operadores";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // frmCadastroOperadores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 351);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.grdOperadores);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.cbCancelarVenda);
      this.Controls.Add(this.cbCancelarItem);
      this.Controls.Add(this.cbGerencia);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtNome);
      this.Name = "frmCadastroOperadores";
      this.Text = "frmCadastroOperadores";
      this.Load += new System.EventHandler(this.frmCadastroOperadores_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.txtNome, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.txtSenha, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.cbGerencia, 0);
      this.Controls.SetChildIndex(this.cbCancelarItem, 0);
      this.Controls.SetChildIndex(this.cbCancelarVenda, 0);
      this.Controls.SetChildIndex(this.btnGravar, 0);
      this.Controls.SetChildIndex(this.grdOperadores, 0);
      this.Controls.SetChildIndex(this.btnNovo, 0);
      this.Controls.SetChildIndex(this.btnExcluir, 0);
      this.Controls.SetChildIndex(this.label5, 0);
      ((System.ComponentModel.ISupportInitialize)(this.grdOperadores)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.CheckBox cbGerencia;
    private System.Windows.Forms.CheckBox cbCancelarItem;
    private System.Windows.Forms.CheckBox cbCancelarVenda;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.DataGridView grdOperadores;
    private System.Windows.Forms.Button btnNovo;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewCheckBoxColumn AcessarGerencia;
    private System.Windows.Forms.DataGridViewCheckBoxColumn CancelarItem;
    private System.Windows.Forms.DataGridViewCheckBoxColumn CancelarVenda;
  }
}