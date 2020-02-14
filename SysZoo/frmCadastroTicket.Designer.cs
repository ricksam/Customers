namespace SysZoo
{
  partial class frmCadastroTicket
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTicket));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.txtDescricao = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbDOM = new System.Windows.Forms.CheckBox();
      this.cbSEG = new System.Windows.Forms.CheckBox();
      this.cbTER = new System.Windows.Forms.CheckBox();
      this.cbQUA = new System.Windows.Forms.CheckBox();
      this.cbQUI = new System.Windows.Forms.CheckBox();
      this.cbSEX = new System.Windows.Forms.CheckBox();
      this.cbSAB = new System.Windows.Forms.CheckBox();
      this.btnNovo = new System.Windows.Forms.Button();
      this.btnGravar = new System.Windows.Forms.Button();
      this.grdTickets = new System.Windows.Forms.DataGridView();
      this.label3 = new System.Windows.Forms.Label();
      this.txtValor = new System.Windows.Forms.TextBox();
      this.btnMarcarTodos = new System.Windows.Forms.Button();
      this.btnDesmarcarTodos = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtAtalho = new System.Windows.Forms.TextBox();
      this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Atalho = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DOM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.SEG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.TER = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.QUA = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.QUI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.SEX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.SAB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).BeginInit();
      this.SuspendLayout();
      // 
      // lblWindowTitle
      // 
      this.lblWindowTitle.Size = new System.Drawing.Size(613, 30);
      this.lblWindowTitle.Text = "Cadastro de Tickets";
      // 
      // btnWindowClose
      // 
      this.btnWindowClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowClose.BackgroundImage")));
      this.btnWindowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
      this.btnWindowClose.Location = new System.Drawing.Point(571, 6);
      // 
      // btnWindowMinimize
      // 
      this.btnWindowMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowMinimize.BackgroundImage")));
      this.btnWindowMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnWindowMinimize.Location = new System.Drawing.Point(535, 6);
      // 
      // txtDescricao
      // 
      this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescricao.Location = new System.Drawing.Point(12, 60);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(211, 26);
      this.txtDescricao.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 18);
      this.label1.TabIndex = 3;
      this.label1.Text = "Descricao";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 89);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(70, 18);
      this.label2.TabIndex = 9;
      this.label2.Text = "Validade";
      // 
      // cbDOM
      // 
      this.cbDOM.AutoSize = true;
      this.cbDOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbDOM.Location = new System.Drawing.Point(12, 146);
      this.cbDOM.Name = "cbDOM";
      this.cbDOM.Size = new System.Drawing.Size(48, 17);
      this.cbDOM.TabIndex = 12;
      this.cbDOM.Text = "DOM";
      this.cbDOM.UseVisualStyleBackColor = true;
      // 
      // cbSEG
      // 
      this.cbSEG.AutoSize = true;
      this.cbSEG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbSEG.Location = new System.Drawing.Point(69, 146);
      this.cbSEG.Name = "cbSEG";
      this.cbSEG.Size = new System.Drawing.Size(45, 17);
      this.cbSEG.TabIndex = 13;
      this.cbSEG.Text = "SEG";
      this.cbSEG.UseVisualStyleBackColor = true;
      // 
      // cbTER
      // 
      this.cbTER.AutoSize = true;
      this.cbTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbTER.Location = new System.Drawing.Point(126, 146);
      this.cbTER.Name = "cbTER";
      this.cbTER.Size = new System.Drawing.Size(45, 17);
      this.cbTER.TabIndex = 14;
      this.cbTER.Text = "TER";
      this.cbTER.UseVisualStyleBackColor = true;
      // 
      // cbQUA
      // 
      this.cbQUA.AutoSize = true;
      this.cbQUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbQUA.Location = new System.Drawing.Point(183, 146);
      this.cbQUA.Name = "cbQUA";
      this.cbQUA.Size = new System.Drawing.Size(46, 17);
      this.cbQUA.TabIndex = 15;
      this.cbQUA.Text = "QUA";
      this.cbQUA.UseVisualStyleBackColor = true;
      // 
      // cbQUI
      // 
      this.cbQUI.AutoSize = true;
      this.cbQUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbQUI.Location = new System.Drawing.Point(240, 146);
      this.cbQUI.Name = "cbQUI";
      this.cbQUI.Size = new System.Drawing.Size(42, 17);
      this.cbQUI.TabIndex = 16;
      this.cbQUI.Text = "QUI";
      this.cbQUI.UseVisualStyleBackColor = true;
      // 
      // cbSEX
      // 
      this.cbSEX.AutoSize = true;
      this.cbSEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbSEX.Location = new System.Drawing.Point(297, 146);
      this.cbSEX.Name = "cbSEX";
      this.cbSEX.Size = new System.Drawing.Size(44, 17);
      this.cbSEX.TabIndex = 17;
      this.cbSEX.Text = "SEX";
      this.cbSEX.UseVisualStyleBackColor = true;
      // 
      // cbSAB
      // 
      this.cbSAB.AutoSize = true;
      this.cbSAB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.cbSAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbSAB.Location = new System.Drawing.Point(354, 146);
      this.cbSAB.Name = "cbSAB";
      this.cbSAB.Size = new System.Drawing.Size(44, 17);
      this.cbSAB.TabIndex = 18;
      this.cbSAB.Text = "SAB";
      this.cbSAB.UseVisualStyleBackColor = true;
      // 
      // btnNovo
      // 
      this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNovo.ForeColor = System.Drawing.Color.White;
      this.btnNovo.Location = new System.Drawing.Point(441, 39);
      this.btnNovo.Name = "btnNovo";
      this.btnNovo.Size = new System.Drawing.Size(160, 38);
      this.btnNovo.TabIndex = 19;
      this.btnNovo.Text = "Novo";
      this.btnNovo.UseVisualStyleBackColor = false;
      this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
      // 
      // btnGravar
      // 
      this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGravar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGravar.ForeColor = System.Drawing.Color.White;
      this.btnGravar.Location = new System.Drawing.Point(441, 83);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(160, 38);
      this.btnGravar.TabIndex = 20;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = false;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // grdTickets
      // 
      this.grdTickets.AllowUserToAddRows = false;
      this.grdTickets.AllowUserToDeleteRows = false;
      this.grdTickets.AllowUserToResizeColumns = false;
      this.grdTickets.AllowUserToResizeRows = false;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.grdTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.grdTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Atalho,
            this.Valor,
            this.DOM,
            this.SEG,
            this.TER,
            this.QUA,
            this.QUI,
            this.SEX,
            this.SAB});
      this.grdTickets.Location = new System.Drawing.Point(12, 208);
      this.grdTickets.Name = "grdTickets";
      this.grdTickets.ReadOnly = true;
      this.grdTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdTickets.Size = new System.Drawing.Size(589, 230);
      this.grdTickets.TabIndex = 23;
      this.grdTickets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTickets_CellDoubleClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(226, 39);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 18);
      this.label3.TabIndex = 5;
      this.label3.Text = "Valor";
      // 
      // txtValor
      // 
      this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValor.Location = new System.Drawing.Point(229, 60);
      this.txtValor.Name = "txtValor";
      this.txtValor.Size = new System.Drawing.Size(101, 26);
      this.txtValor.TabIndex = 6;
      this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnMarcarTodos
      // 
      this.btnMarcarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnMarcarTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnMarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMarcarTodos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMarcarTodos.ForeColor = System.Drawing.Color.White;
      this.btnMarcarTodos.Location = new System.Drawing.Point(12, 110);
      this.btnMarcarTodos.Name = "btnMarcarTodos";
      this.btnMarcarTodos.Size = new System.Drawing.Size(212, 30);
      this.btnMarcarTodos.TabIndex = 10;
      this.btnMarcarTodos.Text = "Marcar todos";
      this.btnMarcarTodos.UseVisualStyleBackColor = false;
      this.btnMarcarTodos.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnDesmarcarTodos
      // 
      this.btnDesmarcarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnDesmarcarTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnDesmarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDesmarcarTodos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDesmarcarTodos.ForeColor = System.Drawing.Color.White;
      this.btnDesmarcarTodos.Location = new System.Drawing.Point(230, 110);
      this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
      this.btnDesmarcarTodos.Size = new System.Drawing.Size(205, 30);
      this.btnDesmarcarTodos.TabIndex = 11;
      this.btnDesmarcarTodos.Text = "Desmarcar todos";
      this.btnDesmarcarTodos.UseVisualStyleBackColor = false;
      this.btnDesmarcarTodos.Click += new System.EventHandler(this.button3_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExcluir.ForeColor = System.Drawing.Color.White;
      this.btnExcluir.Location = new System.Drawing.Point(441, 125);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(160, 38);
      this.btnExcluir.TabIndex = 21;
      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.UseVisualStyleBackColor = false;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
      this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(12, 175);
      this.label5.Name = "label5";
      this.label5.Padding = new System.Windows.Forms.Padding(5);
      this.label5.Size = new System.Drawing.Size(589, 30);
      this.label5.TabIndex = 22;
      this.label5.Text = "Lista de Tickets";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(333, 39);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 18);
      this.label4.TabIndex = 7;
      this.label4.Text = "Atalho";
      // 
      // txtAtalho
      // 
      this.txtAtalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtAtalho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtAtalho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAtalho.Location = new System.Drawing.Point(336, 60);
      this.txtAtalho.Name = "txtAtalho";
      this.txtAtalho.Size = new System.Drawing.Size(99, 26);
      this.txtAtalho.TabIndex = 8;
      // 
      // Descricao
      // 
      this.Descricao.DataPropertyName = "CTK_DESCRICAO";
      this.Descricao.HeaderText = "Descrição";
      this.Descricao.Name = "Descricao";
      this.Descricao.ReadOnly = true;
      this.Descricao.Width = 120;
      // 
      // Atalho
      // 
      this.Atalho.DataPropertyName = "CTK_ATALHO";
      this.Atalho.HeaderText = "Atalho";
      this.Atalho.Name = "Atalho";
      this.Atalho.ReadOnly = true;
      this.Atalho.Width = 60;
      // 
      // Valor
      // 
      this.Valor.DataPropertyName = "CTK_VALOR";
      this.Valor.HeaderText = "Valor";
      this.Valor.Name = "Valor";
      this.Valor.ReadOnly = true;
      this.Valor.Width = 60;
      // 
      // DOM
      // 
      this.DOM.DataPropertyName = "CTK_DOM";
      this.DOM.HeaderText = "DOM";
      this.DOM.Name = "DOM";
      this.DOM.ReadOnly = true;
      this.DOM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.DOM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.DOM.Width = 40;
      // 
      // SEG
      // 
      this.SEG.DataPropertyName = "CTK_SEG";
      this.SEG.HeaderText = "SEG";
      this.SEG.Name = "SEG";
      this.SEG.ReadOnly = true;
      this.SEG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.SEG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.SEG.Width = 40;
      // 
      // TER
      // 
      this.TER.DataPropertyName = "CTK_TER";
      this.TER.HeaderText = "TER";
      this.TER.Name = "TER";
      this.TER.ReadOnly = true;
      this.TER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.TER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.TER.Width = 40;
      // 
      // QUA
      // 
      this.QUA.DataPropertyName = "CTK_QUA";
      this.QUA.HeaderText = "QUA";
      this.QUA.Name = "QUA";
      this.QUA.ReadOnly = true;
      this.QUA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.QUA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.QUA.Width = 40;
      // 
      // QUI
      // 
      this.QUI.DataPropertyName = "CTK_QUI";
      this.QUI.HeaderText = "QUI";
      this.QUI.Name = "QUI";
      this.QUI.ReadOnly = true;
      this.QUI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.QUI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.QUI.Width = 40;
      // 
      // SEX
      // 
      this.SEX.DataPropertyName = "CTK_SEX";
      this.SEX.HeaderText = "SEX";
      this.SEX.Name = "SEX";
      this.SEX.ReadOnly = true;
      this.SEX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.SEX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.SEX.Width = 40;
      // 
      // SAB
      // 
      this.SAB.DataPropertyName = "CTK_SAB";
      this.SAB.HeaderText = "SAB";
      this.SAB.Name = "SAB";
      this.SAB.ReadOnly = true;
      this.SAB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.SAB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.SAB.Width = 40;
      // 
      // frmCadastroTicket
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(613, 450);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtAtalho);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnDesmarcarTodos);
      this.Controls.Add(this.btnMarcarTodos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtValor);
      this.Controls.Add(this.grdTickets);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.btnNovo);
      this.Controls.Add(this.cbSAB);
      this.Controls.Add(this.cbSEX);
      this.Controls.Add(this.cbQUI);
      this.Controls.Add(this.cbQUA);
      this.Controls.Add(this.cbTER);
      this.Controls.Add(this.cbSEG);
      this.Controls.Add(this.cbDOM);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDescricao);
      this.Name = "frmCadastroTicket";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmCadastroTicket_Load);
      this.Controls.SetChildIndex(this.lblWindowTitle, 0);
      this.Controls.SetChildIndex(this.btnWindowClose, 0);
      this.Controls.SetChildIndex(this.btnWindowMinimize, 0);
      this.Controls.SetChildIndex(this.txtDescricao, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.cbDOM, 0);
      this.Controls.SetChildIndex(this.cbSEG, 0);
      this.Controls.SetChildIndex(this.cbTER, 0);
      this.Controls.SetChildIndex(this.cbQUA, 0);
      this.Controls.SetChildIndex(this.cbQUI, 0);
      this.Controls.SetChildIndex(this.cbSEX, 0);
      this.Controls.SetChildIndex(this.cbSAB, 0);
      this.Controls.SetChildIndex(this.btnNovo, 0);
      this.Controls.SetChildIndex(this.btnGravar, 0);
      this.Controls.SetChildIndex(this.grdTickets, 0);
      this.Controls.SetChildIndex(this.txtValor, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.btnMarcarTodos, 0);
      this.Controls.SetChildIndex(this.btnDesmarcarTodos, 0);
      this.Controls.SetChildIndex(this.btnExcluir, 0);
      this.Controls.SetChildIndex(this.label5, 0);
      this.Controls.SetChildIndex(this.txtAtalho, 0);
      this.Controls.SetChildIndex(this.label4, 0);
      ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtDescricao;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox cbDOM;
    private System.Windows.Forms.CheckBox cbSEG;
    private System.Windows.Forms.CheckBox cbTER;
    private System.Windows.Forms.CheckBox cbQUA;
    private System.Windows.Forms.CheckBox cbQUI;
    private System.Windows.Forms.CheckBox cbSEX;
    private System.Windows.Forms.CheckBox cbSAB;
    private System.Windows.Forms.Button btnNovo;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.DataGridView grdTickets;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtValor;
    private System.Windows.Forms.Button btnMarcarTodos;
    private System.Windows.Forms.Button btnDesmarcarTodos;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtAtalho;
    private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    private System.Windows.Forms.DataGridViewTextBoxColumn Atalho;
    private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    private System.Windows.Forms.DataGridViewCheckBoxColumn DOM;
    private System.Windows.Forms.DataGridViewCheckBoxColumn SEG;
    private System.Windows.Forms.DataGridViewCheckBoxColumn TER;
    private System.Windows.Forms.DataGridViewCheckBoxColumn QUA;
    private System.Windows.Forms.DataGridViewCheckBoxColumn QUI;
    private System.Windows.Forms.DataGridViewCheckBoxColumn SEX;
    private System.Windows.Forms.DataGridViewCheckBoxColumn SAB;
  }
}

