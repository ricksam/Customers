namespace MagiaTrigo
{
  partial class frmNotas
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
      this.lblNOT_OPR_CODIGO = new lib.Visual.Components.sknLabel();
      this.lblNOT_DOCUMENTO = new lib.Visual.Components.sknLabel();
      this.txtDocumento = new lib.Visual.Components.sknTextBox();
      this.lblNOT_EMISSAO = new lib.Visual.Components.sknLabel();
      this.cmbOperacao = new lib.Visual.Components.sknComboBox();
      this.sknGrid1 = new lib.Visual.Components.sknGrid();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.pnlEdit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.sknGrid1)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.dateTimePicker1);
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Controls.Add(this.sknGrid1);
      this.pnlEdit.Controls.Add(this.cmbOperacao);
      this.pnlEdit.Controls.Add(this.lblNOT_OPR_CODIGO);
      this.pnlEdit.Controls.Add(this.lblNOT_DOCUMENTO);
      this.pnlEdit.Controls.Add(this.txtDocumento);
      this.pnlEdit.Controls.Add(this.lblNOT_EMISSAO);
      this.pnlEdit.Size = new System.Drawing.Size(524, 224);
      // 
      // lblNOT_OPR_CODIGO
      // 
      this.lblNOT_OPR_CODIGO.AutoSize = true;
      this.lblNOT_OPR_CODIGO.Location = new System.Drawing.Point(12, 3);
      this.lblNOT_OPR_CODIGO.Name = "lblNOT_OPR_CODIGO";
      this.lblNOT_OPR_CODIGO.Size = new System.Drawing.Size(54, 13);
      this.lblNOT_OPR_CODIGO.TabIndex = 1;
      this.lblNOT_OPR_CODIGO.Text = "Operação";
      // 
      // lblNOT_DOCUMENTO
      // 
      this.lblNOT_DOCUMENTO.AutoSize = true;
      this.lblNOT_DOCUMENTO.Location = new System.Drawing.Point(188, 3);
      this.lblNOT_DOCUMENTO.Name = "lblNOT_DOCUMENTO";
      this.lblNOT_DOCUMENTO.Size = new System.Drawing.Size(62, 13);
      this.lblNOT_DOCUMENTO.TabIndex = 3;
      this.lblNOT_DOCUMENTO.Text = "Documento";
      // 
      // txtDocumento
      // 
      this.txtDocumento.AsDateTime = new System.DateTime(((long)(0)));
      this.txtDocumento.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtDocumento.AutoTab = true;
      this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtDocumento.Location = new System.Drawing.Point(188, 19);
      this.txtDocumento.Name = "txtDocumento";
      this.txtDocumento.Size = new System.Drawing.Size(132, 20);
      this.txtDocumento.TabIndex = 4;
      this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtDocumento.TextFormat = null;
      this.txtDocumento.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // lblNOT_EMISSAO
      // 
      this.lblNOT_EMISSAO.AutoSize = true;
      this.lblNOT_EMISSAO.Location = new System.Drawing.Point(326, 3);
      this.lblNOT_EMISSAO.Name = "lblNOT_EMISSAO";
      this.lblNOT_EMISSAO.Size = new System.Drawing.Size(46, 13);
      this.lblNOT_EMISSAO.TabIndex = 7;
      this.lblNOT_EMISSAO.Text = "Emissão";
      // 
      // cmbOperacao
      // 
      this.cmbOperacao.AutoTab = true;
      this.cmbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOperacao.FormattingEnabled = true;
      this.cmbOperacao.Location = new System.Drawing.Point(12, 17);
      this.cmbOperacao.Name = "cmbOperacao";
      this.cmbOperacao.Size = new System.Drawing.Size(170, 21);
      this.cmbOperacao.TabIndex = 9;
      // 
      // sknGrid1
      // 
      this.sknGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.sknGrid1.Location = new System.Drawing.Point(12, 58);
      this.sknGrid1.Name = "sknGrid1";
      this.sknGrid1.Size = new System.Drawing.Size(500, 150);
      this.sknGrid1.TabIndex = 10;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 42);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(27, 13);
      this.sknLabel1.TabIndex = 11;
      this.sknLabel1.Text = "Item";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePicker1.Location = new System.Drawing.Point(326, 19);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(90, 20);
      this.dateTimePicker1.TabIndex = 13;
      // 
      // frmNotas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 304);
      this.Name = "frmNotas";
      this.Text = "Notas";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.sknGrid1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblNOT_OPR_CODIGO;
    private lib.Visual.Components.sknLabel lblNOT_DOCUMENTO;
    private lib.Visual.Components.sknTextBox txtDocumento;
    private lib.Visual.Components.sknLabel lblNOT_EMISSAO;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknGrid sknGrid1;
    private lib.Visual.Components.sknComboBox cmbOperacao;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
  }
}
