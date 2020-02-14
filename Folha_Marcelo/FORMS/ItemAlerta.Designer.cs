namespace Folha_Marcelo
{
  partial class ItemAlerta
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAlerta));
      this.label1 = new System.Windows.Forms.Label();
      this.dtData = new System.Windows.Forms.DateTimePicker();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMensagem = new lib.Visual.Components.sknTextBox();
      this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.pnlContext.SuspendLayout();
      this.pnlBottom.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlContext
      // 
      this.pnlContext.Controls.Add(this.dtDataFinal);
      this.pnlContext.Controls.Add(this.label3);
      this.pnlContext.Controls.Add(this.txtMensagem);
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
      this.label1.Size = new System.Drawing.Size(113, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Data do primeiro alerta";
      // 
      // dtData
      // 
      this.dtData.CustomFormat = "dd/MM/yyyy";
      this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtData.Location = new System.Drawing.Point(12, 25);
      this.dtData.Name = "dtData";
      this.dtData.Size = new System.Drawing.Size(116, 20);
      this.dtData.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Mensagem";
      // 
      // txtMensagem
      // 
      this.txtMensagem.AsDateTime = new System.DateTime(((long)(0)));
      this.txtMensagem.AsDecimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtMensagem.AutoTab = true;
      this.txtMensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMensagem.Location = new System.Drawing.Point(12, 64);
      this.txtMensagem.Multiline = true;
      this.txtMensagem.Name = "txtMensagem";
      this.txtMensagem.Size = new System.Drawing.Size(360, 147);
      this.txtMensagem.TabIndex = 5;
      this.txtMensagem.TextFormat = null;
      this.txtMensagem.TextType = lib.Visual.Components.enmTextType.String;
      // 
      // dtDataFinal
      // 
      this.dtDataFinal.CustomFormat = "dd/MM/yyyy";
      this.dtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtDataFinal.Location = new System.Drawing.Point(134, 25);
      this.dtDataFinal.Name = "dtDataFinal";
      this.dtDataFinal.Size = new System.Drawing.Size(116, 20);
      this.dtDataFinal.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(134, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Data da Ocorrência";
      // 
      // ItemAlerta
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 262);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ItemAlerta";
      this.Text = "Alerta";
      this.Load += new System.EventHandler(this.ItemAlerta_Load);
      this.pnlContext.ResumeLayout(false);
      this.pnlContext.PerformLayout();
      this.pnlBottom.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private lib.Visual.Components.sknTextBox txtMensagem;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtData;
    private System.Windows.Forms.DateTimePicker dtDataFinal;
    private System.Windows.Forms.Label label3;
  }
}