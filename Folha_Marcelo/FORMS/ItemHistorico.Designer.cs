namespace Folha_Marcelo
{
  partial class ItemHistorico
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemHistorico));
      this.label1 = new System.Windows.Forms.Label();
      this.dtData = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbOcorrencias = new lib.Visual.Components.sknComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtObservacao = new lib.Visual.Components.sknTextBox();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.txtObservacao);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.cmbOcorrencias);
      this.pnlContext.Controls.Add(this.label2);
      this.pnlContext.Controls.Add(this.dtData);
      this.pnlContext.Controls.Add(this.label1);
      this.pnlContext.Size = new System.Drawing.Size(384, 217);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Size = new System.Drawing.Size(384, 45);
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(186, 8);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(282, 8);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Data";
      // 
      // dtData
      // 
      this.dtData.CustomFormat = "dd/MM/yyyy";
      this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtData.Location = new System.Drawing.Point(12, 25);
      this.dtData.Name = "dtData";
      this.dtData.Size = new System.Drawing.Size(121, 20);
      this.dtData.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ocorrência";
      // 
      // cmbOcorrencias
      // 
      this.cmbOcorrencias.AutoTab = true;
      this.cmbOcorrencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOcorrencias.FormattingEnabled = true;
      this.cmbOcorrencias.Location = new System.Drawing.Point(12, 64);
      this.cmbOcorrencias.Name = "cmbOcorrencias";
      this.cmbOcorrencias.Size = new System.Drawing.Size(360, 21);
      this.cmbOcorrencias.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(65, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Observação";
      // 
      // txtObservacao
      // 
      this.txtObservacao.AsDateTime = new System.DateTime(((long)(0)));
      this.txtObservacao.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtObservacao.AutoTab = true;
      this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtObservacao.Location = new System.Drawing.Point(12, 104);
      this.txtObservacao.Multiline = true;
      this.txtObservacao.Name = "txtObservacao";
      this.txtObservacao.Size = new System.Drawing.Size(360, 107);
      this.txtObservacao.TabIndex = 5;
      this.txtObservacao.TextFormat = null;
      this.txtObservacao.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // ItemHistorico
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 262);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ItemHistorico";
      this.Text = "Historico";
      this.Load += new System.EventHandler(this.ItemHistorico_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private lib.Visual.Components.sknTextBox txtObservacao;
    private System.Windows.Forms.Label label3;
    private lib.Visual.Components.sknComboBox cmbOcorrencias;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtData;
    private System.Windows.Forms.Label label1;

  }
}