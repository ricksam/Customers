namespace Folha_Marcelo
{
  partial class frmOPR_OPERACAO
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
      this.lblOPR_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtOPR_DESCRICAO = new lib.Visual.Components.sknTextBox();
      this.lblOPR_CAMPO = new lib.Visual.Components.sknLabel();
      this.txtOPR_CAMPO = new lib.Visual.Components.sknTextBox();
      this.lblOPR_CALCULO = new lib.Visual.Components.sknLabel();
      this.txtOPR_CALCULO = new lib.Visual.Components.sknTextBox();
      this.lblOPR_OBS = new lib.Visual.Components.sknLabel();
      this.txtOPR_OBS = new lib.Visual.Components.sknTextBox();
      this.lblOPR_TIPO = new lib.Visual.Components.sknLabel();
      this.lblOPR_NIVEL = new lib.Visual.Components.sknLabel();
      this.txtOPR_NIVEL = new lib.Visual.Components.sknTextBox();
      this.cbDiario = new System.Windows.Forms.CheckBox();
      this.cmbTipo = new System.Windows.Forms.ComboBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.cmbTipo);
      this.pnlEdit.Controls.Add(this.cbDiario);
      this.pnlEdit.Controls.Add(this.lblOPR_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtOPR_DESCRICAO);
      this.pnlEdit.Controls.Add(this.lblOPR_CAMPO);
      this.pnlEdit.Controls.Add(this.txtOPR_CAMPO);
      this.pnlEdit.Controls.Add(this.lblOPR_CALCULO);
      this.pnlEdit.Controls.Add(this.txtOPR_CALCULO);
      this.pnlEdit.Controls.Add(this.lblOPR_OBS);
      this.pnlEdit.Controls.Add(this.txtOPR_OBS);
      this.pnlEdit.Controls.Add(this.lblOPR_TIPO);
      this.pnlEdit.Controls.Add(this.lblOPR_NIVEL);
      this.pnlEdit.Controls.Add(this.txtOPR_NIVEL);
      this.pnlEdit.Size = new System.Drawing.Size(480, 235);
      // 
      // lblOPR_DESCRICAO
      // 
      this.lblOPR_DESCRICAO.AutoSize = true;
      this.lblOPR_DESCRICAO.Location = new System.Drawing.Point(12, 3);
      this.lblOPR_DESCRICAO.Name = "lblOPR_DESCRICAO";
      this.lblOPR_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblOPR_DESCRICAO.TabIndex = 0;
      this.lblOPR_DESCRICAO.Text = "Descrição";
      // 
      // txtOPR_DESCRICAO
      // 
      this.txtOPR_DESCRICAO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOPR_DESCRICAO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOPR_DESCRICAO.AutoTab = true;
      this.txtOPR_DESCRICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOPR_DESCRICAO.Location = new System.Drawing.Point(12, 19);
      this.txtOPR_DESCRICAO.Name = "txtOPR_DESCRICAO";
      this.txtOPR_DESCRICAO.Size = new System.Drawing.Size(222, 20);
      this.txtOPR_DESCRICAO.TabIndex = 1;
      this.txtOPR_DESCRICAO.TextFormat = null;
      this.txtOPR_DESCRICAO.TextType = lib.Visual.Components.enmTextType.String;
      this.txtOPR_DESCRICAO.Leave += new System.EventHandler(this.txtOPR_DESCRICAO_Leave);
      // 
      // lblOPR_CAMPO
      // 
      this.lblOPR_CAMPO.AutoSize = true;
      this.lblOPR_CAMPO.Location = new System.Drawing.Point(237, 3);
      this.lblOPR_CAMPO.Name = "lblOPR_CAMPO";
      this.lblOPR_CAMPO.Size = new System.Drawing.Size(86, 13);
      this.lblOPR_CAMPO.TabIndex = 2;
      this.lblOPR_CAMPO.Text = "Nome do Campo";
      // 
      // txtOPR_CAMPO
      // 
      this.txtOPR_CAMPO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOPR_CAMPO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOPR_CAMPO.AutoTab = true;
      this.txtOPR_CAMPO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOPR_CAMPO.Location = new System.Drawing.Point(240, 19);
      this.txtOPR_CAMPO.Name = "txtOPR_CAMPO";
      this.txtOPR_CAMPO.Size = new System.Drawing.Size(222, 20);
      this.txtOPR_CAMPO.TabIndex = 3;
      this.txtOPR_CAMPO.TextFormat = null;
      this.txtOPR_CAMPO.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblOPR_CALCULO
      // 
      this.lblOPR_CALCULO.AutoSize = true;
      this.lblOPR_CALCULO.Location = new System.Drawing.Point(12, 82);
      this.lblOPR_CALCULO.Name = "lblOPR_CALCULO";
      this.lblOPR_CALCULO.Size = new System.Drawing.Size(42, 13);
      this.lblOPR_CALCULO.TabIndex = 8;
      this.lblOPR_CALCULO.Text = "Cálculo";
      // 
      // txtOPR_CALCULO
      // 
      this.txtOPR_CALCULO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOPR_CALCULO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOPR_CALCULO.AutoTab = true;
      this.txtOPR_CALCULO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOPR_CALCULO.Location = new System.Drawing.Point(12, 98);
      this.txtOPR_CALCULO.Multiline = true;
      this.txtOPR_CALCULO.Name = "txtOPR_CALCULO";
      this.txtOPR_CALCULO.Size = new System.Drawing.Size(450, 40);
      this.txtOPR_CALCULO.TabIndex = 9;
      this.txtOPR_CALCULO.TextFormat = null;
      this.txtOPR_CALCULO.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblOPR_OBS
      // 
      this.lblOPR_OBS.AutoSize = true;
      this.lblOPR_OBS.Location = new System.Drawing.Point(12, 141);
      this.lblOPR_OBS.Name = "lblOPR_OBS";
      this.lblOPR_OBS.Size = new System.Drawing.Size(32, 13);
      this.lblOPR_OBS.TabIndex = 10;
      this.lblOPR_OBS.Text = "Obs.:";
      // 
      // txtOPR_OBS
      // 
      this.txtOPR_OBS.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOPR_OBS.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOPR_OBS.AutoTab = true;
      this.txtOPR_OBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOPR_OBS.Location = new System.Drawing.Point(12, 157);
      this.txtOPR_OBS.Multiline = true;
      this.txtOPR_OBS.Name = "txtOPR_OBS";
      this.txtOPR_OBS.Size = new System.Drawing.Size(450, 40);
      this.txtOPR_OBS.TabIndex = 11;
      this.txtOPR_OBS.TextFormat = null;
      this.txtOPR_OBS.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblOPR_TIPO
      // 
      this.lblOPR_TIPO.AutoSize = true;
      this.lblOPR_TIPO.Location = new System.Drawing.Point(12, 42);
      this.lblOPR_TIPO.Name = "lblOPR_TIPO";
      this.lblOPR_TIPO.Size = new System.Drawing.Size(28, 13);
      this.lblOPR_TIPO.TabIndex = 4;
      this.lblOPR_TIPO.Text = "Tipo";
      // 
      // lblOPR_NIVEL
      // 
      this.lblOPR_NIVEL.AutoSize = true;
      this.lblOPR_NIVEL.Location = new System.Drawing.Point(108, 42);
      this.lblOPR_NIVEL.Name = "lblOPR_NIVEL";
      this.lblOPR_NIVEL.Size = new System.Drawing.Size(33, 13);
      this.lblOPR_NIVEL.TabIndex = 6;
      this.lblOPR_NIVEL.Text = "Nível";
      // 
      // txtOPR_NIVEL
      // 
      this.txtOPR_NIVEL.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOPR_NIVEL.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOPR_NIVEL.AutoTab = true;
      this.txtOPR_NIVEL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOPR_NIVEL.Location = new System.Drawing.Point(111, 58);
      this.txtOPR_NIVEL.Name = "txtOPR_NIVEL";
      this.txtOPR_NIVEL.Size = new System.Drawing.Size(82, 20);
      this.txtOPR_NIVEL.TabIndex = 7;
      this.txtOPR_NIVEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtOPR_NIVEL.TextFormat = null;
      this.txtOPR_NIVEL.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // cbDiario
      // 
      this.cbDiario.AutoSize = true;
      this.cbDiario.Location = new System.Drawing.Point(12, 203);
      this.cbDiario.Name = "cbDiario";
      this.cbDiario.Size = new System.Drawing.Size(199, 17);
      this.cbDiario.TabIndex = 12;
      this.cbDiario.Text = "Usar apenas em lançamentos diários";
      this.cbDiario.UseVisualStyleBackColor = true;
      // 
      // cmbTipo
      // 
      this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Location = new System.Drawing.Point(12, 58);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new System.Drawing.Size(93, 21);
      this.cmbTipo.TabIndex = 5;
      // 
      // frmOPR_OPERACAO
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 315);
      this.Name = "frmOPR_OPERACAO";
      this.Text = "Cadastro de Operações";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblOPR_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtOPR_DESCRICAO;
    private lib.Visual.Components.sknLabel lblOPR_CAMPO;
    private lib.Visual.Components.sknTextBox txtOPR_CAMPO;
    private lib.Visual.Components.sknLabel lblOPR_CALCULO;
    private lib.Visual.Components.sknTextBox txtOPR_CALCULO;
    private lib.Visual.Components.sknLabel lblOPR_OBS;
    private lib.Visual.Components.sknTextBox txtOPR_OBS;
    private lib.Visual.Components.sknLabel lblOPR_TIPO;
    private lib.Visual.Components.sknLabel lblOPR_NIVEL;
    private lib.Visual.Components.sknTextBox txtOPR_NIVEL;
    private System.Windows.Forms.CheckBox cbDiario;
    private System.Windows.Forms.ComboBox cmbTipo;
  }
}
