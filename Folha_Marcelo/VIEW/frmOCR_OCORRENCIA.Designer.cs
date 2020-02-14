namespace Folha_Marcelo
{
  partial class frmOCR_OCORRENCIA
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
      this.lblOCR_DESCRICAO = new lib.Visual.Components.sknLabel();
      this.txtOCR_DESCRICAO = new lib.Visual.Components.sknTextBox();
      this.lblOCR_DIAS_ALERTA = new lib.Visual.Components.sknLabel();
      this.txtOCR_DIAS_ALERTA = new lib.Visual.Components.sknTextBox();
      this.lblOCR_MENSAGEM_ALERTA = new lib.Visual.Components.sknLabel();
      this.txtOCR_MENSAGEM_ALERTA = new lib.Visual.Components.sknTextBox();
      this.sknLabel1 = new lib.Visual.Components.sknLabel();
      this.txtOCR_DIAS_FINAL_ALERTA = new lib.Visual.Components.sknTextBox();
      this.pnlEdit.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlEdit
      // 
      this.pnlEdit.Controls.Add(this.sknLabel1);
      this.pnlEdit.Controls.Add(this.txtOCR_DIAS_FINAL_ALERTA);
      this.pnlEdit.Controls.Add(this.lblOCR_DESCRICAO);
      this.pnlEdit.Controls.Add(this.txtOCR_DESCRICAO);
      this.pnlEdit.Controls.Add(this.lblOCR_DIAS_ALERTA);
      this.pnlEdit.Controls.Add(this.txtOCR_DIAS_ALERTA);
      this.pnlEdit.Controls.Add(this.lblOCR_MENSAGEM_ALERTA);
      this.pnlEdit.Controls.Add(this.txtOCR_MENSAGEM_ALERTA);
      this.pnlEdit.Size = new System.Drawing.Size(475, 166);
      // 
      // lblOCR_DESCRICAO
      // 
      this.lblOCR_DESCRICAO.AutoSize = true;
      this.lblOCR_DESCRICAO.Location = new System.Drawing.Point(12, 3);
      this.lblOCR_DESCRICAO.Name = "lblOCR_DESCRICAO";
      this.lblOCR_DESCRICAO.Size = new System.Drawing.Size(55, 13);
      this.lblOCR_DESCRICAO.TabIndex = 0;
      this.lblOCR_DESCRICAO.Text = "Descrição";
      // 
      // txtOCR_DESCRICAO
      // 
      this.txtOCR_DESCRICAO.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOCR_DESCRICAO.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOCR_DESCRICAO.AutoTab = true;
      this.txtOCR_DESCRICAO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOCR_DESCRICAO.Location = new System.Drawing.Point(12, 19);
      this.txtOCR_DESCRICAO.Name = "txtOCR_DESCRICAO";
      this.txtOCR_DESCRICAO.Size = new System.Drawing.Size(200, 20);
      this.txtOCR_DESCRICAO.TabIndex = 1;
      this.txtOCR_DESCRICAO.TextFormat = null;
      this.txtOCR_DESCRICAO.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // lblOCR_DIAS_ALERTA
      // 
      this.lblOCR_DIAS_ALERTA.AutoSize = true;
      this.lblOCR_DIAS_ALERTA.Location = new System.Drawing.Point(12, 42);
      this.lblOCR_DIAS_ALERTA.Name = "lblOCR_DIAS_ALERTA";
      this.lblOCR_DIAS_ALERTA.Size = new System.Drawing.Size(232, 13);
      this.lblOCR_DIAS_ALERTA.TabIndex = 2;
      this.lblOCR_DIAS_ALERTA.Text = "Quantidade de dias para enviar o primeiro alerta";
      // 
      // txtOCR_DIAS_ALERTA
      // 
      this.txtOCR_DIAS_ALERTA.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOCR_DIAS_ALERTA.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOCR_DIAS_ALERTA.AutoTab = true;
      this.txtOCR_DIAS_ALERTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOCR_DIAS_ALERTA.Location = new System.Drawing.Point(12, 58);
      this.txtOCR_DIAS_ALERTA.Name = "txtOCR_DIAS_ALERTA";
      this.txtOCR_DIAS_ALERTA.Size = new System.Drawing.Size(120, 20);
      this.txtOCR_DIAS_ALERTA.TabIndex = 3;
      this.txtOCR_DIAS_ALERTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtOCR_DIAS_ALERTA.TextFormat = null;
      this.txtOCR_DIAS_ALERTA.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // lblOCR_MENSAGEM_ALERTA
      // 
      this.lblOCR_MENSAGEM_ALERTA.AutoSize = true;
      this.lblOCR_MENSAGEM_ALERTA.Location = new System.Drawing.Point(12, 120);
      this.lblOCR_MENSAGEM_ALERTA.Name = "lblOCR_MENSAGEM_ALERTA";
      this.lblOCR_MENSAGEM_ALERTA.Size = new System.Drawing.Size(103, 13);
      this.lblOCR_MENSAGEM_ALERTA.TabIndex = 6;
      this.lblOCR_MENSAGEM_ALERTA.Text = "Mansagem de alerta";
      // 
      // txtOCR_MENSAGEM_ALERTA
      // 
      this.txtOCR_MENSAGEM_ALERTA.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOCR_MENSAGEM_ALERTA.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOCR_MENSAGEM_ALERTA.AutoTab = true;
      this.txtOCR_MENSAGEM_ALERTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOCR_MENSAGEM_ALERTA.Location = new System.Drawing.Point(12, 136);
      this.txtOCR_MENSAGEM_ALERTA.Name = "txtOCR_MENSAGEM_ALERTA";
      this.txtOCR_MENSAGEM_ALERTA.Size = new System.Drawing.Size(451, 20);
      this.txtOCR_MENSAGEM_ALERTA.TabIndex = 7;
      this.txtOCR_MENSAGEM_ALERTA.TextFormat = null;
      this.txtOCR_MENSAGEM_ALERTA.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // sknLabel1
      // 
      this.sknLabel1.AutoSize = true;
      this.sknLabel1.Location = new System.Drawing.Point(12, 81);
      this.sknLabel1.Name = "sknLabel1";
      this.sknLabel1.Size = new System.Drawing.Size(215, 13);
      this.sknLabel1.TabIndex = 4;
      this.sknLabel1.Text = "Quantidade de dias para enviar o alerta final";
      // 
      // txtOCR_DIAS_FINAL_ALERTA
      // 
      this.txtOCR_DIAS_FINAL_ALERTA.AsDateTime = new System.DateTime(((long)(0)));
      this.txtOCR_DIAS_FINAL_ALERTA.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtOCR_DIAS_FINAL_ALERTA.AutoTab = true;
      this.txtOCR_DIAS_FINAL_ALERTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtOCR_DIAS_FINAL_ALERTA.Location = new System.Drawing.Point(12, 97);
      this.txtOCR_DIAS_FINAL_ALERTA.Name = "txtOCR_DIAS_FINAL_ALERTA";
      this.txtOCR_DIAS_FINAL_ALERTA.Size = new System.Drawing.Size(120, 20);
      this.txtOCR_DIAS_FINAL_ALERTA.TabIndex = 5;
      this.txtOCR_DIAS_FINAL_ALERTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtOCR_DIAS_FINAL_ALERTA.TextFormat = null;
      this.txtOCR_DIAS_FINAL_ALERTA.TextType = lib.Visual.Components.enmTextType.Int;
      // 
      // frmOCR_OCORRENCIA
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 246);
      this.Name = "frmOCR_OCORRENCIA";
      this.Text = "Ocorrências";
      this.Search += new lib.Visual.Forms.FormSearch.OnSearch_Handle(this.Form_Search);
      this.pnlEdit.ResumeLayout(false);
      this.pnlEdit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknLabel lblOCR_DESCRICAO;
    private lib.Visual.Components.sknTextBox txtOCR_DESCRICAO;
    private lib.Visual.Components.sknLabel lblOCR_DIAS_ALERTA;
    private lib.Visual.Components.sknTextBox txtOCR_DIAS_ALERTA;
    private lib.Visual.Components.sknLabel lblOCR_MENSAGEM_ALERTA;
    private lib.Visual.Components.sknTextBox txtOCR_MENSAGEM_ALERTA;
    private lib.Visual.Components.sknLabel sknLabel1;
    private lib.Visual.Components.sknTextBox txtOCR_DIAS_FINAL_ALERTA;
  }
}
