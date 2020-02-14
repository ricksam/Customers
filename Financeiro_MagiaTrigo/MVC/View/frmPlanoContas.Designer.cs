namespace MagiaTrigo
{
  partial class frmPlanoContas
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
      this.lblPLN_TIPO = new lib.Visual.Components.sknLabel();
      this.lblPLN_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtDescricao = new lib.Visual.Components.sknTextBox();
      this.cmbTipo = new lib.Visual.Components.sknComboBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.cmbTipo);
      this.pnlEdit.Controls.Add(this.lblPLN_TIPO);
      this.pnlEdit.Controls.Add(this.lblPLN_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtDescricao);
      this.pnlEdit.Size = new System.Drawing.Size(475, 93);
      // 
      // lblPLN_TIPO
      // 
      this.lblPLN_TIPO.AutoSize = true;
      this.lblPLN_TIPO.Location = new System.Drawing.Point(12, 3);
      this.lblPLN_TIPO.Name = "lblPLN_TIPO";
      this.lblPLN_TIPO.Size = new System.Drawing.Size(28, 13);
      this.lblPLN_TIPO.TabIndex = 1;
      this.lblPLN_TIPO.Text = "Tipo";
      // 
      // lblPLN_DESCRICAO
      // 
      this.lblPLN_DESCRICAO.AutoSize = true;
      this.lblPLN_DESCRICAO.Location = new System.Drawing.Point(12, 42);
      this.lblPLN_DESCRICAO.Name = "lblPLN_DESCRICAO";
      this.lblPLN_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblPLN_DESCRICAO.TabIndex = 3;
      this.lblPLN_DESCRICAO.Text = "Descrição";
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
      this.txtDescricao.Location = new System.Drawing.Point(12, 58);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(300, 20);
      this.txtDescricao.TabIndex = 4;
      this.txtDescricao.TextFormat = null;
      this.txtDescricao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // cmbTipo
      // 
      this.cmbTipo.AutoTab = true;
      this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Items.AddRange(new object[] {
            "Despesa",
            "Receita"});
      this.cmbTipo.Location = new System.Drawing.Point(12, 19);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new System.Drawing.Size(121, 21);
      this.cmbTipo.TabIndex = 5;
      // 
      // frmPlanoContas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 173);
      this.Name = "frmPlanoContas";
      this.Text = "Plano de Contas";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblPLN_TIPO;
    private lib.Visual.Components.sknLabel lblPLN_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtDescricao;
    private lib.Visual.Components.sknComboBox cmbTipo;
  }
}
